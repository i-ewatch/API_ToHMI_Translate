using API_ToHMI_Translate.Methods;
using API_ToHMI_Translate.Modules;
using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;

namespace API_ToHMI_Translate.Components
{
    public partial class APIComponent : BaseComponent
    {
        /// <summary>
        /// 轉傳到站物件
        /// </summary>
        private List<Translate_ArrData> Translate_ArrDatas { get; set; } = new List<Translate_ArrData>();
        /// <summary>
        /// 轉傳離站物件
        /// </summary>
        private List<Translate_DepData> Translate_DepDatas { get; set; } = new List<Translate_DepData>();
        /// <summary>
        /// 讀取API時間
        /// </summary>
        private int Read_API_Time { get; set; }
        /// <summary>
        /// 時間比對完成旗標
        /// </summary>
        private bool Time_CompleteFlag { get; set; }
        /// <summary>
        /// 讀取API完成旗標
        /// </summary>
        private bool[] CompleteFlag { get; set; }
        /// <summary>
        /// 第一次讀取API旗標
        /// </summary>
        private bool FirstFlag { get; set; } = false;
        private string Token { get; set; }
        public APIComponent(APIMethod aPIMethod, MainForm form)
        {
            InitializeComponent();
            APIMethod = aPIMethod;
            CompleteFlag = new bool[APIMethod.SystemSetting.Read_API_Time.Count];
            MainForm = form;
        }

        public APIComponent(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void AfterMyWorkStateChanged(object sender, EventArgs e)
        {
            if (myWorkState)
            {
                ComponentThread = new Thread(Analysis);
                ComponentThread.Start();
            }
            else
            {
                if (ComponentThread != null)
                {
                    ComponentThread.Abort();
                }
            }
        }
        protected void Analysis()
        {
            while (myWorkState)
            {
                TimeSpan timeSpan = DateTime.Now.Subtract(ComponentTime);
                if (timeSpan.TotalMilliseconds >= 1000)
                {
                    try
                    {
                        if (!FirstFlag)//第一次讀取
                        {
                            FirstFlag = Data_Read();
                        }
                        else
                        {
                            #region 換日線
                            if (DateTime.Now.ToString("HH:mm") == "00:00")
                            {
                                for (int i = 0; i < CompleteFlag.Length; i++)
                                {
                                    CompleteFlag[i] = false;
                                }
                                Read_API_Time = 0;
                                Time_CompleteFlag = false;
                            }
                            #endregion
                            for (int i = 0; i < APIMethod.SystemSetting.Read_API_Time.Count; i++)
                            {
                                if (!CompleteFlag[i] && DateTime.Now.ToString("HH:mm") == APIMethod.SystemSetting.Read_API_Time[i])
                                {
                                    CompleteFlag[i] = Data_Read();
                                    Read_API_Time = i;
                                    Time_CompleteFlag = false;
                                    break;
                                }
                            }
                        }
                        Time_Translate();
                    }
                    catch (ThreadAbortException) { }
                    catch (Exception ex)
                    {
                        Log.Error(ex, "到站離站API錯誤");
                    }
                }
                else
                {
                    Thread.Sleep(80);
                }
            }
        }

        private void Time_Translate()
        {
            if (!Time_CompleteFlag)
            {
                Token = APIMethod.Checked_Token();
                Log.Information(Token);
                Translate_ArrDatas = new List<Translate_ArrData>();
                Translate_DepDatas = new List<Translate_DepData>();
                if (ArrDatas != null)//到站
                {

                    Translate_ArrData_AT_On Translate_ArrData_AT_On = APIMethod.Get_Translate_ArrData_AT_On(Token);
                    Translate_ArrData_AT_Off Translate_ArrData_AT_Off = APIMethod.Get_Translate_ArrData_AT_Off(Token);
                    if (Translate_ArrData_AT_On != null && Translate_ArrData_AT_Off != null)
                    {
                        List<ArrData> arr = ArrDatas.Where(w => w.FDATE == DateTime.Now.ToString("yyyy-MM-dd") & w.statusarr != "5").ToList();//找出沒取消的到站航班
                        for (int i = 0; i < arr.Count; i++)
                        {

                            DateTime Arr_StartTime = Convert.ToDateTime(arr[i].STA).AddMinutes(Convert.ToInt32($"-{Translate_ArrData_AT_On.Value.Value}"));
                            DateTime Arr_EndTime = Convert.ToDateTime(arr[i].STA).AddMinutes(Convert.ToInt32(Translate_ArrData_AT_Off.Value.Value));
                            //DateTime Arr_StartTime = Convert.ToDateTime(arr[i].STA).AddMinutes(Convert.ToInt32($"-{120}"));
                            //DateTime Arr_EndTime = Convert.ToDateTime(arr[i].STA).AddMinutes(Convert.ToInt32(120));
                            bool Complete = DateTime.Now > Arr_EndTime;
                            if (i + 1 < arr.Count)
                            {
                                DateTime Next_Arr_StartTime = Convert.ToDateTime(arr[i + 1].STA).AddMinutes(Convert.ToInt32($"-{Translate_ArrData_AT_On.Value.Value}"));
                                DateTime Next_Arr_EndTime = Convert.ToDateTime(arr[i + 1].STA).AddMinutes(Convert.ToInt32(Translate_ArrData_AT_Off.Value.Value));
                                //DateTime Next_Arr_StartTime = Convert.ToDateTime(arr[i + 1].STA).AddMinutes(Convert.ToInt32($"-{120}"));
                                //DateTime Next_Arr_EndTime = Convert.ToDateTime(arr[i + 1].STA).AddMinutes(Convert.ToInt32(120));
                                bool Action = Next_Arr_StartTime <= Arr_EndTime;
                                Translate_ArrDatas.Add(new Translate_ArrData
                                {
                                    STA = $"班機抵達時間 : {Convert.ToDateTime(arr[i].STA):HH:mm} 到達",
                                    StartTime = Arr_StartTime,
                                    EndTime = Arr_EndTime,
                                    ActionFlag = Action,
                                    CompleteFlag = Complete
                                });
                            }
                            else
                            {
                                Translate_ArrDatas.Add(new Translate_ArrData
                                {
                                    STA = $"班機抵達時間 :  {Convert.ToDateTime(arr[i].STA):HH:mm} 到達",
                                    StartTime = Arr_StartTime,
                                    EndTime = Arr_EndTime,
                                    ActionFlag = false,
                                    CompleteFlag = Complete
                                });
                            }
                        }
                    }
                }
                if (DepDatas != null)//離站
                {
                    Translate_DepData_AT_On Translate_DepData_AT_On = APIMethod.Get_Translate_DepData_AT_On(Token);
                    Translate_DepData_AT_Off Translate_DepData_AT_Off = APIMethod.Get_Translate_DepData_AT_Off(Token);
                    if (Translate_DepData_AT_On != null && Translate_DepData_AT_Off != null)
                    {
                        var dep = DepDatas.Where(w => w.FDATE == DateTime.Now.ToString("yyyy-MM-dd") && w.statusdep != "7").ToList();//找出沒取消的離站航班
                        for (int i = 0; i < dep.Count; i++)
                        {
                            DateTime Dep_StartTime = Convert.ToDateTime(dep[i].STD).AddMinutes(Convert.ToInt32($"-{Translate_DepData_AT_On.Value.Value}"));
                            DateTime Dep_EndTime = Convert.ToDateTime(dep[i].STD).AddMinutes(Convert.ToInt32(Translate_DepData_AT_Off.Value.Value));
                            //DateTime Dep_StartTime = Convert.ToDateTime(dep[i].STD).AddMinutes(Convert.ToInt32($"-{120}"));
                            //DateTime Dep_EndTime = Convert.ToDateTime(dep[i].STD).AddMinutes(Convert.ToInt32(120));
                            bool Complete = DateTime.Now > Dep_EndTime;
                            if (i + 1 < dep.Count)
                            {
                                DateTime Next_Dep_StartTime = Convert.ToDateTime(dep[i + 1].STD).AddMinutes(Convert.ToInt32($"-{Translate_DepData_AT_On.Value.Value}"));
                                DateTime Next_Dep_EndTime = Convert.ToDateTime(dep[i + 1].STD).AddMinutes(Convert.ToInt32(Translate_DepData_AT_Off.Value.Value));
                                //DateTime Next_Dep_StartTime = Convert.ToDateTime(dep[i + 1].STD).AddMinutes(Convert.ToInt32($"-{120}"));
                                //DateTime Next_Dep_EndTime = Convert.ToDateTime(dep[i + 1].STD).AddMinutes(Convert.ToInt32(120));
                                bool Action = Next_Dep_StartTime <= Dep_EndTime;
                                Translate_DepDatas.Add(new Translate_DepData
                                {
                                    STD = $"班機出境時間 : {Convert.ToDateTime(dep[i].STD):HH:mm} 飛離",
                                    StartTime = Dep_StartTime,
                                    EndTime = Dep_EndTime,
                                    ActionFlag = Action,
                                    CompleteFlag = Complete
                                });
                            }
                            else
                            {
                                Translate_DepDatas.Add(new Translate_DepData
                                {
                                    STD = $"班機出境時間 :{Convert.ToDateTime(dep[i].STD):HH:mm} 飛離",
                                    StartTime = Dep_StartTime,
                                    EndTime = Dep_EndTime,
                                    ActionFlag = false,
                                    CompleteFlag = Complete
                                });
                            }
                        }
                    }
                }
                if (Translate_ArrDatas.Count > 0 && Translate_DepDatas.Count > 0)
                {
                    Time_CompleteFlag = true;
                }
                Log.Information($"Translate_ArrDatas : {Translate_ArrDatas.Count} , Translate_DepDatas : {Translate_DepDatas.Count}");
            }
            #region 到站邏輯
            if (Translate_ArrDatas.Count > 0)
            {
                for (int i = 0; i < Translate_ArrDatas.Count; i++)//到站邏輯
                {
                    if (!Translate_ArrDatas[i].CompleteFlag)
                    {
                        if (Translate_ArrDatas[i].ActionFlag)//持續開機
                        {
                            if (DateTime.Now >= Translate_ArrDatas[i].StartTime && DateTime.Now <= Translate_ArrDatas[i].EndTime && !Translate_ArrDatas[i].WriteFlag)
                            {
                                Arr_PostData STA = new Arr_PostData
                                {
                                    Name = "Value",
                                    DataType = "BasicString",
                                    Value = $"{Translate_ArrDatas[i].STA}"
                                };
                                Arr_PostData AHU_CL = new Arr_PostData
                                {
                                    Name = "Value",
                                    DataType = "ExtendedReal",
                                    Value = $"{Convert.ToInt32(Translate_ArrDatas[i].ActionFlag)}"
                                };
                                Token = APIMethod.Checked_Token();
                                if (APIMethod.Post_Arr_AUH_CL(AHU_CL, Token) && APIMethod.Post_Arr_STA(STA, Token))
                                {
                                    Translate_ArrDatas[i].WriteFlag = true;
                                    break;
                                }
                            }
                            else if (DateTime.Now >= Translate_ArrDatas[i].EndTime)
                            {
                                Translate_ArrDatas[i].CompleteFlag = true;
                            }
                        }
                        else//需要關機
                        {
                            if (DateTime.Now >= Translate_ArrDatas[i].StartTime && DateTime.Now <= Translate_ArrDatas[i].EndTime && !Translate_ArrDatas[i].WriteFlag)
                            {
                                Arr_PostData STA = new Arr_PostData
                                {
                                    Name = "Value",
                                    DataType = "BasicString",
                                    Value = $"{Translate_ArrDatas[i].STA}"
                                };
                                Arr_PostData AHU_CL = new Arr_PostData
                                {
                                    Name = "Value",
                                    DataType = "ExtendedReal",
                                    Value = $"{Convert.ToInt32(!Translate_ArrDatas[i].ActionFlag)}"
                                };
                                Token = APIMethod.Checked_Token();
                                if (APIMethod.Post_Arr_AUH_CL(AHU_CL, Token) && APIMethod.Post_Arr_STA(STA, Token))
                                {
                                    Translate_ArrDatas[i].WriteFlag = true;
                                    break;
                                }
                            }
                            else if (DateTime.Now > Translate_ArrDatas[i].EndTime && Translate_ArrDatas[i].WriteFlag)
                            {
                                Arr_PostData AHU_CL = new Arr_PostData
                                {
                                    Name = "Value",
                                    DataType = "ExtendedReal",
                                    Value = $"{Convert.ToInt32(!Translate_ArrDatas[i].ActionFlag)}"
                                };
                                Token = APIMethod.Checked_Token();
                                if (APIMethod.Post_Arr_AUH_CL(AHU_CL, Token))
                                {
                                    Translate_ArrDatas[i].WriteFlag = false;
                                }
                            }
                            else if (DateTime.Now > Translate_ArrDatas[i].EndTime && !Translate_ArrDatas[i].WriteFlag)
                            {
                                Translate_ArrDatas[i].CompleteFlag = true;
                            }
                        }
                    }
                }
            }
            #endregion
            #region 離站
            if (Translate_DepDatas.Count > 0)
            {
                for (int i = 0; i < Translate_DepDatas.Count; i++)
                {
                    if (!Translate_DepDatas[i].CompleteFlag)
                    {
                        if (Translate_DepDatas[i].ActionFlag)//持續開機
                        {
                            if (DateTime.Now >= Translate_DepDatas[i].StartTime && DateTime.Now <= Translate_DepDatas[i].EndTime && !Translate_DepDatas[i].WriteFlag)
                            {
                                Dep_PostData STD = new Dep_PostData
                                {
                                    Name = "Value",
                                    DataType = "BasicString",
                                    Value = $"{Translate_DepDatas[i].STD}"
                                };
                                Dep_PostData AHU_CL = new Dep_PostData
                                {
                                    Name = "Value",
                                    DataType = "ExtendedReal",
                                    Value = $"{Convert.ToInt32(Translate_DepDatas[i].ActionFlag)}"
                                };
                                Token = APIMethod.Checked_Token();
                                if (APIMethod.Post_Dep_AUH_CL(AHU_CL, Token) && APIMethod.Post_Dep_STD(STD, Token))
                                {
                                    Translate_DepDatas[i].WriteFlag = true;
                                    break;
                                }
                            }
                            else if (DateTime.Now >= Translate_DepDatas[i].EndTime)
                            {
                                Translate_DepDatas[i].CompleteFlag = true;
                            }
                        }
                        else//需要關機
                        {
                            if (DateTime.Now >= Translate_DepDatas[i].StartTime && DateTime.Now <= Translate_DepDatas[i].EndTime && !Translate_DepDatas[i].WriteFlag)
                            {
                                Dep_PostData STD = new Dep_PostData
                                {
                                    Name = "Value",
                                    DataType = "BasicString",
                                    Value = $"{Translate_DepDatas[i].STD}"
                                };
                                Dep_PostData AHU_CL = new Dep_PostData
                                {
                                    Name = "Value",
                                    DataType = "ExtendedReal",
                                    Value = $"{Convert.ToInt32(Translate_DepDatas[i].ActionFlag)}"
                                };
                                Token = APIMethod.Checked_Token();
                                if (APIMethod.Post_Dep_AUH_CL(AHU_CL, Token) && APIMethod.Post_Dep_STD(STD, Token))
                                {
                                    Translate_DepDatas[i].WriteFlag = true;
                                    break;
                                }
                            }
                            else if (DateTime.Now > Translate_DepDatas[i].EndTime && Translate_DepDatas[i].WriteFlag)
                            {
                                Dep_PostData AHU_CL = new Dep_PostData
                                {
                                    Name = "Value",
                                    DataType = "ExtendedReal",
                                    Value = $"{Convert.ToInt32(Translate_DepDatas[i].ActionFlag)}"
                                };
                                Token = APIMethod.Checked_Token();
                                if (APIMethod.Post_Dep_AUH_CL(AHU_CL, Token))
                                {
                                    Translate_DepDatas[i].WriteFlag = true;
                                    break;
                                }
                            }
                            else if (DateTime.Now > Translate_DepDatas[i].EndTime && !Translate_DepDatas[i].WriteFlag)
                            {
                                Translate_DepDatas[i].CompleteFlag = true;
                            }
                        }
                    }
                }
            }
            #endregion
        }
    }
}
