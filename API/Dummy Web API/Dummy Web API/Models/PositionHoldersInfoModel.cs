using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dummy_Web_API.Models
{
    public class PositionHoldersInfoModel
    {
    }

    public class RetrievePositionHoldersInfoRequest
    {
        [JsonProperty("status")]
        public string status { get; set; }

        [JsonProperty("result")]
        public Result result { get; set; }
    }

    public class Result
    {
        [JsonProperty("entityProfileId")]
        public string entityProfileId { get; set; }

        [JsonProperty("uen")]
        public string uen { get; set; }

        [JsonProperty("entityName")]
        public string entityName { get; set; }

        [JsonProperty("entityStatus")]
        public string entityStatus { get; set; }

        [JsonProperty("entityType")]
        public string entityType { get; set; }

        [JsonProperty("entitySubtype")]
        public string entitySubtype { get; set; }

        [JsonProperty("paeFlag")]
        public bool paeFlag { get; set; }

        [JsonProperty("professionalPartnershipFlag")]
        public bool professionalPartnershipFlag { get; set; }

        [JsonProperty("registrationDate")]
        public string registrationDate { get; set; }

        [JsonProperty("positionHolders")]
        public PositionHolder[] positionHolders { get; set; }
    }

    public class PositionHolder
    {
        [JsonProperty("officerCategory")]
        public string officerCategory { get; set; }

        [JsonProperty("officerProfileId")]
        public string officerProfileId { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("nameAlias")]
        public string nameAlias { get; set; }

        [JsonProperty("namePinyin")]
        public string namePinyin { get; set; }

        [JsonProperty("nameMarried")]
        public string nameMarried { get; set; }

        [JsonProperty("namePinyinAlias")]
        public string namePinyinAlias { get; set; }

        [JsonProperty("status")]
        public string status { get; set; }

        [JsonProperty("idNumber")]
        public string idNumber { get; set; }

        [JsonProperty("idType")]
        public string idType { get; set; }

        [JsonProperty("nationality")]
        public string nationality { get; set; }

        [JsonProperty("entityName")]
        public string entityName { get; set; }

        [JsonProperty("registrationNumber")]
        public string registrationNumber { get; set; }

        [JsonProperty("uen")]
        public string uen { get; set; }

        [JsonProperty("ulNo")]
        public string ulNo { get; set; }

        [JsonProperty("birthDate")]
        public string birthDate { get; set; }

        [JsonProperty("deathFlag")]
        public bool deathFlag { get; set; }

        [JsonProperty("deathDate")]
        public string deathDate { get; set; }

        [JsonProperty("email")]
        public string email { get; set; }

        [JsonProperty("emailVerifiedFlag")]
        public bool emailVerifiedFlag { get; set; }

        [JsonProperty("mobileNo")]
        public string mobileNo { get; set; }

        [JsonProperty("mobileNoCountryCode")]
        public string mobileNoCountryCode { get; set; }

        [JsonProperty("mobileNoAreaCode")]
        public string mobileNoAreaCode { get; set; }

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

        [JsonProperty("contactAddressType")]
        public string contactAddressType { get; set; }

        [JsonProperty("contactPostalCode")]
        public string contactPostalCode { get; set; }

        [JsonProperty("contactBlockNo")]
        public string contactBlockNo { get; set; }

        [JsonProperty("contactLevelNo")]
        public string contactLevelNo { get; set; }

        [JsonProperty("contactUnitNo")]
        public string contactUnitNo { get; set; }

        [JsonProperty("contactStreetName")]
        public string contactStreetName { get; set; }

        [JsonProperty("contactBuildingName")]
        public string contactBuildingName { get; set; }

        [JsonProperty("contactForeignAddr1")]
        public string contactForeignAddr1 { get; set; }

        [JsonProperty("contactForeignAddr2")]
        public string contactForeignAddr2 { get; set; }

        [JsonProperty("positionHeldList")]
        public PositionHeldList[] positionHeldList { get; set; }
    }

    public class PositionHeldList
    {
        [JsonProperty("positionHeld")]
        public string positionHeld { get; set; }

        [JsonProperty("status")]
        public string status { get; set; }

        [JsonProperty("entryDate")]
        public string entryDate { get; set; }

        [JsonProperty("ceasedDate")]
        public string ceasedDate { get; set; }

        [JsonProperty("ceasedReason")]
        public string ceasedReason { get; set; }

        [JsonProperty("ceasedOtherReason")]
        public string ceasedOtherReason { get; set; }

        [JsonProperty("ceasedReasonSubsection")]
        public string ceasedReasonSubsection { get; set; }

        [JsonProperty("alternateDirectors")]
        public AlternateDirector[] alternateDirectors { get; set; }

        [JsonProperty("beneficiary")]
        public Beneficiary beneficiary { get; set; }

        [JsonProperty("memberGuaranteedAmountList")]
        public MemberGuaranteedAmountList[] memberGuaranteedAmountList { get; set; }
    }

    public class AlternateDirector
    {
        [JsonProperty("alternateDirectorId")]
        public string alternateDirectorId { get; set; }

        [JsonProperty("directorPeopleProfileId")]
        public string directorPeopleProfileId { get; set; }

        [JsonProperty("directorPositionHeldId")]
        public string directorPositionHeldId { get; set; }

        [JsonProperty("altDirectorPositionHeldId")]
        public string altDirectorPositionHeldId { get; set; }

        [JsonProperty("effectiveStartDate")]
        public string effectiveStartDate { get; set; }

        [JsonProperty("effectiveEndDate")]
        public string effectiveEndDate { get; set; }
    }

    public class Beneficiary
    {
        [JsonProperty("beneficiaryId")]
        public string beneficiaryId { get; set; }

        [JsonProperty("nomineePositionHeldId")]
        public string nomineePositionHeldId { get; set; }

        [JsonProperty("category")]
        public string category { get; set; }

        [JsonProperty("nationality")]
        public string nationality { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

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

        [JsonProperty("natureOfBusiness")]
        public string natureOfBusiness { get; set; }

        [JsonProperty("beneficiaryDesc")]
        public string beneficiaryDesc { get; set; }
    }

    public class MemberGuaranteedAmountList
    {
        [JsonProperty("currency")]
        public string currency { get; set; }

        [JsonProperty("guaranteedAmount")]
        public long guaranteedAmount { get; set; }
    }
}