namespace API_ToHMI_Translate.Modules
{
    public class DepData
    {
        /// <summary>
        /// 航班日期 ex:2022-08-18
        /// </summary>
        public string FDATE { get; set; }
        /// <summary>
        /// 表定離站時間ex:2022-08-18 17:15:00
        /// </summary>
        public string STD { get; set; }
        /// <summary>
        /// 實際離站時間（跑道起飛時間）ex: 2022-08-18 17:20:00
        /// </summary>
        public string ATD { get; set; }
        /// <summary>
        /// 表定抵達時間ex: 2022-08-18 17:20:00
        /// </summary>
        public string STA { get; set; }
        /// <summary>
        /// 航空公司通報離站（停止登機時間）時間ex: 2022-08-18 17:10:00
        /// </summary>
        public string deptime { get; set; }
        /// <summary>
        /// 航空公司代碼(IATA) ex:AE
        /// </summary>
        public string airLineIATA { get; set; }
        /// <summary>
        /// 航班編號 ex:AE309
        /// </summary>
        public string airLineNum { get; set; }
        /// <summary>
        /// 共享航班編號 ex:AA309,BB309
        /// </summary>
        public string CodeShare { get; set; }
        /// <summary>
        /// 目的機場代碼(IATA) ex:KNH
        /// </summary>
        public string ArrivalAirportIATA { get; set; }
        /// <summary>
        /// 機型代碼 ex: AT7
        /// </summary>
        public string airPlaneType { get; set; }
        /// <summary>
        /// 使用機坪 ex: 12
        /// </summary>
        public string Bay { get; set; }
        /// <summary>
        /// 航機狀態 代碼說明：
        /// <para>1：準時On Time </para> 
        /// <para>2：報到Check In </para> 
        /// <para>3：登機Boarding </para> 
        /// <para>4：離站Departed </para> 
        /// <para>5：延誤登機 Late Boarding </para> 
        /// <para>6：延誤Delayed </para>
        /// <para>7：取消Cancelled </para>
        /// </summary>
        public string statusdep { get; set; }
        /// <summary>
        /// 狀態原因 代碼說明：
        /// <para>1：時間異動</para>
        /// <para>2：天氣影響</para>
        /// <para>3：地面作業</para>
        /// <para>4：來機晚到</para>
        /// <para>5：流量管制</para>
        /// <para>6：班機調度</para>
        /// <para>7：航機檢修</para>
        /// <para>8：航班退關</para>
        /// <para>9：延至明日</para>
        /// <para>10：前日航班</para>
        /// <para>11：機場關閉</para>
        /// </summary>
        public string notedep { get; set; }
        /// <summary>
        /// 航機載客人數 ex: 50
        /// </summary>
        public string Passanger { get; set; }
        /// <summary>
        /// 航機載客未滿2歲人數ex: 1
        /// </summary>
        public string Infant { get; set; }
        public string transit { get; set; }
        public string diplomat { get; set; }
        public string other { get; set; }
        public string othernote { get; set; }
        /// <summary>
        /// 航機編號 ex: B16859
        /// </summary>
        public string Reg { get; set; }
        /// <summary>
        /// 航班屬性 代碼說明：
        /// <para>PAX(DOM_SCHE、FOR_SCHE)：客機</para>
        /// <para>EXT(DOM_EXTRA、FOR_EXTR)：加班機</para>
        /// <para>PAC：客機載貨</para>
        /// <para>CTR(DOM_BUSS、FOR_SCHE)：包機</para>
        /// <para>CGO：貨機 </para>
        /// <para>EMS：醫療後送 </para>
        /// <para>FYC(DOM_OTHER 、FOR_OTHER)：放空調度</para>
        /// <para>TGO：觸地離場</para>
        /// <para>TEC：技降飛行</para>
        /// <para>TRN：訓練飛行</para>
        /// <para>FCF：飛航測試</para>
        /// <para>FYM：放空修護</para>
        /// <para>LAP：低空飛過</para>
        /// <para>PHP：空照</para>
        /// <para>QRF：回航降落</para>
        /// <para>SOS：醫療專機</para>
        /// <para>SAR：搜救飛行</para>
        /// <para>TRF：過境加油</para>
        /// <para>TST：試飛</para>
        /// </summary>
        public string F_TYPE { get; set; }
        public string Seat { get; set; }
        public string luggage { get; set; }
        public string cargo { get; set; }
        public string mail { get; set; }
    }
}
