using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Dummy_Web_API.Models
{
    public class DocumentDownloadModel
    {
        public string sourceId { get; set; }
        public string s3ObjectKey { get; set; }
        public string UUID { get; set; }
        public string userID { get; set; }
        public string caseID { get; set; }
        public string transactionID { get; set; }
        public bool status { get; set; }
        public string url { get; set; }

    }
}