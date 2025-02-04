using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

namespace Dummy_Web_API.Models
{
    public class EntityModel
    {
        public string entityNo
        {
            get;
            set;
        }

        public string entityName
        {
            get;
            set;
        }

        public string agmDate
        {
            get;
            set;
        }

        public string agmDueDate
        {
            get;
            set;
        }

        public string agmReminderDate
        {
            get;
            set;
        }

        public string arDate
        {
            get;
            set;
        }

        public string arDueDate
        {
            get;
            set;
        }

        public string financialYearEnd
        {
            get;
            set;
        }

        public string status
        {
            get;
            set;
        }

        public string statusDate
        {
            get;
            set;
        }
    }
    public class RetrieveEntityRequest
    {
        [JsonPropertyName("soapHeaderType")]
        public RetrieveEntitySoapHeaderType RetrieveEntitySoapHeaderType { get; set; }

        [JsonPropertyName("retrieveEntityRequestType")]
        public RetrieveEntityRequestType RetrieveEntityRequestType { get; set; }
    }

    public class RetrieveEntitySoapHeaderType
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

    public class RetrieveEntityRequestType
    {
        [JsonPropertyName("retrieveEntityHeader")]
        public RetrieveEntityHeader RetrieveEntityHeader { get; set; }

        [JsonPropertyName("retrieveEntityDetail")]
        public RetrieveEntityDetail RetrieveEntityDetail { get; set; }
    }

    public class RetrieveEntityHeader
    {
        [JsonPropertyName("userName")]
        public string UserName { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("interfaceName")]
        public string InterfaceName { get; set; }

        [JsonPropertyName("transactionID")]
        public string TransactionID { get; set; }

        [JsonPropertyName("transactionCode")]
        public string TransactionCode { get; set; }

        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }
    }

    public class RetrieveEntityDetail
    {
        [JsonPropertyName("entityName")]
        public string EntityName { get; set; }

        [JsonPropertyName("entityNo")]
        public string EntityNo { get; set; }
    }

    public partial class RetrieveEntityResponse
    {
        [JsonPropertyName("retrieveEntityHeaderResponse")]
        public RetrieveEntityHeaderResponse RetrieveEntityHeaderResponse { get; set; }

        [JsonPropertyName("retrieveEntity")]
        public RetrieveEntity RetrieveEntity { get; set; }
    }

    public partial class RetrieveEntity
    {
        [JsonPropertyName("entityNo")]
        public string EntityNo { get; set; }

        [JsonPropertyName("entityName")]
        public string EntityName { get; set; }

        [JsonPropertyName("formerlyKnownAs")]
        public string FormerlyKnownAs { get; set; }

        [JsonPropertyName("entityType")]
        public string EntityType { get; set; }

        [JsonPropertyName("incorporationDate")]
        public string IncorporationDate { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("statusDate")]
        public string StatusDate { get; set; }

        [JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonPropertyName("companyIndicator")]
        public string CompanyIndicator { get; set; }

        [JsonPropertyName("registeredAddressType")]
        public string RegisteredAddressType { get; set; }

        [JsonPropertyName("addressType")]
        public string AddressType { get; set; }

        [JsonPropertyName("postalCode")]
        public string PostalCode { get; set; }

        [JsonPropertyName("blockNo")]
        public string BlockNo { get; set; }

        [JsonPropertyName("streetName")]
        public string StreetName { get; set; }

        [JsonPropertyName("floorNo")]
        public string FloorNo { get; set; }

        [JsonPropertyName("unitNo")]
        public string UnitNo { get; set; }

        [JsonPropertyName("buildingName")]
        public string BuildingName { get; set; }

        [JsonPropertyName("address1")]
        public string Address1 { get; set; }

        [JsonPropertyName("address2")]
        public string Address2 { get; set; }

        [JsonPropertyName("financialYearEnd")]
        public string FinancialYearEnd { get; set; }

        [JsonPropertyName("nameOfAuditor")]
        public string NameOfAuditor { get; set; }

        [JsonPropertyName("nameOfPublicAccountingFirm")]
        public string NameOfPublicAccountingFirm { get; set; }

        [JsonPropertyName("publicAccountingFirmsUEN")]
        public string PublicAccountingFirmsUen { get; set; }

        [JsonPropertyName("personsDetails")]
        public PersonsDetail[] PersonsDetails { get; set; }

        [JsonPropertyName("authorisedCapital")]
        public AuthorisedCapital[] AuthorisedCapital { get; set; }

        [JsonPropertyName("issuedCapital")]
        public IssuedCapital[] IssuedCapital { get; set; }

        [JsonPropertyName("paidUpCapital")]
        public PaidUpCapital[] PaidUpCapital { get; set; }

        [JsonPropertyName("shareHolderDetails")]
        public ShareHolderDetail[] ShareHolderDetails { get; set; }

        [JsonPropertyName("lodgementInformation")]
        public LodgementInformation[] LodgementInformation { get; set; }

        [JsonPropertyName("previousCompanysAddressHistory")]
        public PreviousCompanysAddressHistory[] PreviousCompanysAddressHistory { get; set; }

        [JsonPropertyName("ssiccodeI")]
        public string SsiccodeI { get; set; }

        [JsonPropertyName("agmreminderDate")]
        public string AgmreminderDate { get; set; }

        [JsonPropertyName("agmdate")]
        public string Agmdate { get; set; }

        [JsonPropertyName("ssiccodeII")]
        public string SsiccodeIi { get; set; }

        [JsonPropertyName("ssiccodeIIDesc")]
        public string SsiccodeIiDesc { get; set; }

        [JsonPropertyName("agmdueDate")]
        public string AgmdueDate { get; set; }

        [JsonPropertyName("ardate")]
        public string Ardate { get; set; }

        [JsonPropertyName("ssiccodeIDesc")]
        public string SsiccodeIDesc { get; set; }

        [JsonPropertyName("ardueDate")]
        public string ArdueDate { get; set; }

        [JsonPropertyName("paregistrationNumber")]
        public string ParegistrationNumber { get; set; }
    }

    public partial class AuthorisedCapital
    {
        [JsonPropertyName("entityNo")]
        public string EntityNo { get; set; }

        [JsonPropertyName("actypeofShare")]
        public string ActypeofShare { get; set; }

        [JsonPropertyName("accurrency")]
        public string Accurrency { get; set; }
    }

    public partial class IssuedCapital
    {
        [JsonPropertyName("entityNo")]
        public string EntityNo { get; set; }

        [JsonPropertyName("iccurrency")]
        public string Iccurrency { get; set; }

        [JsonPropertyName("ictypeofShare")]
        public string IctypeofShare { get; set; }
    }

    public partial class LodgementInformation
    {
        [JsonPropertyName("transactionNo")]
        public string TransactionNo { get; set; }

        [JsonPropertyName("folioNo")]
        public string FolioNo { get; set; }

        [JsonPropertyName("transactionDescription")]
        public string TransactionDescription { get; set; }

        [JsonPropertyName("transactionLodgementDate")]
        public string TransactionLodgementDate { get; set; }

        [JsonPropertyName("lodgerName")]
        public string LodgerName { get; set; }

        [JsonPropertyName("lodgerUINUEN")]
        public string LodgerUinuen { get; set; }
    }

    public partial class PaidUpCapital
    {
        [JsonPropertyName("entityNo")]
        public string EntityNo { get; set; }

        [JsonPropertyName("pctypeofShare")]
        public string PctypeofShare { get; set; }

        [JsonPropertyName("pccurrency")]
        public string Pccurrency { get; set; }
    }

    public partial class PersonsDetail
    {
        [JsonPropertyName("personNRICFINPassport")]
        public string PersonNricfinPassport { get; set; }

        [JsonPropertyName("personName")]
        public string PersonName { get; set; }

        [JsonPropertyName("positionHeld")]
        public string PositionHeld { get; set; }

        [JsonPropertyName("appointedDate")]
        public string AppointedDate { get; set; }

        [JsonPropertyName("ceasedDate")]
        public string CeasedDate { get; set; }

        [JsonPropertyName("ceasedReason")]
        public string CeasedReason { get; set; }

        [JsonPropertyName("adverseRecord")]
        public string AdverseRecord { get; set; }

        [JsonPropertyName("antecedent")]
        public string Antecedent { get; set; }
    }

    public partial class PreviousCompanysAddressHistory
    {
        [JsonPropertyName("effectiveDate")]
        public string EffectiveDate { get; set; }

        [JsonPropertyName("chaddressType")]
        public string ChaddressType { get; set; }

        [JsonPropertyName("chstreetName")]
        public string ChstreetName { get; set; }

        [JsonPropertyName("chbuildingName")]
        public string ChbuildingName { get; set; }

        [JsonPropertyName("chblockNo")]
        public string ChblockNo { get; set; }

        [JsonPropertyName("chpostalCode")]
        public string ChpostalCode { get; set; }

        [JsonPropertyName("chunitNo")]
        public string ChunitNo { get; set; }

        [JsonPropertyName("chfloorNo")]
        public string ChfloorNo { get; set; }

        [JsonPropertyName("chforeignAddress1")]
        public string ChforeignAddress1 { get; set; }

        [JsonPropertyName("chforeignAddress2")]
        public string ChforeignAddress2 { get; set; }

        [JsonPropertyName("chaddressChangedBy")]
        public string ChaddressChangedBy { get; set; }
    }

    public partial class ShareHolderDetail
    {
        [JsonPropertyName("shpersonName")]
        public string ShpersonName { get; set; }

        [JsonPropertyName("shclassofShares")]
        public string ShclassofShares { get; set; }

        [JsonPropertyName("shcategory")]
        public string Shcategory { get; set; }

        [JsonPropertyName("shsharesHeld")]
        public string ShsharesHeld { get; set; }

        [JsonPropertyName("shcurrency")]
        public string Shcurrency { get; set; }

        [JsonPropertyName("shpersonNRICFINPassport")]
        public string ShpersonNricfinPassport { get; set; }
    }

    public partial class RetrieveEntityHeaderResponse
    {
        [JsonPropertyName("interfaceName")]
        public string InterfaceName { get; set; }

        [JsonPropertyName("transactionID")]
        public string TransactionId { get; set; }

        [JsonPropertyName("transactionCode")]
        public string TransactionCode { get; set; }

        [JsonPropertyName("userName")]
        public string UserName { get; set; }

        [JsonPropertyName("password")]
        public string Password { get; set; }

        [JsonPropertyName("batchEndDate")]
        public string BatchEndDate { get; set; }
    }
}