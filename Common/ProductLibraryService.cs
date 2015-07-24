using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Xml;

namespace AECHackathon.Common
{
    public class ProductLibraryService
    {
        /*
        public static XmlDocument getProductSuppliersByIfcObjectType(string ifcObjectType)
        {
            Guid IDActor = Guid.Empty;

            //MasterActor mActor = new MasterActor();

            string url = "http://172.16.2.94:8080/CounterWebApp/manufacturer/getManufacturerProducts";

            string gui = "";

            StringBuilder getData = new StringBuilder();

            getData.Append("gui=" + gui);
            getData.Append("&");
            getData.Append("type=" + ifcObjectType);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";
            request.ContentType = "application/x-www-form-urlencoded";
            string getData = "strIDActor=&OrderBy=&UpDown=";
            byte[] bytes = Encoding.UTF8.GetBytes(postData);
            request.ContentLength = bytes.Length;
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(bytes, 0, bytes.Length);


            try
            {
            WebResponse response = request.GetResponse();
            Stream stream = response.GetResponseStream();
            StreamReader reader = new StreamReader(stream);

            Trace.WriteLine("reading web service");
            XmlDocument xmlDoc = new XmlDocument();
            using (HttpWebResponse resp = request.GetResponse() as HttpWebResponse)
            {
                xmlDoc.Load(resp.GetResponseStream());
                return xmlDoc;
            }

            }
            catch (Exception x)
            {
                Trace.WriteLine(x.GetBaseException().ToString());
                string xmlContent = "<Message error=\"error message [" + x.GetBaseException().ToString() + "]\"/>";
                XmlDocument xmlDoc = new XmlDocument();
                xmlDoc.LoadXml(xmlContent);
                return xmlDoc;
            }

        }
         */
    }
}