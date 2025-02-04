using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dummy_Web_API.Models
{
    public class IPSRetrievePaymentByReceiptResponse
    {
        [JsonProperty("status")]
        public string status { get; set; }

        [JsonProperty("results")]
        public Results results { get; set; }
    }

    public class Results
    {
        [JsonProperty("receipt_number")]
        public string receipt_number { get; set; }

        [JsonProperty("ep_reference_number")]
        public string ep_reference_number { get; set; }

        [JsonProperty("customer_code")]
        public string customer_code { get; set; }

        [JsonProperty("customer_name")]
        public string customer_name { get; set; }

        [JsonProperty("payment_mode_code")]
        public string payment_mode_code { get; set; }

        [JsonProperty("payment_mode_desc")]
        public string payment_mode_desc { get; set; }

        [JsonProperty("arn")]
        public string arn { get; set; }

        [JsonProperty("payment_date")]
        public string payment_date { get; set; }

        [JsonProperty("gst_amount")]
        public string gst_amount { get; set; }

        [JsonProperty("total_amount")]
        public string total_amount { get; set; }

        [JsonProperty("document_uuid")]
        public string document_uuid { get; set; }

        [JsonProperty("receipt_items")]
        public List<ReceiptItem> receipt_items { get; set; }
    }
    public class ReceiptItem
    {
        [JsonProperty("transaction_number")]
        public string transaction_number { get; set; }

        [JsonProperty("item_code")]
        public string item_code { get; set; }

        [JsonProperty("item_name")]
        public string item_name { get; set; }

        [JsonProperty("item_description")]
        public string item_description { get; set; }

        [JsonProperty("fee_amount")]
        public string fee_amount { get; set; }
    }
}


