using API_ToHMI_Translate.Configuration;
using API_ToHMI_Translate.Modules;
using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using RestSharp.Authenticators.OAuth2;
using RestSharp.Serializers;
using Serilog;
using System;
using System.Collections.Generic;
using System.Threading;

namespace API_ToHMI_Translate.Methods
{
    public class APIMethod
    {
        private List<object> test = new List<object>()
        {
           new { DataType = "BasicFloat",
           Value = new
           {
               Value = "30",
               Quality = "9439544818968559873",
               QualityGood = true,
               Timestamp = "2023-02-08T03:36:22.397z"
           },
               OriginalObjectOrPropertyId = "123",
               ObjectId = "123",
               PropertyName = "Value",
               AttributeId = "123",
               ErrorCode = 0,
               IsArray = false
           }
        };
        /// <summary>
        /// 系統資訊
        /// </summary>
        public SystemSetting SystemSetting { get; set; }
        /// <summary>
        /// 跳脫時間
        /// </summary>
        private int time { get; set; } = 30000;
        /// <summary>
        /// 錯誤訊息
        /// </summary>
        public string Arr_ErrorStr { get; set; } = "NONE";
        /// <summary>
        /// 錯誤訊息
        /// </summary>
        public string Dep_ErrorStr { get; set; } = "NONE";
        /// <summary>
        /// 到站連線狀態
        /// </summary>
        public bool Arr_ClientFlag { get; set; } = false;
        /// <summary>
        /// 離站連線狀態
        /// </summary>
        public bool Dep_ClientFlag { get; set; } = false;
        /// <summary>
        /// API連結物件
        /// </summary>
        private RestClient clinet { get; set; }
        public string Token { get; set; }

        public DateTime TokenTime { get; set; }
        public APIMethod(SystemSetting setting)
        {
            SystemSetting = setting;
        }
        #region 機場API
        /// <summary>
        /// 到站API
        /// </summary>
        /// <returns></returns>
        public List<ArrData> Get_Arr()
        {
            try
            {
                List<ArrData> datas = null;
                var option = new RestClientOptions(SystemSetting.ArrAPI) { Timeout = time };
                clinet = new RestClient(option);
                var resquest = new RestRequest("", Method.Get);
                var response = clinet.ExecuteGetAsync<List<ArrData>>(resquest);
                response.Wait();
                try
                {
                    datas = JsonConvert.DeserializeObject<List<ArrData>>(response.Result.Content);
                }
                catch (Exception)
                {
                    string data = response.Result.Content.ToString().Remove(0, 1);
                    datas = JsonConvert.DeserializeObject<List<ArrData>>(data);
                }
                Arr_ClientFlag = true;
                Arr_ErrorStr = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                return datas;
            }
            catch (Exception ex)
            {

                Log.Error(ex, "到站API錯誤");
                Arr_ErrorStr = "無網路或伺服器未開啟!";
                Arr_ClientFlag = false;
                return null;
            }
        }
        /// <summary>
        /// 離站API
        /// </summary>
        /// <returns></returns>
        public List<DepData> Get_Dep()
        {
            try
            {
                List<DepData> datas = null;
                var option = new RestClientOptions(SystemSetting.DepAPI) { Timeout = time };
                clinet = new RestClient(option);
                var resquest = new RestRequest("", Method.Get);
                var response = clinet.ExecuteGetAsync<List<DepData>>(resquest);
                response.Wait();
                try
                {
                    datas = JsonConvert.DeserializeObject<List<DepData>>(response.Result.Content);
                }
                catch (Exception)
                {
                    string data = response.Result.Content.ToString().Remove(0, 1);
                    datas = JsonConvert.DeserializeObject<List<DepData>>(data);
                }
                Dep_ClientFlag = true;
                Dep_ErrorStr = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
                return datas;
            }
            catch (ThreadAbortException) { return null; }
            catch (Exception ex)
            {

                Log.Error(ex, "離站API錯誤");
                Dep_ErrorStr = "無網路或伺服器未開啟!";
                Dep_ClientFlag = false;
                return null;
            }
        }
        #endregion
        #region 西門子API
        /// <summary>
        /// 取得Token
        /// </summary>
        public string Checked_Token()
        {
            try
            {
                TimeSpan timeSpan = DateTime.Now.Subtract(TokenTime);
                if (timeSpan.TotalMinutes >= 5)
                {

                    var option = new RestClientOptions("https://192.168.0.251:443/WSI/api/token") { Timeout = time };
                    clinet = new RestClient(option);
                    var request = new RestRequest("", Method.Post);
                    request.AddHeader("Content-Type", "application/x-www-form-urlencoded");
                    request.AddParameter("grant_type", "password");
                    request.AddParameter("username", "defaultadmin");
                    request.AddParameter("password", "cc");
                    var response = clinet.ExecutePostAsync<TokenData>(request);
                    response.Wait();
                    TokenData value = JsonConvert.DeserializeObject<TokenData>(response.Result.Content);
                    TokenTime = DateTime.Now;
                    Token = value.access_token;
                    return Token;
                }
                else
                {
                    return Token;
                }
            }
            catch (Exception ex)
            {
                Log.Error(ex, "取得Token發生錯誤");
                return "";
            }
        }
        /// <summary>
        /// 取得到站預先開機時間
        /// </summary>
        /// <returns></returns>
        public Translate_ArrData_AT_On Get_Translate_ArrData_AT_On(string Token)
        {
            Translate_ArrData_AT_On data = null;
            try
            {
                var option = new RestClientOptions(SystemSetting.Translate_ArrAPI_AT_On) { Timeout = time };
                clinet = new RestClient(option);
                var request = new RestRequest("", Method.Get);
                request.AddHeader("Authorization", string.Format("Bearer {0}", Token));
                request.AddParameter("grant_type", "password");
                request.AddParameter("username", "defaultadmin");
                request.AddParameter("password", "cc");
                var response = clinet.ExecuteGetAsync<object>(request);
                response.Wait();
                var value = JsonConvert.DeserializeObject<List<Translate_ArrData_AT_On>>(response.Result.Content);
                data = value[0];
                //string buffer = JsonConvert.SerializeObject(test);
                //data = JsonConvert.DeserializeObject<List<Translate_ArrData_AT_On>>(buffer)[0];
            }
            catch (ThreadAbortException) { }
            catch (Exception ex)
            {
                Log.Error(ex, $"取得到站預先開機時間發生錯誤 Token :{Token}");
            }
            return data;
        }
        /// <summary>
        /// 取得到站延遲關機機時間
        /// </summary>
        /// <returns></returns>
        public Translate_ArrData_AT_Off Get_Translate_ArrData_AT_Off(string Token)
        {
            Translate_ArrData_AT_Off data = null;
            try
            {
                var option = new RestClientOptions(SystemSetting.Translate_ArrAPI_AT_Off) { Timeout = time };
                clinet = new RestClient(option);
                var request = new RestRequest("", Method.Get);
                request.AddHeader("Authorization", string.Format("Bearer {0}", Token));
                request.AddParameter("grant_type", "password");
                request.AddParameter("username", "defaultadmin");
                request.AddParameter("password", "cc");
                var response = clinet.ExecuteGetAsync<List<Translate_ArrData_AT_Off>>(request);
                response.Wait();
                var value = JsonConvert.DeserializeObject<List<Translate_ArrData_AT_Off>>(response.Result.Content);
                data = value[0];
                //string buffer = JsonConvert.SerializeObject(test);
                //data = JsonConvert.DeserializeObject<List<Translate_ArrData_AT_Off>>(buffer)[0];
            }
            catch (ThreadAbortException) { }
            catch (Exception ex)
            {
                Log.Error(ex, "取得到站延遲關機機時間發生錯誤");
            }
            return data;
        }
        /// <summary>
        /// 到站控制開關
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Post_Arr_AUH_CL(Arr_PostData data, string Token)
        {
            try
            {
                List<object> value = new List<object>();
                value.Add(data);
                string buffer = JsonConvert.SerializeObject(value);
                var option = new RestClientOptions(SystemSetting.Translate_ArrAPI_AHU_CL) { Timeout = time };
                clinet = new RestClient(option);
                var request = new RestRequest("", Method.Post);
                request.AddHeader("Authorization", string.Format("Bearer {0}", Token));
                request.AddBody(buffer, ContentType.Json);
                var response = clinet.ExecutePostAsync(request);
                response.Wait();
                if (response.Result.ErrorMessage == null)
                {
                    Log.Information($"到站控制開關寫入完畢");
                    return true;
                }
                else
                {
                    Log.Error($"到站控制開關失敗");
                    return false;
                }
            }
            catch (ThreadAbortException) { return false; }
            catch (Exception ex)
            {
                Log.Error(ex, $"到站控制開關失敗");
                return false;
            }
        }
        /// <summary>
        /// 到站字串傳送
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Post_Arr_STA(Arr_PostData data, string Token)
        {
            try
            {
                List<object> value = new List<object>();
                value.Add(data);
                string buffer = JsonConvert.SerializeObject(value);
                var option = new RestClientOptions(SystemSetting.Translate_ArrAPI_STA) { Timeout = time };
                clinet = new RestClient(option);
                var request = new RestRequest("", Method.Post);
                request.AddHeader("Authorization", string.Format("Bearer {0}", Token));
                request.AddBody(buffer, ContentType.Json);
                var response = clinet.ExecutePostAsync(request);
                response.Wait();
                if (response.Result.ErrorMessage == null)
                {
                    Log.Information($"{data.Value} 到站字串傳送寫入完畢");
                    return true;
                }
                else
                {
                    Log.Error($"{data.Value} 到站字串傳送失敗");
                    return false;
                }
            }
            catch (ThreadAbortException) { return false; }
            catch (Exception ex)
            {
                Log.Error(ex, $"{data.Value} 到站字串傳送失敗");
                return false;
            }
        }
        /// <summary>
        /// 取得離站預先開機時間
        /// </summary>
        /// <returns></returns>
        public Translate_DepData_AT_On Get_Translate_DepData_AT_On(string Token)
        {
            Translate_DepData_AT_On data = null;
            try
            {
                var option = new RestClientOptions(SystemSetting.Translate_DepAPI_AT_On) { Timeout = time };
                clinet = new RestClient(option);
                var request = new RestRequest("", Method.Get);
                request.AddHeader("Authorization", string.Format("Bearer {0}", Token));
                request.AddParameter("grant_type", "password");
                request.AddParameter("username", "defaultadmin");
                request.AddParameter("password", "cc");
                var response = clinet.ExecuteGetAsync<List<Translate_DepData_AT_On>>(request);
                response.Wait();
                var value = JsonConvert.DeserializeObject<List<Translate_DepData_AT_On>>(response.Result.Content);
                data = value[0];
                //string buffer = JsonConvert.SerializeObject(test);
                //data = JsonConvert.DeserializeObject<List<Translate_DepData_AT_On>>(buffer)[0];
            }
            catch (ThreadAbortException) { }
            catch (Exception ex)
            {
                Log.Error(ex, "取得離站預先開機時間發生錯誤");
            }
            return data;
        }
        /// <summary>
        /// 取得離站延遲關機機時間
        /// </summary>
        /// <returns></returns>
        public Translate_DepData_AT_Off Get_Translate_DepData_AT_Off(string Token)
        {
            Translate_DepData_AT_Off data = null;
            try
            {
                var option = new RestClientOptions(SystemSetting.Translate_DepAPI_AT_Off) { Timeout = time };
                clinet = new RestClient(option);
                var request = new RestRequest("", Method.Get);
                request.AddHeader("Authorization", string.Format("Bearer {0}", Token));
                request.AddParameter("grant_type", "password");
                request.AddParameter("username", "defaultadmin");
                request.AddParameter("password", "cc");
                var response = clinet.ExecuteGetAsync<List<Translate_DepData_AT_Off>>(request);
                response.Wait();
                var value = JsonConvert.DeserializeObject<List<Translate_DepData_AT_Off>>(response.Result.Content);
                data = value[0];
                //string buffer = JsonConvert.SerializeObject(test);
                //data = JsonConvert.DeserializeObject<List<Translate_DepData_AT_Off>>(buffer)[0];
            }
            catch (ThreadAbortException) { }
            catch (Exception ex)
            {
                Log.Error(ex, "取得離站延遲關機機時間發生錯誤");
            }
            return data;
        }
        /// <summary>
        /// 離站控制開關
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Post_Dep_AUH_CL(Dep_PostData data, string Token)
        {
            try
            {
                List<object> value = new List<object>();
                value.Add(data);
                string buffer = JsonConvert.SerializeObject(value);
                var option = new RestClientOptions(SystemSetting.Translate_DepAPI_AHU_CL) { Timeout = time };
                clinet = new RestClient(option);
                var request = new RestRequest("", Method.Post);
                request.AddHeader("Authorization", string.Format("Bearer {0}", Token));
                request.AddBody(buffer, ContentType.Json);
                var response = clinet.ExecutePostAsync(request);
                response.Wait();
                if (response.Result.ErrorMessage == null)
                {
                    Log.Information($"離站控制開關寫入完畢");
                    return true;
                }
                else
                {
                    Log.Error($"離站控制開關失敗");
                    return false;
                }
            }
            catch (ThreadAbortException) { return false; }
            catch (Exception ex)
            {
                Log.Error(ex, $"離站控制開關失敗");
                return false;
            }
        }
        /// <summary>
        /// 離站字串傳送
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public bool Post_Dep_STD(Dep_PostData data, string Token)
        {
            try
            {
                List<object> value = new List<object>();
                value.Add(data);
                string buffer = JsonConvert.SerializeObject(value);
                var option = new RestClientOptions(SystemSetting.Translate_DepAPI_STD) { Timeout = time };
                clinet = new RestClient(option);
                var request = new RestRequest("", Method.Post);
                request.AddHeader("Authorization", string.Format("Bearer {0}", Token));
                request.AddBody(buffer, ContentType.Json);
                var response = clinet.ExecutePostAsync(request);
                response.Wait();
                if (response.Result.ErrorMessage == null)
                {
                    Log.Information($"{data.Value} 離站字串傳送寫入完畢");
                    return true;
                }
                else
                {
                    Log.Error($"{data.Value} 離站字串傳送失敗");
                    return false;
                }
            }
            catch (ThreadAbortException) { return false; }
            catch (Exception ex)
            {
                Log.Error(ex, $"{data.Value} 離站字串傳送失敗");
                return false;
            }
        }
        #endregion
    }
}
