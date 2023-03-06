using API_ToHMI_Translate.Methods;
using API_ToHMI_Translate.Modules;
using Serilog;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading;

namespace API_ToHMI_Translate.Components
{
    public class BaseComponent : Component
    {
        #region Component初始化
        public BaseComponent()
        {
            OnMyWorkStateChanged += new MyWorkStateChanged(AfterMyWorkStateChanged);
        }
        public delegate void MyWorkStateChanged(object sender, EventArgs e);
        public event MyWorkStateChanged OnMyWorkStateChanged;
        /// <summary>
        /// 通訊功能啟動判斷旗標
        /// </summary>
        protected bool myWorkState;
        /// <summary>
        /// 通訊功能啟動旗標
        /// </summary>
        public bool MyWorkState
        {
            get { return myWorkState; }
            set
            {
                if (value != myWorkState)
                {
                    myWorkState = value;
                    WhenMyWorkStateChange();
                }
            }
        }
        /// <summary>
        /// 執行續工作狀態改變觸發事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected virtual void AfterMyWorkStateChanged(object sender, EventArgs e) { }
        protected void WhenMyWorkStateChange()
        {
            OnMyWorkStateChanged?.Invoke(this, null);
        }
        /// <summary>
        /// 執行緒
        /// </summary>
        public Thread ComponentThread { get; set; }
        /// <summary>
        /// 時間
        /// </summary>
        public DateTime ComponentTime { get; set; }
        #endregion
        /// <summary>
        /// API方法
        /// </summary>
        public APIMethod APIMethod { get; set; }
        /// <summary>
        /// 主視窗資訊
        /// </summary>
        public MainForm MainForm { get; set; }
        public List<ArrData> ArrDatas { get; set; } = new List<ArrData>();
        public List<DepData> DepDatas { get; set; } = new List<DepData>();
        protected bool Data_Read()
        {
            try
            {
                if (myWorkState)
                {
                    ArrDatas = APIMethod.Get_Arr();
                    MainForm.ArrDatas = ArrDatas;
                }
            }
            catch (ThreadAbortException) { }
            catch (Exception ex)
            {
                Log.Error(ex, "到站API錯誤");
            }
            Thread.Sleep(80);
            try
            {
                if (myWorkState)
                {
                    DepDatas = APIMethod.Get_Dep();
                    MainForm.DepDatas = DepDatas;
                }
            }
            catch (ThreadAbortException) { }
            catch (Exception ex)
            {
                Log.Error(ex, "離站API錯誤");
            }
            if (ArrDatas != null && DepDatas != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
