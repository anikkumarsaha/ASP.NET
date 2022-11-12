using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FirstAPI.Controllers
{
    public class DepartmentController : ApiController
    {
        [Route("api/dept/info")]
        [HttpGet]
        public HttpResponseMessage GetInfo()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "Info from custom route");
        }
        [Route("api/dept/All")]
        [HttpGet]
        public HttpResponseMessage GetAll()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "Getting All from custom route");
        }
    }
}
