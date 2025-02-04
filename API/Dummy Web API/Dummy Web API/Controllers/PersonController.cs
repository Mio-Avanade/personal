using Dummy_Web_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dummy_Web_API.Controllers
{
    public class PersonController : ApiController
    {
        public string Get()
        {
            return "Welcome To Web API";
        }
        //public RetrievePersonResponse Post(RetrievePersonRequest personModel)
        //{
        //    RetrievePersonResponse pm = new RetrievePersonResponse();
        //    RetrievePerson rp = new RetrievePerson();

        //    if (personModel.RetrievePersonRequestType.RetrievePersonDetail.PersonNRICFINPassport == "800950450")
        //    {
        //        rp.PersonNRIC = "800950450";
        //        rp.PersonName = "Jackson";
        //    }
        //    else if (personModel.RetrievePersonRequestType.RetrievePersonDetail.PersonNRICFINPassport == "800950451")
        //    {
        //        rp.PersonNRIC = "800950451";
        //        rp.PersonName = "Abril";
        //    }
        //    else if (personModel.RetrievePersonRequestType.RetrievePersonDetail.PersonNRICFINPassport == "700950451")
        //    {
        //        rp.PersonNRIC = "700950451";
        //        rp.PersonName = "Jeremy";
        //    }
        //    else
        //    {
        //        rp.PersonNRIC = "";
        //        rp.PersonName = "";
        //    }

        //    pm.RetrievePerson = new RetrievePerson[]
        //    {
        //        rp
        //    };

        //    return pm;
        //}

        public List<PersonModel> Post(PersonModel personModel)
        {
            PersonModel pm = new PersonModel();

            if (personModel.personNRICFINPassport == "800950450")
            {
                pm.personNric = "800950450";
                pm.personName = "Jackson";
            }
            else if (personModel.personNRICFINPassport == "800950451")
            {
                pm.personNric = "800950451";
                pm.personName = "Abril";
            }
            else if (personModel.personNRICFINPassport == "700950451")
            {
                pm.personNric = "700950451";
                pm.personName = "Jeremy";
            }
            else
            {
                pm.personNric = "";
                pm.personName = "";
            }

            return new List<PersonModel> {
                pm
            };
        }
    }
}
