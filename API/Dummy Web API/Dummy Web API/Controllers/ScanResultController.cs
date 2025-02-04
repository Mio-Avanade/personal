using Dummy_Web_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dummy_Web_API.Controllers
{
    public class ScanResultController : ApiController
    {
        public ScanResultResponse Post(ScanResulRequest scanResulRequest)
        {
            ScanResultResponse response = new ScanResultResponse();
            response.S3ObjectKey = scanResulRequest.S3ObjectKey;
            response.Status = "Virus Scan is in progress";

            return response;
        }
    }
}
