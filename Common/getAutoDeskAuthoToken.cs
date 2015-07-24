using System.Diagnostics;
using System.IO;
using System.Net;
using System.Text;
using System.Configuration;

namespace AECHackathon.Common
{
    public class getAutoDeskAuthoToken
    {
        public static string getAuthoToken()
        {
            string ReturnData="";

            string url = "https://developer.api.autodesk.com/authentication/v1/authenticate";

            string client_id = ConfigurationManager.AppSettings["autodesk_view_and_data_api_client_id"].ToString();
            string client_secret = ConfigurationManager.AppSettings["autodesk_view_and_data_api_client_secret"].ToString();

            string grant_type =  "client_credentials";

            StringBuilder postData = new StringBuilder();

            postData.Append("client_id=" + client_id);
            postData.Append("&");
            postData.Append("client_secret=" + client_secret);
            postData.Append("&");
            postData.Append("grant_type=" + grant_type);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "POST";
            request.ContentType = "application/x-www-form-urlencoded";
            byte[] bytes = Encoding.UTF8.GetBytes(postData.ToString());
            request.ContentLength = bytes.Length;
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(bytes, 0, bytes.Length);


            try
            {
                WebResponse response = request.GetResponse();

                Trace.WriteLine("reading web service");

                using (StreamReader reader = new StreamReader(response.GetResponseStream(), ASCIIEncoding.ASCII))
                {
                    ReturnData = reader.ReadToEnd();
                }
                return ReturnData;
            }
            catch {
                Trace.WriteLine("failed to get response");
                return ReturnData;
            
            }

            
        }

    }
}