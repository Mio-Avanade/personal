using Dummy_Web_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dummy_Web_API.Controllers
{
    public class RetrievePersonFromCommonController : ApiController
    {
        public RetrieveIndividualRecipientResponse Get(string uin)
        {
            RetrieveIndividualRecipientResponse resp = new RetrieveIndividualRecipientResponse();

            if (uin == "S8959245C")
            {
                resp.name = "John Smith";
                resp.birthDate = "1975-10-01";
                resp.idType = "1";
                resp.nationality = "SG";
                resp.addressType = "A";
                resp.postalCode = "763555";
                resp.blockNo = "515A";
                resp.levelNo = "05";
                resp.unitNo = "119";
                resp.streetName = "Street 51";
                resp.buildingName = "River Walk";
                resp.foreignAddr1 = null;
                resp.foreignAddr2 = null;
                resp.resiAddressSource = "M";
            }
            else if (uin == "S8724761I")
            {
                resp.name = "John Smith 2";
                resp.birthDate = "1975-12-01";
                resp.idType = "1";
                resp.nationality = "SG";
                resp.addressType = "A";
                resp.postalCode = "763556";
                resp.blockNo = "515B";
                resp.levelNo = "06";
                resp.unitNo = "120";
                resp.streetName = "Street 52";
                resp.buildingName = "River Walk 2";
                resp.foreignAddr1 = null;
                resp.foreignAddr2 = null;
                resp.resiAddressSource = "M";
            }
            else if (uin == "T5821464C")
            {
                resp.name = "John Smith 3";
                resp.birthDate = "1978-12-01";
                resp.idType = "2";
                resp.nationality = "SG";
                resp.addressType = "A";
                resp.postalCode = "763666";
                resp.blockNo = "53B";
                resp.levelNo = "08";
                resp.unitNo = "168";
                resp.streetName = "Street 525";
                resp.buildingName = "River Walk 231";
                resp.foreignAddr1 = null;
                resp.foreignAddr2 = null;
                resp.resiAddressSource = "M";
            }
            else
            {
                resp.name = "";
                resp.birthDate = "";
                resp.idType = "";
                resp.nationality = "";
                resp.addressType = "";
                resp.postalCode = "";
                resp.blockNo = "";
                resp.levelNo = "";
                resp.unitNo = "";
                resp.streetName = "";
                resp.buildingName = "";
                resp.foreignAddr1 = null;
                resp.foreignAddr2 = null;
                resp.resiAddressSource = "";
            }

            return resp;
        }
    }
}
