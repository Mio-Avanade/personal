using Dummy_Web_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace Dummy_Web_API.Controllers
{
    public class ScanResultOnlyController : ApiController
    {
        public ScanResultResponse Post(ScanResulRequest scanResulRequest)
        {
            ScanResultResponse response = new ScanResultResponse();

            if (scanResulRequest.S3ObjectKey != null && scanResulRequest.Br2Token != null)
            {
                if (scanResulRequest.S3ObjectKey.Contains("Virus"))
                {
                    response.S3ObjectKey = scanResulRequest.S3ObjectKey;
                    response.Status = "Virus File";
                }
                else
                {
                    response.S3ObjectKey = scanResulRequest.S3ObjectKey;
                    response.Status = "Success";
                    response.Uuid = "34657";
                }
            }

            return response;
        }
    }
}
