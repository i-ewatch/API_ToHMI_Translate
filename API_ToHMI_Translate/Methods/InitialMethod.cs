using API_ToHMI_Translate.Configuration;
using Newtonsoft.Json;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_ToHMI_Translate.Methods
{
    public class InitialMethod
    {
        /// <summary>
        /// 初始路徑
        /// </summary>
        private static string MyWorkPath { get; set; } = AppDomain.CurrentDomain.BaseDirectory;

        public static SystemSetting Sytem_Load()
        {
            SystemSetting setting = null;
            if (!Directory.Exists($"{MyWorkPath}\\stf"))
                Directory.CreateDirectory($"{MyWorkPath}\\stf");
            string SettingPath = $"{MyWorkPath}\\stf\\System.json";
            try
            {
                if (File.Exists(SettingPath))
                {
                    string json = File.ReadAllText(SettingPath, Encoding.UTF8);
                    setting = JsonConvert.DeserializeObject<SystemSetting>(json);
                }
                else
                {
                    List<string> read_API_Time = new List<string>
                    {
                        "00:00",
                        "12:00"
                    };
                    SystemSetting Setting = new SystemSetting
                    {
                        ArrAPI = "https://ccc.kia.gov.tw/fids/json/YTT/arr.php",
                        DepAPI = "https://ccc.kia.gov.tw/fids/json/YTT/dep.php",
                        Translate_ArrAPI_STA = "",
                        Translate_ArrAPI_AHU_CL="",
                        Translate_ArrAPI_AT_On = "",
                        Translate_ArrAPI_AT_Off = "",
                        Translate_DepAPI_STD = "",
                        Translate_DepAPI_AHU_CL = "",
                        Translate_DepAPI_AT_On = "",
                        Translate_DepAPI_AT_Off = "",
                        Read_API_Time = read_API_Time
                    };
                    setting = Setting;
                    string output = JsonConvert.SerializeObject(setting, Formatting.Indented, new JsonSerializerSettings());
                    File.WriteAllText(SettingPath, output);
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, " 系統資訊設定載入錯誤");
            }
            return setting;
        }
    }
}
