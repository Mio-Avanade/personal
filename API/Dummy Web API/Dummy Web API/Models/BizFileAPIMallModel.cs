using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

namespace Dummy_Web_API.Models
{
    public class BizFileAPIMallModel
    {
        [JsonPropertyName("entities")]
        public Entity[] Entities { get; set; }
    }

    public class Entity
    {
        [JsonPropertyName("uen")]
        public string Uen { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("companyType")]
        public string CompanyType { get; set; }

        [JsonPropertyName("shareholders")]
        public Shareholders Shareholders { get; set; }
    }

    public class Shareholders
    {
        [JsonPropertyName("grouping")]
        public Grouping[] Grouping { get; set; }
    }

    public class Grouping
    {
        [JsonPropertyName("shareGroup")]
        public string ShareGroup { get; set; }

        [JsonPropertyName("shareholders")]
        public Shareholder[] Shareholders { get; set; }

        [JsonPropertyName("shareSubGroups")]
        public ShareSubGroup[] ShareSubGroups { get; set; }
    }

    public class ShareSubGroup
    {
        [JsonPropertyName("shareType")]
        public string ShareType { get; set; }

        [JsonPropertyName("shareAllotted")]
        public long ShareAllotted { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("creationDate")]
        public DateTimeOffset CreationDate { get; set; }

        [JsonPropertyName("cessationDate")]
        public DateTimeOffset? CessationDate { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }
    }

    public class Shareholder
    {
        [JsonPropertyName("shareholderId")]
        public string ShareholderId { get; set; }

        [JsonPropertyName("shareholderName")]
        public string ShareholderName { get; set; }
    }
}