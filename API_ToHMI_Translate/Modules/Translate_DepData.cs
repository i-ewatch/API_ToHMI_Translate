using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_ToHMI_Translate.Modules
{
    public class Translate_DepData
    {
        /// <summary>
        /// 開始時間
        /// </summary>
        public DateTime StartTime { get; set; }
        /// <summary>
        /// 結束時間
        /// </summary>
        public DateTime EndTime { get; set; }
        /// <summary>
        /// 表定離站時間
        /// </summary>
        public string STD { get; set; }
        /// <summary>
        /// 運轉起停旗標
        /// </summary>
        public bool ActionFlag { get; set; } = false;
        /// <summary>
        /// 下過指令
        /// </summary>
        public bool WriteFlag { get; set; } = false;
        /// <summary>
        /// 時間區間完成旗標
        /// </summary>
        public bool CompleteFlag { get; set; } = false;
    }
    public class Translate_DepData_AT_On
    {
        public string DataType { get; set; }
        public Dep_ValueData Value { get; set; } = new Dep_ValueData();
        public string OriginalObjectOrPropertyId { get; set; }
        public string ObjectId { get; set; }
        public string PropertyName { get; set; }
        public string AttributeId { get; set; }
        public int ErrorCode { get; set; }
        public bool IsArray { get; set; }
    }
    public class Translate_DepData_AT_Off
    {
        public string DataType { get; set; }
        public Dep_ValueData Value { get; set; } = new Dep_ValueData();
        public string OriginalObjectOrPropertyId { get; set; }
        public string ObjectId { get; set; }
        public string PropertyName { get; set; }
        public string AttributeId { get; set; }
        public int ErrorCode { get; set; }
        public bool IsArray { get; set; }
    }
    public class Dep_ValueData
    {
        public string Value { get; set; }
        public string Quality { get; set; }
        public string QualityGood { get; set; }
        public string Timestamp { get; set; }
    }

    public class Dep_PostData
    {
        public string Name { get; set; }
        public string DataType { get; set; }
        public string Value { get; set; }
    }
}
