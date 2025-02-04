using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

namespace Dummy_Web_API.Models
{
    public class ScanResulRequest
    {
        [JsonPropertyName("s3ObjectKey")]
        public string S3ObjectKey { get; set; }

        [JsonPropertyName("br2Token")]
        public string Br2Token { get; set; }
    }

    public class ScanResultResponse
    {
        [JsonPropertyName("s3-object-key")]
        public string S3ObjectKey { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("uuid")]
        public string Uuid { get; set; }
    }
}