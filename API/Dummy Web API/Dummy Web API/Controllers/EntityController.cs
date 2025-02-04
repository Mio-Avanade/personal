using Dummy_Web_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dummy_Web_API.Controllers
{
    public class EntityController : ApiController
    {
        public string Get()
        {
            return "Welcome To Web API";
        }
        //public RetrieveEntityResponse Post(RetrieveEntityRequest entityModel)
        //{
        //    RetrieveEntityResponse em = new RetrieveEntityResponse();
        //    RetrieveEntity re = new RetrieveEntity();

        //    if (entityModel.RetrieveEntityRequestType.RetrieveEntityDetail.EntityNo == "AB1234567")
        //    {
        //        re.EntityNo = "AB1234567";
        //        re.EntityName = "ABC LLP";
        //        re.Agmdate = "2006-09-23";
        //        re.AgmdueDate = "2006-09-23";
        //        re.AgmreminderDate = "2006-09-23";
        //        re.Ardate = "2006-09-23";
        //        re.ArdueDate = "2006-09-23";
        //        re.FinancialYearEnd = "2006-09-23";
        //        re.Status = "0";
        //        re.StatusDate = "2006-09-23";
        //    }
        //    else if (entityModel.RetrieveEntityRequestType.RetrieveEntityDetail.EntityNo == "BAC123456")
        //    {
        //        re.EntityNo = "BAC123456";
        //        re.EntityName = "AC LLP";
        //        re.Agmdate = "2022-09-23";
        //        re.AgmdueDate = "2022-09-23";
        //        re.AgmreminderDate = "2022-09-23";
        //        re.Ardate = "2022-09-23";
        //        re.ArdueDate = "2022-09-23";
        //        re.FinancialYearEnd = "2022-09-23";
        //        re.Status = "0";
        //        re.StatusDate = "2022-09-23";
        //    }
        //    else if (entityModel.RetrieveEntityRequestType.RetrieveEntityDetail.EntityNo == "DAD123456")
        //    {
        //        re.EntityNo = "DAD123456";
        //        re.EntityName = "AD LLP";
        //        re.Agmdate = "2023-09-23";
        //        re.AgmdueDate = "2023-09-23";
        //        re.AgmreminderDate = "2023-09-23";
        //        re.Ardate = "2023-09-23";
        //        re.ArdueDate = "2023-09-23";
        //        re.FinancialYearEnd = "2023-09-23";
        //        re.Status = "0";
        //        re.StatusDate = "2023-09-23";
        //    }
        //    else
        //    {
        //        re.EntityNo = "";
        //        re.EntityName = "";
        //        re.Agmdate = "";
        //        re.AgmdueDate = "";
        //        re.AgmreminderDate = "";
        //        re.Ardate = "";
        //        re.ArdueDate = "";
        //        re.FinancialYearEnd = "";
        //        re.Status = "";
        //        re.StatusDate = "";
        //    }

        //    em.RetrieveEntity = re;

        //    return em;
        //}

        public List<EntityModel> Post(EntityModel entityModel)
        {
            EntityModel em = new EntityModel();

            if (entityModel.entityNo == "AB1234567")
            {
                em.entityNo = "AB1234567";
                em.entityName = "ABC LLP";
                em.agmDate = "2006-09-23";
                em.agmDueDate = "2006-09-23";
                em.agmReminderDate = "2006-09-23";
                em.arDate = "2006-09-23";
                em.arDueDate = "2006-09-23";
                em.financialYearEnd = "2006-09-23";
                em.status = "0";
                em.statusDate = "2006-09-23";
            }
            else if (entityModel.entityNo == "BAC123456")
            {
                em.entityNo = "BAC123456";
                em.entityName = "AC LLP";
                em.agmDate = "2022-09-23";
                em.agmDueDate = "2022-09-23";
                em.agmReminderDate = "2022-09-23";
                em.arDate = "2022-09-23";
                em.arDueDate = "2022-09-23";
                em.financialYearEnd = "2022-09-23";
                em.status = "0";
                em.statusDate = "2022-09-23";
            }
            else if (entityModel.entityNo == "DAD123456")
            {
                em.entityNo = "DAD123456";
                em.entityName = "AD LLP";
                em.agmDate = "2023-09-23";
                em.agmDueDate = "2023-09-23";
                em.agmReminderDate = "2023-09-23";
                em.arDate = "2023-09-23";
                em.arDueDate = "2023-09-23";
                em.financialYearEnd = "2023-09-23";
                em.status = "0";
                em.statusDate = "2023-09-23";
            }
            else
            {
                em.entityNo = "";
                em.entityName = "";
                em.agmDate = "";
                em.agmDueDate = "";
                em.agmReminderDate = "";
                em.arDate = "";
                em.arDueDate = "";
                em.financialYearEnd = "";
                em.status = "";
                em.statusDate = "";
            }

            return new List<EntityModel> {
                em
            };
        }
    }
}