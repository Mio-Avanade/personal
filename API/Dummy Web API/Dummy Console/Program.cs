using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace Dummy_Console
{
    public class PAPAE
    {
        [DataMember]
        public paDetails paDetails { get; set; }

        [DataMember]
        public paeDetails paeDetails { get; set; }
    }

    public class paDetails
    {
        [DataMember]
        public string identificationNo { get; set; }

        [DataMember]
        public string paName { get; set; }
    }

    public class paeDetails
    {
        [DataMember]
        public string pmpCode { get; set; }

        [DataMember]
        public string uen { get; set; }
    }

    public class complaint
    {
        [DataMember]
        public string rcbCaseNo { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // PAPAE
            //string serviceUrl = string.Format("https://acrabr2s.azurewebsites.net/api/PAPAE?paRegistrationNumber=&pmpCode=&paeUen=AB123456");

            //WebRequest request = WebRequest.Create(serviceUrl);
            //request.Method = "GET";
            //request.ContentType = "Application/Json";
            //HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            //string result = string.Empty;

            //using (Stream stream = response.GetResponseStream())
            //{
            //    StreamReader sr = new StreamReader(stream);
            //    result = sr.ReadToEnd();
            //    sr.Close();
            //}

            //result = result.Replace("[", "").Replace("]", "");

            //using (MemoryStream DeSerializememoryStream = new MemoryStream())
            //{
            //    DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(PAPAE));

            //    StreamWriter writer = new StreamWriter(DeSerializememoryStream);
            //    writer.Write(result);
            //    writer.Flush();

            //    DeSerializememoryStream.Position = 0;

            //    PAPAE SerializedObject = (PAPAE)serializer.ReadObject(DeSerializememoryStream);
            //}

            string serviceUrl = string.Format("http://localhost:52298/api/CreateComplaint");

            WebRequest request = WebRequest.Create(serviceUrl);
            request.Method = "POST";
            request.ContentType = "Application/Json";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                string json = "{\"complainantDescription\":\"\"," +
                              "\"offChargeDesc\":\"\"," +
                              "\"complaintDate\":\"\"," +
                              "\"classification\":\"\"," +
                              "\"offenceCode\":\"\"," +
                              "\"sectionCode\":\"\"," +
                              "\"subSectionCode\":\"\"," +
                              "\"offenceDate\":\"\"," +
                              "\"penaltyAmount\":\"\"," +
                              "\"defendantDetails\":" +
                              "{\"defendantClass\":\"REG\"," +
                              "\"defendantId\":\"\"," +
                              "\"defendantName\":\"\"" +
                              "}}";

                streamWriter.Write(json);
            }

            //var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();
            //using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            //{
            //    var result = streamReader.ReadToEnd();
            //}



            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            string result = string.Empty;

            using (Stream stream = response.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                result = sr.ReadToEnd();
                sr.Close();
            }

            result = result.Replace("[", "").Replace("]", "");

            using (MemoryStream DeSerializememoryStream = new MemoryStream())
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(complaint));

                StreamWriter writer = new StreamWriter(DeSerializememoryStream);
                writer.Write(result);
                writer.Flush();

                DeSerializememoryStream.Position = 0;

                complaint SerializedObject = (complaint)serializer.ReadObject(DeSerializememoryStream);
            }
        }
    }
}
