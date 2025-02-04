using Dummy_Web_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dummy_Web_API.Controllers
{
    public class _RetrievePAPAEController : ApiController
    {
        public RetrievePAPAEResponse Post(RetrievePAPAERequest pAPAEModel)
        {
            RetrievePAPAEResponse papaer = new RetrievePAPAEResponse();
            _RetrievePapaeProfiles papaep = new _RetrievePapaeProfiles();
            Padetail pad = new Padetail();
            Paedetail paed = new Paedetail();

            if (pAPAEModel.RetrievePaPaeRequestType.RetrievePapaeProfiles.ParegistrationNumber != null)
            {
                if (pAPAEModel.RetrievePaPaeRequestType.RetrievePapaeProfiles.ParegistrationNumber == "910110111221")
                {
                    pad.IdentificationNo = "800950450";
                    pad.Paname = "Johnson";
                    paed.Uen = "AAB123456";
                    paed.Pmpcode = "123456";
                    paed.PaentityName = "ABC LLP";
                }
                else if (pAPAEModel.RetrievePaPaeRequestType.RetrievePapaeProfiles.ParegistrationNumber == "910110111222")
                {
                    pad.IdentificationNo = "800950451";
                    pad.Paname = "Jacky";
                    paed.Uen = "CAB1234567";
                    paed.Pmpcode = "1234567";
                    paed.PaentityName = "ABD LLP";

                    
                }
                else if (pAPAEModel.RetrievePaPaeRequestType.RetrievePapaeProfiles.ParegistrationNumber == "910110111223")
                {
                    pad.IdentificationNo = "700950451";
                    pad.Paname = "Jeffrey";
                    paed.Uen = "DAB12345678";
                    paed.Pmpcode = "12345678";
                    paed.PaentityName = "ABE LLP";

                    
                }
                else
                {
                    pad.IdentificationNo = "";
                    pad.Paname = "";
                    paed.Uen = "";
                    paed.Pmpcode = "";
                    paed.PaentityName = "";

                    
                }
            }
            else if (pAPAEModel.RetrievePaPaeRequestType.RetrievePapaeProfiles.Pmpcode != null)
            {
                if (pAPAEModel.RetrievePaPaeRequestType.RetrievePapaeProfiles.Pmpcode == "123456")
                {
                    pad.IdentificationNo = "910110111221";
                    pad.Paname = "Johnson";
                    paed.Uen = "AAB123456";
                    paed.Pmpcode = "123456";
                    paed.PaentityName = "ABC LLP";

                    
                }
                else if (pAPAEModel.RetrievePaPaeRequestType.RetrievePapaeProfiles.Pmpcode == "1234567")
                {
                    pad.IdentificationNo = "910110111222";
                    pad.Paname = "Jacky";
                    paed.Uen = "CAB1234567";
                    paed.Pmpcode = "1234567";
                    paed.PaentityName = "ABD LLP";

                    
                }
                else if (pAPAEModel.RetrievePaPaeRequestType.RetrievePapaeProfiles.Pmpcode == "12345678")
                {
                    pad.IdentificationNo = "910110111223";
                    pad.Paname = "Jeffrey";
                    paed.Uen = "DAB12345678";
                    paed.Pmpcode = "12345678";
                    paed.PaentityName = "ABE LLP";

                    
                }
                else
                {
                    pad.IdentificationNo = "";
                    pad.Paname = "";
                    paed.Uen = "";
                    paed.Pmpcode = "";
                    paed.PaentityName = "";

                    
                }
            }
            else if (pAPAEModel.RetrievePaPaeRequestType.RetrievePapaeProfiles.Paeuen != null)
            {
                if (pAPAEModel.RetrievePaPaeRequestType.RetrievePapaeProfiles.Paeuen == "AAB123456")
                {
                    pad.IdentificationNo = "910110111221";
                    pad.Paname = "Johnson";
                    paed.Uen = "AAB123456";
                    paed.Pmpcode = "123456";
                    paed.PaentityName = "ABC LLP";

                    
                }
                else if (pAPAEModel.RetrievePaPaeRequestType.RetrievePapaeProfiles.Paeuen == "CAB1234567")
                {
                    pad.IdentificationNo = "910110111222";
                    pad.Paname = "Jacky";
                    paed.Uen = "CAB1234567";
                    paed.Pmpcode = "1234567";
                    paed.PaentityName = "ABD LLP";

                    
                }
                else if (pAPAEModel.RetrievePaPaeRequestType.RetrievePapaeProfiles.Paeuen == "DAB12345678")
                {
                    pad.IdentificationNo = "910110111223";
                    pad.Paname = "Jeffrey";
                    paed.Uen = "DAB12345678";
                    paed.Pmpcode = "12345678";
                    paed.PaentityName = "ABE LLP";

                    
                }
                else if (pAPAEModel.RetrievePaPaeRequestType.RetrievePapaeProfiles.Paeuen == "123456XYZ")
                {
                    pad.IdentificationNo = "910110111223";
                    pad.Paname = "Jeffrey";
                    paed.Uen = "123456XYZ";
                    paed.Pmpcode = "XX123456";
                    paed.PaentityName = "XAC LLP";


                }
                else
                {
                    pad.IdentificationNo = "";
                    pad.Paname = "";
                    paed.Uen = "";
                    paed.Pmpcode = "";
                    paed.PaentityName = "";

                    
                }
            }

            papaep.Padetails = new Padetail[]
            {
                pad
            };

            papaep.Paedetails = new Paedetail[]
            {
                paed
            };

            papaer.RetrievePapaeProfiles = papaep;

            return papaer;
        }
    }
}
