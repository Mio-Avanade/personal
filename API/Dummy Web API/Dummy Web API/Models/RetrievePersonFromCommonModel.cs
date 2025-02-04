using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dummy_Web_API.Models
{
    public class RetrieveIndividualRecipientResponse
    {
        [JsonProperty("useruuId")]
        public string useruuId { get; set; }

        [JsonProperty("spuuid")]
        public string spuuid { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("namePinyin")]
        public string namePinyin { get; set; }

        [JsonProperty("nameMarried")]
        public string nameMarried { get; set; }

        [JsonProperty("nameAlias")]
        public string nameAlias { get; set; }

        [JsonProperty("namePinyinAlias")]
        public string namePinyinAlias { get; set; }

        [JsonProperty("birthDate")]
        public string birthDate { get; set; }

        [JsonProperty("idType")]
        public string idType { get; set; }

        [JsonProperty("uin")]
        public string uin { get; set; }

        [JsonProperty("nationality")]
        public string nationality { get; set; }

        [JsonProperty("addressType")]
        public string addressType { get; set; }

        [JsonProperty("postalCode")]
        public string postalCode { get; set; }

        [JsonProperty("blockNo")]
        public string blockNo { get; set; }

        [JsonProperty("levelNo")]
        public string levelNo { get; set; }

        [JsonProperty("unitNo")]
        public string unitNo { get; set; }

        [JsonProperty("streetName")]
        public string streetName { get; set; }

        [JsonProperty("buildingName")]
        public string buildingName { get; set; }

        [JsonProperty("foreignAddr1")]
        public string foreignAddr1 { get; set; }

        [JsonProperty("foreignAddr2")]
        public string foreignAddr2 { get; set; }

        [JsonProperty("resiAddressSource")]
        public string resiAddressSource { get; set; }

        [JsonProperty("createdBy")]
        public string createdBy { get; set; }

        [JsonProperty("createdDate")]
        public DateTime createdDate { get; set; }

        [JsonProperty("updatedDate")]
        public DateTime updatedDate { get; set; }

        [JsonProperty("updatedBy")]
        public string updatedBy { get; set; }

        [JsonProperty("isDeleted")]
        public bool isDeleted { get; set; }

        [JsonProperty("deathFlag")]
        public bool deathFlag { get; set; }

        [JsonProperty("deathFlagSource")]
        public string deathFlagSource { get; set; }

        [JsonProperty("deathDate")]
        public string deathDate { get; set; }

        [JsonProperty("addressEffectiveDate")]
        public string addressEffectiveDate { get; set; }

        [JsonProperty("idEffectiveDate")]
        public string idEffectiveDate { get; set; }

        [JsonProperty("nationalityEffectiveDate")]
        public string nationalityEffectiveDate { get; set; }

        [JsonProperty("nameEffectiveDate")]
        public string nameEffectiveDate { get; set; }

        [JsonProperty("oldId")]
        public string oldId { get; set; }

        [JsonProperty("status")]
        public string status { get; set; }

        [JsonProperty("status_code")]
        public string status_code { get; set; }

        [JsonProperty("status_code_value")]
        public string status_code_value { get; set; }
    }
}