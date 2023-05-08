using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Demo
{
    public class OracleDeAn
    {
        [JsonPropertyName("MADA")]
        public int MADA { get; set; }

        [JsonPropertyName("TENDA")]
        public string TENDA { get; set; }

        [JsonPropertyName("NGAYBD")]
        public DateTime NGAYBD { get; set; }
        [JsonPropertyName("PHONG")]
        public int PHONG { get; set; }
    }
}
