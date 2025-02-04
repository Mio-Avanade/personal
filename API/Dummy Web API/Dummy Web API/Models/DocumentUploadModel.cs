using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

namespace Dummy_Web_API.Models
{
    public class DocUploadRequest
    {
        [JsonPropertyName("caseId")]
        public string CaseId { get; set; }

        [JsonPropertyName("transactionId")]
        public string TransactionId { get; set; }

        [JsonPropertyName("sourceId")]
        public string SourceId { get; set; }

        [JsonPropertyName("sourceS3Bucket")]
        public string SourceS3Bucket { get; set; }

        [JsonPropertyName("createdOn")]
        public string CreatedOn { get; set; }

        [JsonPropertyName("createdBy")]
        public string CreatedBy { get; set; }

        [JsonPropertyName("attachments")]
        public Attachment[] Attachments { get; set; }
    }

    public class Attachment
    {
        [JsonPropertyName("fileName")]
        public string FileName { get; set; }

        [JsonPropertyName("s3ObjectKey")]
        public string S3ObjectKey { get; set; }

        [JsonPropertyName("documentType")]
        public string DocumentType { get; set; }

        [JsonPropertyName("fileSize")]
        public string FileSize { get; set; }

        [JsonPropertyName("remarks")]
        public string Remarks { get; set; }

        [JsonPropertyName("isDeleted")]
        public long IsDeleted { get; set; }

        [JsonPropertyName("uuid")]
        public Guid Uuid { get; set; }
    }

    public class DocUploadResponse
    {
        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("transactionId")]
        public string TransactionId { get; set; }

        [JsonPropertyName("uuids")]
        public Guid[] Uuids { get; set; }
    }
}