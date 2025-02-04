using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Dummy_Web_API.Models
{
    public class PersonModel
    {
        public string personNRICFINPassport
        {
            get;
            set;
        }
        public string personNric
        {
            get;
            set;
        }

        public string personName
        {
            get;
            set;
        }
    }
    public class RetrievePersonRequest
    {
        [JsonPropertyName("soapHeaderType")]
        public RetrievePersonSoapHeaderType RetrievePersonSoapHeaderType { get; set; }

        [JsonPropertyName("retrievePersonRequestType")]
        public RetrievePersonRequestType RetrievePersonRequestType { get; set; }
    }

    public class RetrievePersonSoapHeaderType
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

    public class RetrievePersonRequestType
    {
        [JsonPropertyName("retrievePersonHeader")]
        public RetrievePersonHeader RetrievePersonHeader { get; set; }

        [JsonPropertyName("retrievePersonDetail")]
        public RetrievePersonDetail RetrievePersonDetail { get; set; }
    }

    public class RetrievePersonHeader
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

    public class RetrievePersonDetail
    {
        [JsonPropertyName("personName")]
        public string PersonName { get; set; }

        [JsonPropertyName("personNRICFINPassport")]
        public string PersonNRICFINPassport { get; set; }

        [JsonPropertyName("personUEN")]
        public string PersonUEN { get; set; }
    }

    public class RetrievePersonResponse
    {
        [JsonPropertyName("retrievePersonHeaderResponse")]
        public RetrievePersonHeaderResponse RetrievePersonHeaderResponse { get; set; }

        [JsonPropertyName("retrievePerson")]
        public RetrievePerson[] RetrievePerson { get; set; }
    }

    public class RetrievePersonHeaderResponse
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

        [JsonPropertyName("batchEndDate")]
        public string BatchEndDate { get; set; }
    }

    public class RetrievePerson
    {
        [JsonPropertyName("personNRIC")]
        public string PersonNRIC { get; set; }

        [JsonPropertyName("personName")]
        public string PersonName { get; set; }

        [JsonPropertyName("nationality")]
        public string Nationality { get; set; }

        [JsonPropertyName("dateOfBirth")]
        public string DateOfBirth { get; set; }

        [JsonPropertyName("addressSource")]
        public string AddressSource { get; set; }

        [JsonPropertyName("dateAddressChanged")]
        public string DateAddressChanged { get; set; }

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

        [JsonPropertyName("foreignAddress")]
        public string ForeignAddress { get; set; }

        [JsonPropertyName("address2")]
        public string Address2 { get; set; }

        [JsonPropertyName("telNoIntPrefix")]
        public string TelNoIntPrefix { get; set; }

        [JsonPropertyName("emailAddLocalPart")]
        public string EmailAddLocalPart { get; set; }

        [JsonPropertyName("emailAddrAtSign")]
        public string EmailAddrAtSign { get; set; }

        [JsonPropertyName("emailAddrDomain")]
        public string EmailAddrDomain { get; set; }

        [JsonPropertyName("personAddressHistory")]
        public PersonAddressHistory[] PersonAddressHistory { get; set; }

        [JsonPropertyName("personBusinessHistory")]
        public PersonBusinessHistory[] PersonBusinessHistory { get; set; }
    }

    public class PersonAddressHistory
    {
        [JsonPropertyName("dateAddressChanged")]
        public string DateAddressChanged { get; set; }

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

        [JsonPropertyName("foreignAddress")]
        public string ForeignAddress { get; set; }

        [JsonPropertyName("address2")]
        public string Address2 { get; set; }
    }

    public class PersonBusinessHistory
    {
        [JsonPropertyName("entityNo")]
        public string EntityNo { get; set; }

        [JsonPropertyName("entityType")]
        public string EntityType { get; set; }

        [JsonPropertyName("entityName")]
        public string EntityName { get; set; }

        [JsonPropertyName("positionHeld")]
        public string PositionHeld { get; set; }

        [JsonPropertyName("appointedDate")]
        public string AppointedDate { get; set; }

        [JsonPropertyName("cessationDate")]
        public string CessationDate { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("postalCode")]
        public string PostalCode { get; set; }

        [JsonPropertyName("blockNo")]
        public string BlockNo { get; set; }

        [JsonPropertyName("buildingName")]
        public string BuildingName { get; set; }

        [JsonPropertyName("streetName")]
        public string StreetName { get; set; }

        [JsonPropertyName("floorNo")]
        public string FloorNo { get; set; }

        [JsonPropertyName("unitNo")]
        public string UnitNo { get; set; }
    }
}