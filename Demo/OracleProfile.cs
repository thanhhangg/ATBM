using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Demo
{
    public class OracleProfile
    {
        [JsonPropertyName("MANV")]
        public int MANV { get; set; }

        [JsonPropertyName("TENNV")]
        public string TENNV { get; set; }

        [JsonPropertyName("PHAI")]
        public string PHAI { get; set; }

        [JsonPropertyName("NGAYSINH")]
        public DateTime NGAYSINH { get; set; }

        [JsonPropertyName("DIACHI")]
        public string DIACHI { get; set; }

        [JsonPropertyName("SODT")]
        public string SODT { get; set; }

        [JsonPropertyName("LUONG")]
        public int LUONG { get; set; }

        [JsonPropertyName("PHUCAP")]
        public int PHUCAP { get; set; }

        [JsonPropertyName("VAITRO")]
        public string VAITRO { get; set; }

        [JsonPropertyName("MANQL")]
        public int? MANQL { get; set; }

        [JsonPropertyName("PHG")]
        public int PHG { get; set; }

        [JsonPropertyName("MADA")]
        public int? MADA { get; set; }

        [JsonPropertyName("THOIGIAN")]
        public DateTime? THOIGIAN { get; set; }

    }
}
