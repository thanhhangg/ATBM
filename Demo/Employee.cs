using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Demo
{
    public class Employee
    {
        [JsonPropertyName("MANV")]
        public int MaNV { get; set; }

        [JsonPropertyName("TENNV")]
        public string TenNV { get; set; }

        [JsonPropertyName("PHAI")]
        public string Phai { get; set; }

        [JsonPropertyName("NGAYSINH")]
        public DateTime NgaySinh { get; set; }

        [JsonPropertyName("DIACHI")]
        public string DiaChi { get; set; }

        [JsonPropertyName("SODT")]
        public string SoDT { get; set; }

        [JsonPropertyName("LUONG")]
        public int Luong { get; set; }

        [JsonPropertyName("PHUCAP")]
        public int PhuCap { get; set; }

        [JsonPropertyName("VAITRO")]
        public string VaiTro { get; set; }

        [JsonPropertyName("MANQL")]
        public int? MaNQL { get; set; }

        [JsonPropertyName("PHG")]
        public int? PHG { get; set; }
    }
}
