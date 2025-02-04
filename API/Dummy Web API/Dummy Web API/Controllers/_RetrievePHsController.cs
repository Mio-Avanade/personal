using Dummy_Web_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace Dummy_Web_API.Controllers
{
    public class _RetrievePHsController : ApiController
    {
        public RetrievePositionHoldersInfoRequest Post(RetrievePositionHoldersInfoRequest phsModel)
        {
            RetrievePositionHoldersInfoRequest phs = new RetrievePositionHoldersInfoRequest();
            Result r = new Result();

            if (phsModel.result.uen == "AB1234567")
            {
                phsModel.result.entityName = "ABC LLP";
            }
            else
            {
                phsModel.result.entityName = "";
            }

            //phs.result = r;

            return phsModel;
        }
    }
}