using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstAPI.Controllers
{
    public class FirstAPIController : ApiController
    {
        public HttpResponseMessage Get()
        {
            var data = new { Id = 1, Name = "Anik" };
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        public HttpResponseMessage Post()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "This is a post request");
        }
        public HttpResponseMessage Delete()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "This is delete request");
        }
    }
}
