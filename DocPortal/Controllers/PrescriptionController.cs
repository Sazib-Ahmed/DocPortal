using System;
using BLL.Services;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DocPortal.Controllers
{
    public class PrescriptionController : ApiController
    {
        [HttpGet]
        [Route("api/prescription/all")]
        public HttpResponseMessage GetAll()
        {
            try
            {
                var data = PrescriptionService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/prescription/id/{id}")]
        public HttpResponseMessage GetById(int id)
        {
            try
            {
                var data = PrescriptionService.GetById(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/prescription/date/{date}")]
        public HttpResponseMessage GetByDate(DateTime date)
        {
            try
            {
                var data = PrescriptionService.GetByDate(date);
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
        [HttpGet]
        [Route("api/prescription/doctor/{id}")]
        public HttpResponseMessage GetByDoctorId(int id)
        {
            try
            {
                var data = PrescriptionService.GetByDoctorId(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


    }
}
