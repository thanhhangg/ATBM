using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Demo
{
    public class DBATabPriv
    {
        [JsonPropertyName("GRANTEE")]
        public string GRANTEE { get; set; }
        [JsonPropertyName("OWNER")]
        public string OWNER { get; set; }
        [JsonPropertyName("TABLE_NAME")]
        public string TABLE_NAME { get; set; }
        [JsonPropertyName("GRANTOR")]
        public string GRANTOR { get; set; }
        [JsonPropertyName("PRIVILEGE")]
        public string PRIVILEGE { get; set; }
        [JsonPropertyName("GRANTABLE")]
        public string GRANTABLE { get; set; }
        [JsonPropertyName("HIERARCHY")]
        public string HIERARCHY { get; set; }
        [JsonPropertyName("COMMON")]
        public string COMMON { get; set; }
        [JsonPropertyName("TYPE")]
        public string TYPE { get; set; }
        [JsonPropertyName("INHERITED")]
        public string INHERITED { get; set; }
    }
}
