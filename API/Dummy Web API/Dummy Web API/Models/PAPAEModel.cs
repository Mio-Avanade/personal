using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

namespace Dummy_Web_API.Models
{
    public class PAPAEModel
    {
        public string paRegistrationNumber
        {
            get;
            set;
        }

        public string pmpCode
        {
            get;
            set;
        }

        public string paeUen
        {
            get;
            set;
        }

        public paDetails paDetails { get; set; }
        public paeDetails paeDetails { get; set; }
    }

    public class paDetails
    {
        public string identificationNo
        {
            get;
            set;
        }

        public string paName
        {
            get;
            set;
        }
    }

    public class paeDetails
    {
        public string pmpCode
        {
            get;
            set;
        }

        public string uen
        {
            get;
            set;
        }

        public string paEntityName
        {
            get;
            set;
        }
    }

    public class RetrievePAPAERequest
    {
        [JsonPropertyName("soapHeaderType")]
        public RetrievePAPAESoapHeaderType RetrievePAPAESoapHeaderType { get; set; }

        [JsonPropertyName("retrievePaPaeRequestType")]
        public RetrievePaPaeRequestType RetrievePaPaeRequestType { get; set; }
    }

    public class RetrievePaPaeRequestType
    {
        [JsonPropertyName("retrievePAPAEProfiles")]
        public RetrievePapaeProfiles RetrievePapaeProfiles { get; set; }
    }

    public class RetrievePapaeProfiles
    {
        [JsonPropertyName("paregistrationNumber")]
        public string ParegistrationNumber { get; set; }

        [JsonPropertyName("paapprovalDate")]
        public string PaapprovalDate { get; set; }

        [JsonPropertyName("paeuen")]
        public string Paeuen { get; set; }

        [JsonPropertyName("paentityName")]
        public string PaentityName { get; set; }

        [JsonPropertyName("registrationDate")]
        public string RegistrationDate { get; set; }

        [JsonPropertyName("paentityStatus")]
        public string PaentityStatus { get; set; }

        [JsonPropertyName("paentityStatusDate")]
        public string PaentityStatusDate { get; set; }

        [JsonPropertyName("piestatus")]
        public string Piestatus { get; set; }

        [JsonPropertyName("pmpcode")]
        public string Pmpcode { get; set; }
    }

    public class RetrievePAPAESoapHeaderType
    {
        [JsonPropertyName("interfaceName")]
        public string InterfaceName { get; set; }

        [JsonPropertyName("transactionID")]
        public string TransactionId { get; set; }

        [JsonPropertyName("transactionCode")]
        public string TransactionCode { get; set; }

        [JsonPropertyName("timestamp")]
        public string Timestamp { get; set; }
    }

    public class RetrievePAPAEResponse
    {
        [JsonPropertyName("retrievePAPAEProfiles")]
        public _RetrievePapaeProfiles RetrievePapaeProfiles { get; set; }
    }

    public class _RetrievePapaeProfiles
    {
        [JsonPropertyName("liveCompanies")]
        public LiveCompany[] LiveCompanies { get; set; }

        [JsonPropertyName("pastPMPDetails")]
        public PastPmpDetail[] PastPmpDetails { get; set; }

        [JsonPropertyName("papastPMPDetails")]
        public PapastPmpDetail[] PapastPmpDetails { get; set; }

        [JsonPropertyName("paedetails")]
        public Paedetail[] Paedetails { get; set; }

        [JsonPropertyName("padetails")]
        public Padetail[] Padetails { get; set; }
    }

    public class LiveCompany
    {
        [JsonPropertyName("companyUEN")]
        public string CompanyUen { get; set; }

        [JsonPropertyName("companyName")]
        public string CompanyName { get; set; }

        [JsonPropertyName("listedOnSGX")]
        public string ListedOnSgx { get; set; }

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

        [JsonPropertyName("appointmentDate")]
        public string AppointmentDate { get; set; }

        [JsonPropertyName("cessationDate")]
        public string CessationDate { get; set; }
    }

    public class Padetail
    {
        [JsonPropertyName("identificationNo")]
        public string IdentificationNo { get; set; }

        [JsonPropertyName("identificationType")]
        public string IdentificationType { get; set; }

        [JsonPropertyName("dateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("nationality")]
        public string Nationality { get; set; }

        [JsonPropertyName("remarks")]
        public string Remarks { get; set; }

        [JsonPropertyName("conditionsAttachedToApproval")]
        public string ConditionsAttachedToApproval { get; set; }

        [JsonPropertyName("restrictPAFromRenewal")]
        public string RestrictPaFromRenewal { get; set; }

        [JsonPropertyName("reasonsForRestrictingRenewal")]
        public string ReasonsForRestrictingRenewal { get; set; }

        [JsonPropertyName("liquidatorApprovalNumber")]
        public string LiquidatorApprovalNumber { get; set; }

        [JsonPropertyName("dateApprovedAsAnApprovedLiquidator")]
        public string DateApprovedAsAnApprovedLiquidator { get; set; }

        [JsonPropertyName("expiryDateOfLiquidatorsApproval")]
        public string ExpiryDateOfLiquidatorsApproval { get; set; }

        [JsonPropertyName("paregistrationNumber")]
        public string ParegistrationNumber { get; set; }

        [JsonPropertyName("paapprovalDate")]
        public string PaapprovalDate { get; set; }

        [JsonPropertyName("paregistrationStatus")]
        public string ParegistrationStatus { get; set; }

        [JsonPropertyName("pacertificateExpiryDate")]
        public string PacertificateExpiryDate { get; set; }

        [JsonPropertyName("paname")]
        public string Paname { get; set; }
    }

    public class Paedetail
    {
        [JsonPropertyName("uen")]
        public string Uen { get; set; }

        [JsonPropertyName("registrationDate")]
        public string RegistrationDate { get; set; }

        [JsonPropertyName("dateOfFirstAppointmentAsPIEAuditor")]
        public string DateOfFirstAppointmentAsPieAuditor { get; set; }

        [JsonPropertyName("constitutionType")]
        public string ConstitutionType { get; set; }

        [JsonPropertyName("constitutionDate")]
        public string ConstitutionDate { get; set; }

        [JsonPropertyName("remarks")]
        public string Remarks { get; set; }

        [JsonPropertyName("postalCode")]
        public string PostalCode { get; set; }

        [JsonPropertyName("blockNo")]
        public string BlockNo { get; set; }

        [JsonPropertyName("streetName")]
        public string StreetName { get; set; }

        [JsonPropertyName("levelNo")]
        public string LevelNo { get; set; }

        [JsonPropertyName("unitNo")]
        public string UnitNo { get; set; }

        [JsonPropertyName("buildingEstateName")]
        public string BuildingEstateName { get; set; }

        [JsonPropertyName("addressChangeDate")]
        public string AddressChangeDate { get; set; }

        [JsonPropertyName("telNoIntPrefix")]
        public string TelNoIntPrefix { get; set; }

        [JsonPropertyName("telNoCtryCode")]
        public string TelNoCtryCode { get; set; }

        [JsonPropertyName("telNo")]
        public string TelNo { get; set; }

        [JsonPropertyName("areaCode")]
        public string AreaCode { get; set; }

        [JsonPropertyName("primaryActivity")]
        public string PrimaryActivity { get; set; }

        [JsonPropertyName("primaryActivityDescription")]
        public string PrimaryActivityDescription { get; set; }

        [JsonPropertyName("secondarySSICDescription")]
        public string SecondarySsicDescription { get; set; }

        [JsonPropertyName("secondaryActivityDescription")]
        public string SecondaryActivityDescription { get; set; }

        [JsonPropertyName("personDetails")]
        public PersonDetail[] PersonDetails { get; set; }

        [JsonPropertyName("paentityStatusDate")]
        public string PaentityStatusDate { get; set; }

        [JsonPropertyName("paentityStatus")]
        public string PaentityStatus { get; set; }

        [JsonPropertyName("piestatus")]
        public string Piestatus { get; set; }

        [JsonPropertyName("paentityName")]
        public string PaentityName { get; set; }

        [JsonPropertyName("pmpcode")]
        public string Pmpcode { get; set; }

        [JsonPropertyName("paemailAddrLocalPart")]
        public string PaemailAddrLocalPart { get; set; }

        [JsonPropertyName("paemailAddrDomain")]
        public string PaemailAddrDomain { get; set; }

        [JsonPropertyName("paemailAddrAtSign")]
        public string PaemailAddrAtSign { get; set; }
    }

    public class PersonDetail
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("identificationType")]
        public string IdentificationType { get; set; }

        [JsonPropertyName("identificationNo")]
        public string IdentificationNo { get; set; }

        [JsonPropertyName("nationality")]
        public string Nationality { get; set; }

        [JsonPropertyName("dateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        [JsonPropertyName("contactInformation")]
        public ContactInformation[] ContactInformation { get; set; }

        [JsonPropertyName("residentialAddress")]
        public ResidentialAddress[] ResidentialAddress { get; set; }

        [JsonPropertyName("localAddress")]
        public LocalAddress[] LocalAddress { get; set; }

        [JsonPropertyName("alternateAddress")]
        public AlternateAddress[] AlternateAddress { get; set; }

        [JsonPropertyName("positionDetails")]
        public PositionDetail[] PositionDetails { get; set; }

        [JsonPropertyName("paregistrationNo")]
        public string ParegistrationNo { get; set; }
    }

    public class AlternateAddress
    {
        [JsonPropertyName("addressType")]
        public string AddressType { get; set; }

        [JsonPropertyName("preferredModeOfCommunicationForNotices")]
        public string PreferredModeOfCommunicationForNotices { get; set; }

        [JsonPropertyName("addressChangeDate")]
        public string AddressChangeDate { get; set; }
    }

    public class ContactInformation
    {
        [JsonPropertyName("telNoIntPrefix")]
        public string TelNoIntPrefix { get; set; }

        [JsonPropertyName("telNoCtryCode")]
        public string TelNoCtryCode { get; set; }

        [JsonPropertyName("telNo")]
        public string TelNo { get; set; }

        [JsonPropertyName("areaCode")]
        public string AreaCode { get; set; }

        [JsonPropertyName("paemailAddrLocalPart")]
        public string PaemailAddrLocalPart { get; set; }

        [JsonPropertyName("pamobileNoIntPrefix")]
        public string PamobileNoIntPrefix { get; set; }

        [JsonPropertyName("paemailAddrDomain")]
        public string PaemailAddrDomain { get; set; }

        [JsonPropertyName("paemailAddrAtSign")]
        public string PaemailAddrAtSign { get; set; }

        [JsonPropertyName("pamobileNoCtryCode")]
        public string PamobileNoCtryCode { get; set; }

        [JsonPropertyName("pamobileNoAreaCode")]
        public string PamobileNoAreaCode { get; set; }

        [JsonPropertyName("pamobileNo")]
        public string PamobileNo { get; set; }
    }

    public class LocalAddress
    {
        [JsonPropertyName("postalCode")]
        public string PostalCode { get; set; }

        [JsonPropertyName("blockNo")]
        public string BlockNo { get; set; }

        [JsonPropertyName("streetName")]
        public string StreetName { get; set; }

        [JsonPropertyName("level")]
        public string Level { get; set; }

        [JsonPropertyName("unit")]
        public string Unit { get; set; }

        [JsonPropertyName("buildingEstateName")]
        public string BuildingEstateName { get; set; }
    }

    public class PositionDetail
    {
        [JsonPropertyName("identificationNo")]
        public string IdentificationNo { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("positionHeld")]
        public string PositionHeld { get; set; }

        [JsonPropertyName("appointmentDate")]
        public string AppointmentDate { get; set; }

        [JsonPropertyName("dateChangeMade")]
        public string DateChangeMade { get; set; }

        [JsonPropertyName("paregistrationNo")]
        public string ParegistrationNo { get; set; }
    }

    public class ResidentialAddress
    {
        [JsonPropertyName("addressType")]
        public string AddressType { get; set; }
    }

    public class PapastPmpDetail
    {
        [JsonPropertyName("cycleNumber")]
        public string CycleNumber { get; set; }

        [JsonPropertyName("outcomeOfReview")]
        public string OutcomeOfReview { get; set; }

        [JsonPropertyName("initialNotificationLetterDate")]
        public string InitialNotificationLetterDate { get; set; }

        [JsonPropertyName("periodOfReview")]
        public string PeriodOfReview { get; set; }

        [JsonPropertyName("startDateOfSuspension")]
        public string StartDateOfSuspension { get; set; }

        [JsonPropertyName("endDateOfSuspension")]
        public string EndDateOfSuspension { get; set; }

        [JsonPropertyName("dateOfCancellation")]
        public string DateOfCancellation { get; set; }

        [JsonPropertyName("paymentAmount")]
        public string PaymentAmount { get; set; }

        [JsonPropertyName("paymentdate")]
        public string Paymentdate { get; set; }

        [JsonPropertyName("paocorderDate")]
        public string PaocorderDate { get; set; }

        [JsonPropertyName("paocmeetingDate")]
        public string PaocmeetingDate { get; set; }
    }

    public class PastPmpDetail
    {
        [JsonPropertyName("cycleNumber")]
        public string CycleNumber { get; set; }

        [JsonPropertyName("outcomeOfReview")]
        public string OutcomeOfReview { get; set; }

        [JsonPropertyName("initialNotificationLetterDate")]
        public string InitialNotificationLetterDate { get; set; }

        [JsonPropertyName("periodOfReviewStart")]
        public string PeriodOfReviewStart { get; set; }

        [JsonPropertyName("periodOfReviewEnd")]
        public string PeriodOfReviewEnd { get; set; }

        [JsonPropertyName("startDateOfSuspension")]
        public string StartDateOfSuspension { get; set; }

        [JsonPropertyName("endDateOfSuspension")]
        public string EndDateOfSuspension { get; set; }

        [JsonPropertyName("dateOfCancellation")]
        public string DateOfCancellation { get; set; }

        [JsonPropertyName("penaltyAmount")]
        public string PenaltyAmount { get; set; }

        [JsonPropertyName("invoiceDate")]
        public string InvoiceDate { get; set; }

        [JsonPropertyName("paymentDate")]
        public string PaymentDate { get; set; }

        [JsonPropertyName("paentityName")]
        public string PaentityName { get; set; }

        [JsonPropertyName("paocorderDate")]
        public string PaocorderDate { get; set; }

        [JsonPropertyName("paocmeetingDate")]
        public string PaocmeetingDate { get; set; }
    }
}