using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dummy_Web_API.Models;

namespace Dummy_Web_API.Controllers
{
    public class IPSRetrievePaymentByReceiptController : ApiController
    {
        // GET api/<controller>
        public IPSRetrievePaymentByReceiptResponse Get(string receiptNumber)
        {
            IPSRetrievePaymentByReceiptResponse response = new IPSRetrievePaymentByReceiptResponse();
            response.results = new Results();
            response.results.receipt_items = new List<ReceiptItem>();

            if (receiptNumber.StartsWith("1"))
            {
                response.results.receipt_number = "ACRAYYMMDDXXXXXX";
                response.results.ep_reference_number = "G84VG638";
                response.results.customer_code = "CUS0001";
                response.results.customer_name = "Tan Chia Ying";
                response.results.payment_mode_code = "PAYPAL";
                response.results.payment_mode_desc = "Paypal";
                response.results.arn = "ARN20221201030671";
                response.results.payment_date = "31/12/2022 17:53:12";
                response.results.gst_amount = "8.00";
                response.results.total_amount = "753.00";
                response.results.document_uuid = "DOC12345";

                ReceiptItem receiptItem1 = CreateReceiptItem("C220861054", "201928220W", "StudeoBeaute Pvt Ltd.", "Annual Return by local company", "645.00");
                ReceiptItem receiptItem2 = CreateReceiptItem("C220861054", "201928220W", "StudeoBeaute Pvt Ltd.", "Annual Return by local company", "645.00");
                ReceiptItem receiptItem3 = CreateReceiptItem("F22404473", "201928220W", "StudeoBeaute Pvt Ltd.", "Free Business profile (CO) with annual filing", "0.00");

                List<ReceiptItem> receiptItemCollection = new List<ReceiptItem>()
                {
                    receiptItem1,
                    receiptItem2,
                    receiptItem3
                };

                response.results.receipt_items.AddRange(receiptItemCollection);
            }
            else if (receiptNumber.StartsWith("2"))
            {
                response.results.receipt_number = "ACRAYYMMDDXXXXX1";
                response.results.ep_reference_number = "G84VG639";
                response.results.customer_code = "CUS0002";
                response.results.customer_name = "Edward";
                response.results.payment_mode_code = "PAYPAL";
                response.results.payment_mode_desc = "Paypal";
                response.results.arn = "ARN20221201030672";
                response.results.payment_date = "30/11/2022 17:53:12";
                response.results.gst_amount = "8.00";
                response.results.total_amount = "1392.20";
                response.results.document_uuid = "DOC12347";

                ReceiptItem receiptItem1 = CreateReceiptItem("C220861057", "201928220W", "StudeoBeaute Pvt Ltd.", "Annual Return by local company", "645.00");
                ReceiptItem receiptItem2 = CreateReceiptItem("C220861057", "201928220W", "StudeoBeaute Pvt Ltd.", "Annual Return by local company", "645.00");
                ReceiptItem receiptItem3 = CreateReceiptItem("F22404477", "201928220W", "StudeoBeaute Pvt Ltd.", "Free Business profile (CO) with annual filing", "0.00");

                List<ReceiptItem> receiptItemCollection = new List<ReceiptItem>()
                {
                    receiptItem1,
                    receiptItem2,
                    receiptItem3
                };

                response.results.receipt_items.AddRange(receiptItemCollection);
            }
            else
            {
                response.results.receipt_number = "ACRAYYMMDDXXXXX2";
                response.results.ep_reference_number = "G84VG632";
                response.results.customer_code = "CUS0003";
                response.results.customer_name = "Lily";
                response.results.payment_mode_code = "PAYPAL";
                response.results.payment_mode_desc = "Paypal";
                response.results.arn = "ARN20221201030673";
                response.results.payment_date = "31/10/2022 17:53:12";
                response.results.gst_amount = "8.00";
                response.results.total_amount = "982.80";
                response.results.document_uuid = "DOC34567";

                ReceiptItem receiptItem1 = CreateReceiptItem("C220861057", "201928220W", "StudeoBeaute Pvt Ltd.", "Annual Return by local company", "700.00");
                ReceiptItem receiptItem2 = CreateReceiptItem("C220861057", "201928220W", "StudeoBeaute Pvt Ltd.", "Annual Return by local company", "200.00");
                ReceiptItem receiptItem3 = CreateReceiptItem("F22404477", "201928220W", "StudeoBeaute Pvt Ltd.", "Free Business profile (CO) with annual filing", "10.00");

                List<ReceiptItem> receiptItemCollection = new List<ReceiptItem>()
                {
                    receiptItem1,
                    receiptItem2,
                    receiptItem3
                };

                response.results.receipt_items.AddRange(receiptItemCollection);
            }


            return response;
        }

        private ReceiptItem CreateReceiptItem(string transaction_number, string item_code, string item_name, string item_description, string fee_amount)
        {
            ReceiptItem receiptItem = new ReceiptItem
            {
                transaction_number = transaction_number,
                item_code = item_code,
                item_name = item_name,
                item_description = item_description,
                fee_amount = fee_amount
            };

            return receiptItem;
        }
    }
}