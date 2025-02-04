using Dummy_Web_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dummy_Web_API.Controllers
{
    public class _RetrieveEntityController : ApiController
    {
        public RetrieveEntityResponse Post(RetrieveEntityRequest entityModel)
        {
            RetrieveEntityResponse em = new RetrieveEntityResponse();
            RetrieveEntity re = new RetrieveEntity();

            if (entityModel.RetrieveEntityRequestType.RetrieveEntityDetail.EntityNo == "AB1234567")
            {
                re.EntityNo = "AB1234567";
                re.EntityName = "ABC LLP";
                re.Agmdate = "2006-09-23";
                re.AgmdueDate = "2006-09-23";
                re.AgmreminderDate = "2006-09-23";
                re.Ardate = "2006-09-23";
                re.ArdueDate = "2006-09-23";
                re.FinancialYearEnd = "2006-09-23";
                re.Status = "0";
                re.StatusDate = "2006-09-23";
                re.AddressType = "S";
                re.PostalCode = "47600";
                re.BlockNo = "13-A";
                re.StreetName = "Jalan 3A";
                re.FloorNo = "2";
                re.UnitNo = "105";
                re.BuildingName = "Exchange 106";
                re.Address1 = "Jalan XXX";
                re.Address2 = "Avenue YYY";
            }
            else if (entityModel.RetrieveEntityRequestType.RetrieveEntityDetail.EntityNo == "BAC123456")
            {
                re.EntityNo = "BAC123456";
                re.EntityName = "AC LLP";
                re.Agmdate = "2022-09-23";
                re.AgmdueDate = "2022-09-23";
                re.AgmreminderDate = "2022-09-23";
                re.Ardate = "2022-09-23";
                re.ArdueDate = "2022-09-23";
                re.FinancialYearEnd = "2022-09-23";
                re.Status = "0";
                re.StatusDate = "2022-09-23";
                re.AddressType = "S";
                re.PostalCode = "58000";
                re.BlockNo = "13-B";
                re.StreetName = "Jalan Alor";
                re.FloorNo = "10";
                re.UnitNo = "106";
                re.BuildingName = "PLV 106";
                re.Address1 = "Jalan YYY";
                re.Address2 = "Avenue XXX";
            }
            else if (entityModel.RetrieveEntityRequestType.RetrieveEntityDetail.EntityNo == "DAD123456")
            {
                re.EntityNo = "DAD123456";
                re.EntityName = "AD LLP";
                re.Agmdate = "2023-09-23";
                re.AgmdueDate = "2023-09-23";
                re.AgmreminderDate = "2023-09-23";
                re.Ardate = "2023-09-23";
                re.ArdueDate = "2023-09-23";
                re.FinancialYearEnd = "2023-09-23";
                re.Status = "0";
                re.StatusDate = "2023-09-23";
                re.AddressType = "S";
                re.PostalCode = "47600";
                re.BlockNo = "13-A";
                re.StreetName = "Jalan 3A";
                re.FloorNo = "2";
                re.UnitNo = "105";
                re.BuildingName = "Exchange 106";
                re.Address1 = "Jalan XXX";
                re.Address2 = "Avenue YYY";
            }
            else
            {
                re.EntityNo = "";
                re.EntityName = "";
                re.Agmdate = "";
                re.AgmdueDate = "";
                re.AgmreminderDate = "";
                re.Ardate = "";
                re.ArdueDate = "";
                re.FinancialYearEnd = "";
                re.Status = "";
                re.StatusDate = ""; re.AddressType = "S";
                re.PostalCode = "";
                re.BlockNo = "";
                re.StreetName = "";
                re.FloorNo = "";
                re.UnitNo = "";
                re.BuildingName = "";
                re.Address1 = "";
                re.Address2 = "";
            }

            em.RetrieveEntity = re;

            return em;
        }
    }
}
