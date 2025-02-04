using Dummy_Web_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dummy_Web_API.Controllers
{
    public class CreateComplaintSIController : ApiController
    {
        public List<ComplaintSIModel> Post(ComplaintSIModel complaint)
        {
            ComplaintSIModel cm = new ComplaintSIModel();

            cm.rcbCaseNo = "test123456789";

            return new List<ComplaintSIModel> {
                cm
            };
        }
    }
}