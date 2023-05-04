using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Demo
{
    public class OracleUser
    {
        [JsonPropertyName("USERNAME")]
        public string Username { get; set; }

        [JsonPropertyName("USER_ID")]
        public int UserId { get; set; }

        [JsonPropertyName("CREATED")]
        public DateTime Created { get; set; }

        [JsonPropertyName("COMMON")]
        public string Common { get; set; }

        [JsonPropertyName("ORACLE_MAINTAINED")]
        public string OracleMaintained { get; set; }

        [JsonPropertyName("INHERITED")]
        public string Inherit { get; set; }

        [JsonPropertyName("DEFAULT_COLLATION")]
        public string DefaultCollation { get; set; }

        [JsonPropertyName("IMPLICIT")]
        public string Implicit { get; set; }

        [JsonPropertyName("ALL_SHARD")]
        public string AllShard { get; set; }

        [JsonPropertyName("EXTERNAL_SHARD")]
        public string ExternalShard { get; set; }
    }
}