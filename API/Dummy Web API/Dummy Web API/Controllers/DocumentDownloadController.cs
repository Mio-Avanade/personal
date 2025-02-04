using Dummy_Web_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Dummy_Web_API.Controllers
{
    public class DocumentDownloadController : ApiController
    {
        public List<DocumentDownloadModel> Post(DocumentDownloadModel complaint)
        {
            DocumentDownloadModel cm = new DocumentDownloadModel();

            cm.status = true;
            cm.url = "https://sampleawsstoragebucket.s3.ap-northeast-1.amazonaws.com/" + complaint.s3ObjectKey;

            return new List<DocumentDownloadModel> {
                cm
            };
        }

    }
}