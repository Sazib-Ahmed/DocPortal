using System;
using BLL.Services;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.DTOs;

namespace DocPortal.Controllers
{
    [RoutePrefix("api/patient/health")]
    public class HealthController : ApiController
    {
        [HttpGet]
        [Route("all")]
        public HttpResponseMessage GetAll()
        {
            try
            {
                var data = PatientHealthService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("id/{id}")]
        public HttpResponseMessage GetById(int id)
        {
            try
            {
                var data = PatientHealthService.GetById(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("create")]
        public HttpResponseMessage Create(PatientHealthDTO patient)
        {
            try
            {
                var result = PatientHealthService.Create(patient);
                return Request.CreateResponse(HttpStatusCode.OK, true);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("update")]
        public HttpResponseMessage Update(PatientHealthDTO patient)
        {
            try
            {
                var result = PatientHealthService.Update(patient);
                return Request.CreateResponse(HttpStatusCode.OK, true);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var result = PatientHealthService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, true);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("Patient/{patientId}")]
        public HttpResponseMessage GetByPatientId(int patientId)
        {
            try
            {
                var data = PatientHealthService.GetByPatientId(patientId);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [HttpGet]
        [Route("PatientId/{patientId}/detail")]
        public HttpResponseMessage GetPatientHealthDetailByPatientId(int patientId)
        {
            try
            {
                var data = PatientHealthService.GetPatientHealthDetailByPatientId(patientId);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        

    }
}
