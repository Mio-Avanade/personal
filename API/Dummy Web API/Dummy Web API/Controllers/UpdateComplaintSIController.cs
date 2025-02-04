using Dummy_Web_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dummy_Web_API.Controllers
{
    public class UpdateComplaintSIController : ApiController
    {
        public List<UpdateComplaintSIModel> Post(UpdateComplaintSIModel complaint)
        {
            UpdateComplaintSIModel cm = new UpdateComplaintSIModel();

            cm.rcbCaseNo = "UpdateCompSI12345";

            return new List<UpdateComplaintSIModel> {
                cm
            };
        }
    }
}
