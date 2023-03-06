using API_ToHMI_Translate.Components;
using API_ToHMI_Translate.Configuration;
using API_ToHMI_Translate.Methods;
using API_ToHMI_Translate.Modules;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace API_ToHMI_Translate
{
    public partial class MainForm : DevExpress.XtraBars.ToolbarForm.ToolbarForm
    {
        /// <summary>
        /// 系統資訊
        /// </summary>
        private SystemSetting SystemSetting { get; set; }
        /// <summary>
        /// API方法
        /// </summary>
        private APIMethod APIMethod { get; set; }
        /// <summary>
        /// 通訊物件
        /// </summary>
        private List<BaseComponent> BaseComponents { get; set; } = new List<BaseComponent>();
        /// <summary>
        /// 到站資訊
        /// </summary>
        public List<ArrData> ArrDatas { get; set; }
        /// <summary>
        /// 離站資訊
        /// </summary>
        public List<DepData> DepDatas { get; set; }
        public MainForm()
        {
            #region Serilog initial
            Log.Logger = new LoggerConfiguration()
                        .WriteTo.Console()
                        .WriteTo.File($"{AppDomain.CurrentDomain.BaseDirectory}\\log\\log-.txt",
                                      rollingInterval: RollingInterval.Day,
                                      outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
                        .CreateLogger();        //宣告Serilog初始化
            #endregion
            InitializeComponent();
            MaximizeBox = false;
            SystemSetting = InitialMethod.Sytem_Load();
            APIMethod = new APIMethod(SystemSetting);
            APIComponent api = new APIComponent(APIMethod, this);
            api.MyWorkState = true;
            BaseComponents.Add(api);
            ChangeGridStr();
            #region 最小化
            notifyIcon.MouseDoubleClick += (s, e) =>
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
                this.notifyIcon.Visible = false;
            };
            #endregion
            timer.Interval = 5000;
            timer.Enabled = true;
        }
        private void ChangeGridStr()
        {
            gvw_Arr.CustomColumnDisplayText += (s, e) =>
            {
                switch (e.Column.FieldName)
                {
                    case "statusarr":
                        {
                            if (e.Value != null)
                            {
                                string Index = e.Value.ToString();
                                switch (Index)
                                {
                                    case "1":
                                        {
                                            e.DisplayText = "準時 On Time";
                                        }
                                        break;
                                    case "2":
                                        {
                                            e.DisplayText = "抵達Arrived";
                                        }
                                        break;
                                    case "3":
                                        {
                                            e.DisplayText = "延誤Delayed";
                                        }
                                        break;
                                    case "4":
                                        {
                                            e.DisplayText = "轉降Diverted";
                                        }
                                        break;
                                    case "5":
                                        {
                                            e.DisplayText = "取消Cancelled";
                                        }
                                        break;
                                }
                            }
                        }
                        break;
                    case "notearr":
                        {
                            if (e.Value != null)
                            {
                                string Index = e.Value.ToString();
                                switch (Index)
                                {
                                    case "0":
                                        {
                                            e.DisplayText = "";
                                        }
                                        break;
                                    case "1":
                                        {
                                            e.DisplayText = "天氣影響";
                                        }
                                        break;
                                    case "2":
                                        {
                                            e.DisplayText = "流量管制";
                                        }
                                        break;
                                    case "3":
                                        {
                                            e.DisplayText = "班機調度";
                                        }
                                        break;
                                    case "4":
                                        {
                                            e.DisplayText = "航機檢修";
                                        }
                                        break;
                                    case "5":
                                        {
                                            e.DisplayText = "班機返航";
                                        }
                                        break;
                                    case "6":
                                        {
                                            e.DisplayText = "轉降松山";
                                        }
                                        break;
                                    case "7":
                                        {
                                            e.DisplayText = "轉降臺南";
                                        }
                                        break;
                                    case "8":
                                        {
                                            e.DisplayText = "轉降臺中";
                                        }
                                        break;
                                    case "9":
                                        {
                                            e.DisplayText = "轉降澎湖";
                                        }
                                        break;
                                    case "10":
                                        {
                                            e.DisplayText = "轉降桃園";
                                        }
                                        break;
                                    case "11":
                                        {
                                            e.DisplayText = "轉降香港";
                                        }
                                        break;
                                    case "12":
                                        {
                                            e.DisplayText = "延至明日";
                                        }
                                        break;
                                    case "13":
                                        {
                                            e.DisplayText = "機場關閉";
                                        }
                                        break;
                                }
                            }
                        }
                        break;
                    case "F_TYPE":
                        {
                            if (e.Value != null)
                            {
                                string Index = e.Value.ToString();
                                switch (Index)
                                {
                                    case "PAX":
                                        {
                                            e.DisplayText = "客機";
                                        }
                                        break;
                                    case "EXT":
                                        {
                                            e.DisplayText = "加班機";
                                        }
                                        break;
                                    case "PAC":
                                        {
                                            e.DisplayText = "客機載貨";
                                        }
                                        break;
                                    case "CTR":
                                        {
                                            e.DisplayText = "包機";
                                        }
                                        break;
                                    case "CGO":
                                        {
                                            e.DisplayText = "貨機";
                                        }
                                        break;
                                    case "EMS":
                                        {
                                            e.DisplayText = "醫療後送";
                                        }
                                        break;
                                    case "FYC":
                                        {
                                            e.DisplayText = "放空調度";
                                        }
                                        break;
                                    case "TGO":
                                        {
                                            e.DisplayText = "觸地離場";
                                        }
                                        break;
                                    case "TEC":
                                        {
                                            e.DisplayText = "技降飛行";
                                        }
                                        break;
                                    case "":
                                        {
                                            e.DisplayText = "";
                                        }
                                        break;
                                    case "TRN":
                                        {
                                            e.DisplayText = "訓練飛行";
                                        }
                                        break;
                                    case "FCF":
                                        {
                                            e.DisplayText = "飛航測試";
                                        }
                                        break;
                                    case "FYM":
                                        {
                                            e.DisplayText = "放空修護";
                                        }
                                        break;
                                    case "LAP":
                                        {
                                            e.DisplayText = "低空飛過";
                                        }
                                        break;
                                    case "PHP":
                                        {
                                            e.DisplayText = "空照";
                                        }
                                        break;
                                    case "QRF":
                                        {
                                            e.DisplayText = "回航降落";
                                        }
                                        break;
                                    case "SOS":
                                        {
                                            e.DisplayText = "醫療專機";
                                        }
                                        break;
                                    case "SAR":
                                        {
                                            e.DisplayText = "搜救飛行";
                                        }
                                        break;
                                    case "TRF":
                                        {
                                            e.DisplayText = "過境加油";
                                        }
                                        break;
                                    case "TST":
                                        {
                                            e.DisplayText = "試飛";
                                        }
                                        break;
                                }
                            }
                        }
                        break;
                }
            };
            gvw_Dep.CustomColumnDisplayText += (s, e) =>
            {
                switch (e.Column.FieldName)
                {
                    case "statusdep":
                        {
                            if (e.Value != null)
                            {
                                string Index = e.Value.ToString();
                                switch (Index)
                                {
                                    case "1":
                                        {
                                            e.DisplayText = "準時 On Time";
                                        }
                                        break;
                                    case "2":
                                        {
                                            e.DisplayText = "報到Check In";
                                        }
                                        break;
                                    case "3":
                                        {
                                            e.DisplayText = "登機Boarding";
                                        }
                                        break;
                                    case "4":
                                        {
                                            e.DisplayText = "離站Departed";
                                        }
                                        break;
                                    case "5":
                                        {
                                            e.DisplayText = "延誤登機 Late Boarding";
                                        }
                                        break;
                                    case "6":
                                        {
                                            e.DisplayText = "延誤Delayed";
                                        }
                                        break;
                                    case "7":
                                        {
                                            e.DisplayText = "取消Cancelled";
                                        }
                                        break;
                                }
                            }
                        }
                        break;
                    case "notedep":
                        {
                            if (e.Value != null)
                            {
                                string Index = e.Value.ToString();
                                switch (Index)
                                {
                                    case "0":
                                        {
                                            e.DisplayText = "";
                                        }
                                        break;
                                    case "1":
                                        {
                                            e.DisplayText = "時間異動";
                                        }
                                        break;
                                    case "2":
                                        {
                                            e.DisplayText = "天氣影響";
                                        }
                                        break;
                                    case "3":
                                        {
                                            e.DisplayText = "地面作業";
                                        }
                                        break;
                                    case "4":
                                        {
                                            e.DisplayText = "來機晚到";
                                        }
                                        break;
                                    case "5":
                                        {
                                            e.DisplayText = "流量管制";
                                        }
                                        break;
                                    case "6":
                                        {
                                            e.DisplayText = "班機調度";
                                        }
                                        break;
                                    case "7":
                                        {
                                            e.DisplayText = "航機檢修";
                                        }
                                        break;
                                    case "8":
                                        {
                                            e.DisplayText = "航班退關";
                                        }
                                        break;
                                    case "9":
                                        {
                                            e.DisplayText = "延至明日";
                                        }
                                        break;
                                    case "10":
                                        {
                                            e.DisplayText = "前日航班";
                                        }
                                        break;
                                    case "11":
                                        {
                                            e.DisplayText = "機場關閉";
                                        }
                                        break;
                                }
                            }
                        }
                        break;
                    case "F_TYPE":
                        {
                            if (e.Value != null)
                            {
                                string Index = e.Value.ToString();
                                switch (Index)
                                {
                                    case "PAX":
                                        {
                                            e.DisplayText = "客機";
                                        }
                                        break;
                                    case "EXT":
                                        {
                                            e.DisplayText = "加班機";
                                        }
                                        break;
                                    case "PAC":
                                        {
                                            e.DisplayText = "客機載貨";
                                        }
                                        break;
                                    case "CTR":
                                        {
                                            e.DisplayText = "包機";
                                        }
                                        break;
                                    case "CGO":
                                        {
                                            e.DisplayText = "貨機";
                                        }
                                        break;
                                    case "EMS":
                                        {
                                            e.DisplayText = "醫療後送";
                                        }
                                        break;
                                    case "FYC":
                                        {
                                            e.DisplayText = "放空調度";
                                        }
                                        break;
                                    case "TGO":
                                        {
                                            e.DisplayText = "觸地離場";
                                        }
                                        break;
                                    case "TEC":
                                        {
                                            e.DisplayText = "技降飛行";
                                        }
                                        break;
                                    case "":
                                        {
                                            e.DisplayText = "";
                                        }
                                        break;
                                    case "TRN":
                                        {
                                            e.DisplayText = "訓練飛行";
                                        }
                                        break;
                                    case "FCF":
                                        {
                                            e.DisplayText = "飛航測試";
                                        }
                                        break;
                                    case "FYM":
                                        {
                                            e.DisplayText = "放空修護";
                                        }
                                        break;
                                    case "LAP":
                                        {
                                            e.DisplayText = "低空飛過";
                                        }
                                        break;
                                    case "PHP":
                                        {
                                            e.DisplayText = "空照";
                                        }
                                        break;
                                    case "QRF":
                                        {
                                            e.DisplayText = "回航降落";
                                        }
                                        break;
                                    case "SOS":
                                        {
                                            e.DisplayText = "醫療專機";
                                        }
                                        break;
                                    case "SAR":
                                        {
                                            e.DisplayText = "搜救飛行";
                                        }
                                        break;
                                    case "TRF":
                                        {
                                            e.DisplayText = "過境加油";
                                        }
                                        break;
                                    case "TST":
                                        {
                                            e.DisplayText = "試飛";
                                        }
                                        break;
                                }
                            }
                        }
                        break;
                }
            };
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            switch (xtraTabControl1.SelectedTabPageIndex)
            {
                case 0://到站
                    {
                        if (APIMethod.Arr_ClientFlag)
                        {
                            stateIndicatorComponent1.StateIndex = 3;
                        }
                        else
                        {
                            stateIndicatorComponent1.StateIndex = 1;
                        }
                        lbl_Arr_Time.Text = APIMethod.Arr_ErrorStr;
                        if (ArrDatas != null)
                        {
                            gcl_Arr.DataSource = ArrDatas.Where(w => Convert.ToDateTime(w.FDATE) >= Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd 00:00:00"))).ToList();
                            for (int i = 0; i < gvw_Arr.Columns.Count; i++)
                            {
                                gvw_Arr.Columns[i].BestFit();
                            }
                        }
                    }
                    break;
                case 1://離站
                    {
                        if (APIMethod.Dep_ClientFlag)
                        {
                            stateIndicatorComponent2.StateIndex = 3;
                        }
                        else
                        {
                            stateIndicatorComponent2.StateIndex = 1;
                        }
                        lbl_Dep_Time.Text = APIMethod.Dep_ErrorStr;
                        if (DepDatas != null)
                        {
                            gcl_Dep.DataSource = DepDatas.Where(w => Convert.ToDateTime(w.FDATE) >= Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd 00:00:00"))).ToList();
                            for (int i = 0; i < gvw_Dep.Columns.Count; i++)
                            {
                                gvw_Dep.Columns[i].BestFit();
                            }
                        }
                    }
                    break;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (BaseComponents.Count > 0)
            {
                foreach (var item in BaseComponents)
                {
                    item.MyWorkState = false;
                }
            }
            timer.Enabled = false;
            this.notifyIcon.Visible = false;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                this.notifyIcon.Visible = true;
            }
        }
    }
}