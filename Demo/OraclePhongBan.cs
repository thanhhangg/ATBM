using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Demo
{
    public class OraclePhongBan
    {
        [JsonPropertyName("MAPB")]
        public int MAPB { get; set; }

        [JsonPropertyName("TENPB")]
        public string TENPB { get; set; }

        [JsonPropertyName("TRPHG")]
        public int TRPHG { get; set; }
    }
}
