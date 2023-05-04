using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Demo
{
    public class OracleRole
    {
        [JsonPropertyName("USERNAME")]
        public string Username { get; set; }

        [JsonPropertyName("GRANTED_ROLE")]
        public string GrantedRole { get; set; }

        [JsonPropertyName("ADMIN_OPTION")]
        public string AdminOption { get; set; }

        [JsonPropertyName("DELEGATE_OPTION")]
        public string DelegateOption { get; set; }

        [JsonPropertyName("DEFAULT_ROLE")]
        public string DefaultRole { get; set; }

        [JsonPropertyName("OS_GRANTED")]
        public string OsGranted { get; set; }

        [JsonPropertyName("COMMON")]
        public string Common { get; set; }

        [JsonPropertyName("INHERITED")]
        public string Inherited { get; set; }
    }
}
