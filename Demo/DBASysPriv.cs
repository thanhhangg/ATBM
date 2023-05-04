using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Demo
{
    internal class DBASysPriv
    {
        [JsonPropertyName("GRANTEE")]
        public string GRANTEE { get; set; }

        [JsonPropertyName("PRIVILEGE")]
        public string PRIVILEGE { get; set; }

        [JsonPropertyName("ADMIN_OPTION")]
        public string ADMIN_OPTION { get; set; }

        [JsonPropertyName("COMMON")]
        public string COMMON { get; set; }

        [JsonPropertyName("INHERITED")]
        public string INHERITED { get; set; }

    }
}
