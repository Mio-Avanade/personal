using Dummy_Web_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dummy_Web_API.Controllers
{
    public class PAPAEController : ApiController
    {
        public string Get()
        {
            return "Welcome To Web API";
        }
        public List<PAPAEModel> Post(PAPAEModel pAPAEModel)
        {
            PAPAEModel ppm = new PAPAEModel();
            var pad = new paDetails();
            paeDetails paed = new paeDetails();

            if (pAPAEModel.paRegistrationNumber != "")
            {
                if (pAPAEModel.paRegistrationNumber == "910110111221")
                {
                    pad.identificationNo = "800950450";
                    pad.paName = "Johnson";
                    paed.uen = "AAB123456";
                    paed.pmpCode = "123456";
                    paed.paEntityName = "ABC LLP";

                    ppm.paDetails = pad;
                    ppm.paeDetails = paed;
                }
                else if (pAPAEModel.paRegistrationNumber == "910110111222")
                {
                    pad.identificationNo = "800950451";
                    pad.paName = "Jacky";
                    paed.uen = "CAB1234567";
                    paed.pmpCode = "1234567";
                    paed.paEntityName = "ABD LLP";

                    ppm.paDetails = pad;
                    ppm.paeDetails = paed;
                }
                else if (pAPAEModel.paRegistrationNumber == "910110111223")
                {
                    pad.identificationNo = "700950451";
                    pad.paName = "Jeffrey";
                    paed.uen = "DAB12345678";
                    paed.pmpCode = "12345678";
                    paed.paEntityName = "ABE LLP";

                    ppm.paDetails = pad;
                    ppm.paeDetails = paed;
                }
                else
                {
                    pad.identificationNo = "";
                    pad.paName = "";
                    paed.uen = "";
                    paed.pmpCode = "";
                    paed.paEntityName = "";

                    ppm.paDetails = pad;
                    ppm.paeDetails = paed;
                }
            }
            else if (pAPAEModel.pmpCode != "")
            {
                if (pAPAEModel.pmpCode == "123456")
                {
                    pad.identificationNo = "910110111221";
                    pad.paName = "Johnson";
                    paed.uen = "AAB123456";
                    paed.pmpCode = "123456";
                    paed.paEntityName = "ABC LLP";

                    ppm.paDetails = pad;
                    ppm.paeDetails = paed;
                }
                else if (pAPAEModel.pmpCode == "1234567")
                {
                    pad.identificationNo = "910110111222";
                    pad.paName = "Jacky";
                    paed.uen = "CAB1234567";
                    paed.pmpCode = "1234567";
                    paed.paEntityName = "ABD LLP";

                    ppm.paDetails = pad;
                    ppm.paeDetails = paed;
                }
                else if (pAPAEModel.pmpCode == "12345678")
                {
                    pad.identificationNo = "910110111223";
                    pad.paName = "Jeffrey";
                    paed.uen = "DAB12345678";
                    paed.pmpCode = "12345678";
                    paed.paEntityName = "ABE LLP";

                    ppm.paDetails = pad;
                    ppm.paeDetails = paed;
                }
                else
                {
                    pad.identificationNo = "";
                    pad.paName = "";
                    paed.uen = "";
                    paed.pmpCode = "";
                    paed.paEntityName = "";

                    ppm.paDetails = pad;
                    ppm.paeDetails = paed;
                }
            }
            else if (pAPAEModel.paeUen != "")
            {
                if (pAPAEModel.paeUen == "AAB123456")
                {
                    pad.identificationNo = "910110111221";
                    pad.paName = "Johnson";
                    paed.uen = "AAB123456";
                    paed.pmpCode = "123456";
                    paed.paEntityName = "ABC LLP";

                    ppm.paDetails = pad;
                    ppm.paeDetails = paed;
                }
                else if (pAPAEModel.paeUen == "CAB1234567")
                {
                    pad.identificationNo = "910110111222";
                    pad.paName = "Jacky";
                    paed.uen = "CAB1234567";
                    paed.pmpCode = "1234567";
                    paed.paEntityName = "ABD LLP";

                    ppm.paDetails = pad;
                    ppm.paeDetails = paed;
                }
                else if (pAPAEModel.paeUen == "DAB12345678")
                {
                    pad.identificationNo = "910110111223";
                    pad.paName = "Jeffrey";
                    paed.uen = "DAB12345678";
                    paed.pmpCode = "12345678";
                    paed.paEntityName = "ABE LLP";

                    ppm.paDetails = pad;
                    ppm.paeDetails = paed;
                }
                else if (pAPAEModel.paeUen == "123456XYZ")
                {
                    pad.identificationNo = "910110111223";
                    pad.paName = "Jeffrey";
                    paed.uen = "123456XYZ";
                    paed.pmpCode = "AX123456";
                    paed.paEntityName = "XXC LLP";

                    ppm.paDetails = pad;
                    ppm.paeDetails = paed;
                }
                else
                {
                    pad.identificationNo = "";
                    pad.paName = "";
                    paed.uen = "";
                    paed.pmpCode = "";
                    paed.paEntityName = "";

                    ppm.paDetails = pad;
                    ppm.paeDetails = paed;
                }
            }

            return new List<PAPAEModel> {
                ppm
            };
        }

        //public RetrievePAPAEResponse Post(RetrievePAPAERequest pAPAEModel)
        //{
        //    RetrievePAPAEResponse papaer = new RetrievePAPAEResponse();
        //    _RetrievePapaeProfiles papaep = new _RetrievePapaeProfiles();

        //    if (pAPAEModel.RetrievePaPaeRequestType.RetrievePapaeProfiles.ParegistrationNumber != "")
        //    {
        //        if (pAPAEModel.RetrievePaPaeRequestType.RetrievePapaeProfiles.ParegistrationNumber == "910110111221")
        //        {
        //            papaep.Padetails[0].IdentificationNo = "800950450";
        //            papaep.Padetails[0].Paname = "Johnson";
        //            papaep.Paedetails[0].Uen = "AAB123456";
        //            papaep.Paedetails[0].Pmpcode = "123456";
        //            papaep.Paedetails[0].PaentityName = "ABC LLP";

        //            papaer.RetrievePapaeProfiles = papaep;
        //        }
        //        else if (pAPAEModel.RetrievePaPaeRequestType.RetrievePapaeProfiles.ParegistrationNumber == "910110111222")
        //        {
        //            papaep.Padetails[0].IdentificationNo = "800950451";
        //            papaep.Padetails[0].Paname = "Jacky";
        //            papaep.Paedetails[0].Uen = "CAB1234567";
        //            papaep.Paedetails[0].Pmpcode = "1234567";
        //            papaep.Paedetails[0].PaentityName = "ABD LLP";

        //            papaer.RetrievePapaeProfiles = papaep;
        //        }
        //        else if (pAPAEModel.RetrievePaPaeRequestType.RetrievePapaeProfiles.ParegistrationNumber == "910110111223")
        //        {
        //            papaep.Padetails[0].IdentificationNo = "700950451";
        //            papaep.Padetails[0].Paname = "Jeffrey";
        //            papaep.Paedetails[0].Uen = "DAB12345678";
        //            papaep.Paedetails[0].Pmpcode = "12345678";
        //            papaep.Paedetails[0].PaentityName = "ABE LLP";

        //            papaer.RetrievePapaeProfiles = papaep;
        //        }
        //        else
        //        {
        //            papaep.Padetails[0].IdentificationNo = "";
        //            papaep.Padetails[0].Paname = "";
        //            papaep.Paedetails[0].Uen = "";
        //            papaep.Paedetails[0].Pmpcode = "";
        //            papaep.Paedetails[0].PaentityName = "";

        //            papaer.RetrievePapaeProfiles = papaep;
        //        }
        //    }
        //    else if (pAPAEModel.RetrievePaPaeRequestType.RetrievePapaeProfiles.Pmpcode != "")
        //    {
        //        if (pAPAEModel.RetrievePaPaeRequestType.RetrievePapaeProfiles.Pmpcode == "123456")
        //        {
        //            papaep.Padetails[0].IdentificationNo = "910110111221";
        //            papaep.Padetails[0].Paname = "Johnson";
        //            papaep.Paedetails[0].Uen = "AAB123456";
        //            papaep.Paedetails[0].Pmpcode = "123456";
        //            papaep.Paedetails[0].PaentityName = "ABC LLP";

        //            papaer.RetrievePapaeProfiles = papaep;
        //        }
        //        else if (pAPAEModel.RetrievePaPaeRequestType.RetrievePapaeProfiles.Pmpcode == "1234567")
        //        {
        //            papaep.Padetails[0].IdentificationNo = "910110111222";
        //            papaep.Padetails[0].Paname = "Jacky";
        //            papaep.Paedetails[0].Uen = "CAB1234567";
        //            papaep.Paedetails[0].Pmpcode = "1234567";
        //            papaep.Paedetails[0].PaentityName = "ABD LLP";

        //            papaer.RetrievePapaeProfiles = papaep;
        //        }
        //        else if (pAPAEModel.RetrievePaPaeRequestType.RetrievePapaeProfiles.Pmpcode == "12345678")
        //        {
        //            papaep.Padetails[0].IdentificationNo = "910110111223";
        //            papaep.Padetails[0].Paname = "Jeffrey";
        //            papaep.Paedetails[0].Uen = "DAB12345678";
        //            papaep.Paedetails[0].Pmpcode = "12345678";
        //            papaep.Paedetails[0].PaentityName = "ABE LLP";

        //            papaer.RetrievePapaeProfiles = papaep;
        //        }
        //        else
        //        {
        //            papaep.Padetails[0].IdentificationNo = "";
        //            papaep.Padetails[0].Paname = "";
        //            papaep.Paedetails[0].Uen = "";
        //            papaep.Paedetails[0].Pmpcode = "";
        //            papaep.Paedetails[0].PaentityName = "";

        //            papaer.RetrievePapaeProfiles = papaep;
        //        }
        //    }
        //    else if (pAPAEModel.RetrievePaPaeRequestType.RetrievePapaeProfiles.Paeuen != "")
        //    {
        //        if (pAPAEModel.RetrievePaPaeRequestType.RetrievePapaeProfiles.Paeuen == "AAB123456")
        //        {
        //            papaep.Padetails[0].IdentificationNo = "910110111221";
        //            papaep.Padetails[0].Paname = "Johnson";
        //            papaep.Paedetails[0].Uen = "AAB123456";
        //            papaep.Paedetails[0].Pmpcode = "123456";
        //            papaep.Paedetails[0].PaentityName = "ABC LLP";

        //            papaer.RetrievePapaeProfiles = papaep;
        //        }
        //        else if (pAPAEModel.RetrievePaPaeRequestType.RetrievePapaeProfiles.Paeuen == "CAB1234567")
        //        {
        //            papaep.Padetails[0].IdentificationNo = "910110111222";
        //            papaep.Padetails[0].Paname = "Jacky";
        //            papaep.Paedetails[0].Uen = "CAB1234567";
        //            papaep.Paedetails[0].Pmpcode = "1234567";
        //            papaep.Paedetails[0].PaentityName = "ABD LLP";

        //            papaer.RetrievePapaeProfiles = papaep;
        //        }
        //        else if (pAPAEModel.RetrievePaPaeRequestType.RetrievePapaeProfiles.Paeuen == "DAB12345678")
        //        {
        //            papaep.Padetails[0].IdentificationNo = "910110111223";
        //            papaep.Padetails[0].Paname = "Jeffrey";
        //            papaep.Paedetails[0].Uen = "DAB12345678";
        //            papaep.Paedetails[0].Pmpcode = "12345678";
        //            papaep.Paedetails[0].PaentityName = "ABE LLP";

        //            papaer.RetrievePapaeProfiles = papaep;
        //        }
        //        else
        //        {
        //            papaep.Padetails[0].IdentificationNo = "";
        //            papaep.Padetails[0].Paname = "";
        //            papaep.Paedetails[0].Uen = "";
        //            papaep.Paedetails[0].Pmpcode = "";
        //            papaep.Paedetails[0].PaentityName = "";

        //            papaer.RetrievePapaeProfiles = papaep;
        //        }
        //    }

        //    return papaer;
        //}
    }
}
