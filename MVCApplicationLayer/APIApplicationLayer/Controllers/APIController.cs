using BusinessLogicLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIApplicationLayer.Controllers
{
    public class APIController : ApiController
    {
        [HttpGet]
        [Route("api/students/all")]
        public HttpResponseMessage GetALl()
        {
            return Request.CreateResponse(HttpStatusCode.OK, StudentService.GetStudents());
        }
    }
}
