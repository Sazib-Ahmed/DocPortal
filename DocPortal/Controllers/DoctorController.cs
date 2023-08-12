using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DocPortal.Controllers
{
    public class DoctorController : ApiController
    {



        [HttpGet]
        [Route("api/doctor/all")]
        public HttpResponseMessage GetAll()
        {
            try 
            {
                var data = DoctorService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        //public IHttpActionResult GetAll()
        //{
        // var data = BLL.Services.DoctorService.GetAll();
        // return Ok(data);
        //}
        [HttpGet]
        [Route("api/doctor/id/{id}")]
        public HttpResponseMessage GetById(int id)
        {
            try
            {
                var data = DoctorService.GetById(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/doctor/name/{name}")]
        public HttpResponseMessage GetByName(string name)
        {
            try
            {
                var data = DoctorService.GetByName(name);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [HttpGet]
        [Route("api/prescription/patient/{id}")]
        public HttpResponseMessage GetByPatientId(int id)
        {
            try
            {
                var data = PrescriptionService.GetByPatientId(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }
}