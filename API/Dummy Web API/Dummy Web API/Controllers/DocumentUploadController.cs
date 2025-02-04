using Dummy_Web_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dummy_Web_API.Controllers
{
    public class DocumentUploadController : ApiController
    {
        public DocUploadResponse Post(DocUploadRequest docUploadRequest)
        {
            DocUploadResponse response = new DocUploadResponse();

            for (int i = 0; i < docUploadRequest.Attachments.Length; i++)
            {
                if (docUploadRequest.Attachments[i].FileName != null && docUploadRequest.SourceId != null)
                {
                    Guid[] guidArray = new Guid[2];
                    guidArray[0] = new Guid("759eb7cf-8a52-4472-8fd0-6d8fc02a05a0");
                    guidArray[1] = new Guid("759eb7cf-8a52-4472-8fd0-6d8fc02a05a0");

                    response.Status = "Success";
                    response.Uuids = guidArray;
                    response.TransactionId = "5324563";
                    response.Message = "Document submitted successfully";
                }
            }

            return response;
        }
    }
}
