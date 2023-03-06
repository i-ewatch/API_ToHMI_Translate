using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API_ToHMI_Translate.Modules
{
    public class TokenData
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public int expires_in { get; set; }
        public string user_name { get; set; }
        public string user_descriptor { get; set; }
        public string user_profile { get; set; }
        public string flex_user_profile { get; set; }
        public string user_inactivity_timeout { get; set; }
    }
}
