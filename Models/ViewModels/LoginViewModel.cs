using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Models.ViewModels
{
    public class LoginViewModel
    {
        [JsonProperty("error")]
        public string Error { get; set; }
        [JsonProperty("error_description")]
        public string ErrorDescription { get; set; }
        [JsonProperty("access_token")]
        public string AccessToken { get; set; }
        public string Functions { get; set; }
        public string FullName { get; set; }
        [JsonProperty("userName")]
        public string UserName { get; set; }

        public int OfficeId { get; set; }
        public string UserRoles{ get; set; }
    }
}
