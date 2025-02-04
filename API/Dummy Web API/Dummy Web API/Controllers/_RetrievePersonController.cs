using Dummy_Web_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dummy_Web_API.Controllers
{
    public class _RetrievePersonController : ApiController
    {
        public RetrievePersonResponse Post(RetrievePersonRequest personModel)
        {
            RetrievePersonResponse pm = new RetrievePersonResponse();
            RetrievePerson rp = new RetrievePerson();

            if (personModel.RetrievePersonRequestType.RetrievePersonDetail.PersonNRICFINPassport == "800950450")
            {
                rp.PersonNRIC = "800950450";
                rp.PersonName = "Jackson";
                rp.AddressType = "S";
                rp.PostalCode = "45000";
                rp.BlockNo = "3A";
                rp.StreetName = "Jalan 23B";
                rp.FloorNo = "10";
                rp.UnitNo = "101";
                rp.BuildingName = "Damansara Jaya";
                rp.ForeignAddress = "10, Jalan SS15";
                rp.Address2 = "xxxyy";
                rp.TelNoIntPrefix = "6";
                rp.EmailAddLocalPart = "xxxxx";
                rp.EmailAddrAtSign = "@";
                rp.EmailAddrDomain = "yyyy";
            }
            else if (personModel.RetrievePersonRequestType.RetrievePersonDetail.PersonNRICFINPassport == "800950451")
            {
                rp.PersonNRIC = "800950451";
                rp.PersonName = "Abril";
                rp.AddressType = "L";
                rp.PostalCode = "75000";
                rp.BlockNo = "10A";
                rp.StreetName = "Jalan 10B";
                rp.FloorNo = "20";
                rp.UnitNo = "501";
                rp.BuildingName = "Damansara Jaya";
                rp.ForeignAddress = "10B, Jalan SS15";
                rp.Address2 = "xxxyy";
                rp.TelNoIntPrefix = "7";
                rp.EmailAddLocalPart = "xxxxxyyy";
                rp.EmailAddrAtSign = "@";
                rp.EmailAddrDomain = "xxxxxyyyy";
            }
            else if (personModel.RetrievePersonRequestType.RetrievePersonDetail.PersonNRICFINPassport == "700950451")
            {
                rp.PersonNRIC = "700950451";
                rp.PersonName = "Jeremy";
                rp.AddressType = "S";
                rp.PostalCode = "45000";
                rp.BlockNo = "3A";
                rp.StreetName = "Jalan 23B";
                rp.FloorNo = "10";
                rp.UnitNo = "101";
                rp.BuildingName = "Damansara Jaya";
                rp.ForeignAddress = "10, Jalan SS15";
                rp.Address2 = "xxxyy";
                rp.TelNoIntPrefix = "6";
                rp.EmailAddLocalPart = "xxxxx";
                rp.EmailAddrAtSign = "@";
                rp.EmailAddrDomain = "yyyy";
            }
            else
            {
                rp.PersonNRIC = "";
                rp.PersonName = "";
                rp.AddressType = "";
                rp.PostalCode = "";
                rp.BlockNo = "";
                rp.StreetName = "";
                rp.FloorNo = "";
                rp.UnitNo = "";
                rp.BuildingName = "";
                rp.ForeignAddress = "";
                rp.Address2 = "";
                rp.TelNoIntPrefix = "";
                rp.EmailAddLocalPart = "";
                rp.EmailAddrAtSign = "";
                rp.EmailAddrDomain = "";
            }

            pm.RetrievePerson = new RetrievePerson[]
            {
                rp
            };

            return pm;
        }
    }
}
