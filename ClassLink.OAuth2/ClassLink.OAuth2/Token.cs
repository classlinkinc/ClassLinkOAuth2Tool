using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ClassLink.OAuth2
{
    public class Token
    {
        public string access_token { get; set; }
        public string token_type { get; set; }
        public string response_code { get; set; }
    }
}
