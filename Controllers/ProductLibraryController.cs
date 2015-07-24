using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AECHackathon.Models;
using System.Xml;
using AECHackathon.Common;
using System.Diagnostics;

namespace AECHackathon.Controllers
{
    public class ProductLibraryController : ApiController
    {
        [HttpPost]
        [ActionName("getProductsByIfcObjectType")]

        public HttpResponseMessage getProductsByIfcObjectType([FromBody] ifcObjects ifcM)
        {
            
            XmlDocument xmlDoc = new XmlDocument();

            try
            {
                
                //xmlDoc = ProductLibraryService.getProductSuppliersByIfcObjectType(ifcM.ifcObjectType);
                

                return new HttpResponseMessage()
                {
                   // Content = new StringContent(xmlDoc, System.Text.Encoding.UTF8, "application/xml");
                };

            }
            catch (Exception e)
            {
                Trace.WriteLine(e.GetBaseException().ToString());
                


                return new HttpResponseMessage()
                {
                    Content = new StringContent(e.GetBaseException().ToString(), System.Text.Encoding.UTF8, "application/text")
                };

            }



        }   

    }
}
