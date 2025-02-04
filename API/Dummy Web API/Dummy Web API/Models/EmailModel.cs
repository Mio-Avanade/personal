using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Web;

namespace Dummy_Web_API.Models
{
    public class SendEmailResponse
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("code")]
        public int Code { get; set; }

        [JsonPropertyName("notificationId")]
        public string NotificationId { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }
    }

    public class SendEmailRequest
    {
        [JsonPropertyName("notificationId")]
        public string NotificationId { get; set; }

        [JsonPropertyName("from")]
        public string From { get; set; }

        [JsonPropertyName("to")]
        public List<string> To { get; set; }

        [JsonPropertyName("cc")]
        public List<string> CC { get; set; }

        [JsonPropertyName("bcc")]
        public List<string> BCC { get; set; }

        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        [JsonPropertyName("body")]
        public string Body { get; set; }

        [JsonPropertyName("transactionId")]
        public string TransactionId { get; set; }

        [JsonPropertyName("data")]
        public List<Data> Data { get; set; }

        [JsonPropertyName("attachmentsLink")]
        public List<Document> AttachmentLink { get; set; }

        [JsonPropertyName("templateId")]
        public string TemplateId { get; set; }
    }

    public class Data
    {
        [JsonPropertyName("username")]
        public string Username { get; set; }

        [JsonPropertyName("sendername")]
        public string Sendername { get; set; }
    }

    public class Document
    {
        [JsonPropertyName("uuid")]
        public string UUID { get; set; }

        //[JsonPropertyName("link")]
        //public string Link { get; set; }
    }
}