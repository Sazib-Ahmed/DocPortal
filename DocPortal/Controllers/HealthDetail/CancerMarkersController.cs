using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BLL.DTOs.PatientHealthDetailDTO;
using BLL.Services.PatientHealthDetailService;

namespace DocPortal.Controllers.HealthDetail
{
    [RoutePrefix("api/patient/cancermarkers")]
    public class CancerMarkersController : ApiController
    {

        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("all")]
        public HttpResponseMessage GetAllCancerMarkersDetail()
        {
            try
            {
                var data = CancerMarkersDetailService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage GetCancerMarkersDetailById(int id)
        {
            try
            {
                var data = CancerMarkersDetailService.GetById(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "delete")]
        [HttpDelete]
        [Route("{id}")]
        public HttpResponseMessage DeleteCancerMarkersDetail(int id)
        {
            try
            {
                CancerMarkersDetailService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Successfully deleted.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "put")]
        [HttpPut]
        [Route("update")]
        public HttpResponseMessage UpdateCancerMarkersDetail(CancerMarkersDetailDTO cancerMarkersDetail)
        {
            try
            {
                var result = CancerMarkersDetailService.Update(cancerMarkersDetail);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "post")]
        [HttpPost]
        [Route("create")]
        public HttpResponseMessage CreateCancerMarkersDetail(CancerMarkersDetailDTO cancerMarkersDetail)
        {
            try
            {
                var result = CancerMarkersDetailService.Create(cancerMarkersDetail);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("patient/{patientId}")]
        public HttpResponseMessage GetCancerMarkersDetailByPatientId(int patientId)
        {
            try
            {
                var data = CancerMarkersDetailService.GetCancerMarkersDetailByPatientId(patientId);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }








    }
}
