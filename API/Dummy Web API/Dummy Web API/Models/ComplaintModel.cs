using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

namespace Dummy_Web_API.Models
{
    public class ComplaintModel
    {
        public string courtNo { get; set; }
        public string courtDate { get; set; }
        public string courtTime { get; set; }
        public string receiptNo { get; set; }
        public string complainantId { get; set; }
        public string complainantDescription { get; set; }
        public string offChargeDesc { get; set; }
        public string complaintDate { get; set; }
        public string classification { get; set; }
        public string offenceCode { get; set; }
        public string sectionCode { get; set; }
        public string subSectionCode { get; set; }
        public string offenceDate { get; set; }
        public int penaltyAmount { get; set; }
        public string rcbCaseNo { get; set; }
        public string outcome { get; set; }
        public string suspensionStartDate { get; set; }
        public string suspensionEndDate { get; set; }
        public DefendantDetailsModel defendantDetails { get; set; }
    }

    public class DefendantDetailsModel
    {
        public string defendantClass { get; set; }
        public string defendantId { get; set; }
        public string defendantName { get; set; }
        public string positionHeld { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string blockNo { get; set; }
        public string buildingName { get; set; }
        public string levelNo { get; set; }
        public string unitNo { get; set; }
        public string streetName { get; set; }
        public string postalCode { get; set; }
        public string replyDate { get; set; }
        public string outcome { get; set; }
        public string suspensionStartDate { get; set; }
        public string suspensionEndDate { get; set; }
    }

    public partial class UpdateComplaintRequest
    {
        [JsonPropertyName("soapHeaderType")]
        public SoapHeaderType SoapHeaderType { get; set; }

        [JsonPropertyName("penaltyAmount")]
        public int PenaltyAmount { get; set; }

        [JsonPropertyName("updateComplaintRequestType")]
        public UpdateComplaintRequestType UpdateComplaintRequestType { get; set; }
    }

    public partial class SoapHeaderType
    {
        [JsonPropertyName("userName")]
        public string UserName { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("interfaceName")]
        public string InterfaceName { get; set; }

        [JsonPropertyName("transactionID")]
        public string TransactionId { get; set; }

        [JsonPropertyName("transactionCode")]
        public string TransactionCode { get; set; }

        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }
    }

    public partial class UpdateComplaintRequestType
    {
        [JsonPropertyName("complaintGSD")]
        public ComplaintGsd ComplaintGsd { get; set; }
    }

    public partial class ComplaintGsd
    {
        [JsonPropertyName("complaintNo")]
        public string ComplaintNo { get; set; }

        [JsonPropertyName("courtNo")]
        public string CourtNo { get; set; }

        [JsonPropertyName("courtDate")]
        public string CourtDate { get; set; }

        [JsonPropertyName("courtTime")]
        public string CourtTime { get; set; }

        [JsonPropertyName("receiptNo")]
        public string ReceiptNo { get; set; }

        [JsonPropertyName("complainantId")]
        public string ComplainantId { get; set; }

        [JsonPropertyName("offenceChargeDesc")]
        public string OffenceChargeDesc { get; set; }

        [JsonPropertyName("statusOfComplaint")]
        public string StatusOfComplaint { get; set; }

        [JsonPropertyName("folderId")]
        public string FolderId { get; set; }

        [JsonPropertyName("complaintDate")]
        public string ComplaintDate { get; set; }

        [JsonPropertyName("classification")]
        public string Classification { get; set; }

        [JsonPropertyName("offenceCode")]
        public string OffenceCode { get; set; }

        [JsonPropertyName("sectionCode")]
        public string SectionCode { get; set; }

        [JsonPropertyName("subSectionCode")]
        public string SubSectionCode { get; set; }

        [JsonPropertyName("offenceDate")]
        public string OffenceDate { get; set; }

        [JsonPropertyName("defendantDetails")]
        public DefendantDetail[] DefendantDetails { get; set; }
    }

    public partial class DefendantDetail
    {
        [JsonPropertyName("defendantClass")]
        public string DefendantClass { get; set; }

        [JsonPropertyName("defendantId")]
        public string DefendantId { get; set; }

        [JsonPropertyName("defendantName")]
        public string DefendantName { get; set; }

        [JsonPropertyName("address1")]
        public string Address1 { get; set; }

        [JsonPropertyName("address2")]
        public string Address2 { get; set; }

        [JsonPropertyName("blockNo")]
        public string BlockNo { get; set; }

        [JsonPropertyName("telNoIntPrefix")]
        public string TelNoIntPrefix { get; set; }

        [JsonPropertyName("countryCode")]
        public string CountryCode { get; set; }

        [JsonPropertyName("contactNo")]
        public string ContactNo { get; set; }

        [JsonPropertyName("areaCode")]
        public string AreaCode { get; set; }

        [JsonPropertyName("buildingName")]
        public string BuildingName { get; set; }

        [JsonPropertyName("levelNo")]
        public string LevelNo { get; set; }

        [JsonPropertyName("unitNo")]
        public string UnitNo { get; set; }

        [JsonPropertyName("streetName")]
        public string StreetName { get; set; }

        [JsonPropertyName("postalCode")]
        public string PostalCode { get; set; }

        [JsonPropertyName("sendDate")]
        public string SendDate { get; set; }

        [JsonPropertyName("dueDate")]
        public string DueDate { get; set; }
    }

    public partial class UpdateComplaintResponse
    {
        [JsonPropertyName("complaintGSD")]
        public ComplaintGsd ComplaintGsd { get; set; }
    }

    public partial class ComplaintGsd
    {
        [JsonPropertyName("complaintGSD")]
        public string ComplaintGsdComplaintGsd { get; set; }
    }
}