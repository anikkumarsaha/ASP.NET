using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BloodDonation.Controllers
{
    public class GroupController : ApiController
    {
        [Route("api/groups")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = GroupService.GetAllGroups();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/group/{id}")]
        [HttpGet]
        public HttpResponseMessage GetGroup(int id)
        {
            var data = GroupService.GetGroup(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/group/add")]
        [HttpPost]
        public HttpResponseMessage post(GroupDTO obj)
        {
            if(ModelState.IsValid)
            {
                var res = GroupService.AddGroup(obj);
                if (res)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Inserted", data = obj });
                }
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
        }
    }
}
