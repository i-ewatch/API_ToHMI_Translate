namespace API_ToHMI_Translate.Modules
{
    public class ArrData
    {
        /// <summary>
        /// 航班日期 ex:2022-08-18
        /// </summary>
        public string FDATE { get; set; }

        /// <summary>
        /// 表訂起飛時間ex: 2022-08-18 17:20:00
        /// </summary>
        public string STD { get; set; }
        /// <summary>
        /// 表定到站時間ex: 2022-08-18 20:10:00
        /// </summary>
        public string STA { get; set; }
        /// <summary>
        /// 實際到站時間（跑道降落時間）ex: 2022-08-18 19:57:00
        /// </summary>
        public string ATA { get; set; }
        /// <summary>
        /// 航空公司通報到站（預定到站時間）時間ex: 2022-08-18 19:40:00
        /// </summary>
        public string arrtime { get; set; }
        /// <summary>
        /// 航空公司代碼(IATA) ex: B7
        /// </summary>
        public string airLineIATA { get; set; }
        /// <summary>
        /// 航班編號 ex: B78716
        /// </summary>
        public string airLineNum { get; set; }
        /// <summary>
        /// 共享航班編號 ex: BR8716, HO8716
        /// </summary>
        public string CodeShare { get; set; } = string.Empty;
        /// <summary>
        /// 目的機場代碼(IATA) ex:MZG
        /// </summary>
        public string DepartureAirportIATA { get; set; }
        /// <summary>
        /// 機型代碼 ex: AT7
        /// </summary>
        public string airPlaneType { get; set; }
        /// <summary>
        /// 使用機坪 ex: 17
        /// </summary>
        public string Bay { get; set; }
        /// <summary>
        /// 航機狀態 代碼說明：
        /// <para>1：準時On Time </para> 
        /// <para>2：抵達Arrived </para> 
        /// <para>3：延誤Delayed  </para> 
        /// <para>4：轉降Diverted </para> 
        /// <para>5：取消Cancelled </para> 
        /// </summary>
        public string statusarr { get; set; }
        /// <summary>
        /// 狀態原因 代碼說明：
        /// <para>1：天氣影響</para>
        /// <para>2：流量管制</para>
        /// <para>3：班機調度</para>
        /// <para>4：航機檢修</para>
        /// <para>5：班機返航</para>
        /// <para>6：轉降松山</para>
        /// <para>7：轉降臺南</para>
        /// <para>8：轉降臺中</para>
        /// <para>9：轉降澎湖</para>
        /// <para>10：轉降桃園</para>
        /// <para>11：轉降香港</para>
        /// <para>12：延至明日</para>
        /// <para>13：機場關閉</para>
        /// </summary>
        public string notearr { get; set; }
        /// <summary>
        /// 航機載客人數 ex: 184
        /// </summary>
        public string Passanger { get; set; }
        /// <summary>
        /// 航機載客未滿2歲人數ex: 0
        /// </summary>
        public string Infant { get; set; }
        public string transit { get; set; }
        public string diplomat { get; set; }
        public string other { get; set; }
        public string othernote { get; set; } = string.Empty;
        /// <summary>
        /// 航機編號 ex: B16211
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
