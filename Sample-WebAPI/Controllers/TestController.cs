using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Sample_WebAPI.Controllers
{
    public class TestController : ApiController
    {
        public static List<string> NameList = new List<string> {"Chris", "Jhon", "Adam"};

        public List<string> Get() {
            return NameList.ToList(); 
        }
        public HttpResponseMessage Get(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, NameList[id]);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        public HttpResponseMessage Post([FromBody] string name)
        {
            try
            {
                NameList.Add(name);
                return Request.CreateResponse(HttpStatusCode.OK, "Name " + name + " added successfully");
            }
            catch(Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
        public HttpResponseMessage Put([FromBody] string name, int id)
        {
            try
            {
                NameList[id] = name;
                return Request.CreateResponse(HttpStatusCode.OK, "Name " + name + " updated successfully");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }           
        }
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                NameList.RemoveAt(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Name Deleted successfully");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
