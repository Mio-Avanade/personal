using Dummy_Web_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dummy_Web_API.Controllers
{
    public class CreateComplaintController : ApiController
    {
        public List<ComplaintModel> Post(ComplaintModel complaint)
        {
            ComplaintModel cm = new ComplaintModel();

            cm.rcbCaseNo = "20220429$201531166H";

            return new List<ComplaintModel> {
                cm
            };
        }
    }
}
