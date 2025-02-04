using Dummy_Web_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dummy_Web_API.Controllers
{
    public class SendEmailController : ApiController
    {
        public SendEmailResponse Post(SendEmailRequest email)
        {
            SendEmailResponse cm = new SendEmailResponse();

            if (email.NotificationId == null)
            {
                cm.Code = 500;
                cm.Message = "Internal server error";
            }
            else
            {
                cm.Code = 200;
            }

            return cm;
        }
    }
}