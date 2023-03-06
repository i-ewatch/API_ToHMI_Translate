using System.Collections.Generic;

namespace API_ToHMI_Translate.Configuration
{
    public class SystemSetting
    {
        /// <summary>
        /// 航班離站路徑
        /// </summary>
        public string DepAPI { get; set; }
        /// <summary>
        /// 航班到站路徑
        /// </summary>
        public string ArrAPI { get; set; }
        /// <summary>
        /// 轉發航班離站路徑
        /// </summary>
        public string Translate_DepAPI_STD { get; set; }
        public string Translate_DepAPI_AHU_CL { get; set; }
        public string Translate_DepAPI_AT_On { get; set; }
        public string Translate_DepAPI_AT_Off { get; set; }
        /// <summary>
        /// 轉發航班到站路徑
        /// </summary>
        public string Translate_ArrAPI_STA { get; set; }
        public string Translate_ArrAPI_AHU_CL { get; set; }
        public string Translate_ArrAPI_AT_On { get; set; }
        public string Translate_ArrAPI_AT_Off { get; set; }
        /// <summary>
        /// 讀取API時間
        /// </summary>
        public List<string> Read_API_Time { get; set; } = new List<string>();
    }
}
