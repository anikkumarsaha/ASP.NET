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
    public class DonorController : ApiController
    {
        [Route("api/donors")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = DonorService.GetAllDonors();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Donor/{id}")]
        [HttpGet]
        public HttpResponseMessage GetDonor(int id)
        {
            var data = DonorService.GetDonor(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Donor/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage DeleteDonor(int id)
        {
            var data = DonorService.DeleteDonor(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/Donor/add")]
        [HttpPost]
        public HttpResponseMessage post(DonorDTO obj)
        {
            if (ModelState.IsValid)
            {
                var res = DonorService.AddDonor(obj);
                if (res != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Inserted", data = res });
                }
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
        }

        [Route("api/Donor/edit")]
        [HttpPost]
        public HttpResponseMessage edit(DonorDTO obj)
        {
            if (ModelState.IsValid)
            {
                var res = DonorService.EditDonor(obj);
                if (res)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Edited", data = res });
                }
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
            return Request.CreateResponse(HttpStatusCode.BadRequest, ModelState);
        }
    }
}
