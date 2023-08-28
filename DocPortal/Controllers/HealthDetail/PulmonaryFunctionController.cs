using BLL.DTOs.PatientHealthDetailDTO;
using BLL.Services.PatientHealthDetailService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace DocPortal.Controllers.HealthDetail
{
    [RoutePrefix("api/patient/pulmonaryfunction")]
    public class PulmonaryFunctionController : ApiController
    {
        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("all")]
        public HttpResponseMessage GetAllPulmonaryFunctionDetail()
        {
            try
            {
                var data = PulmonaryFunctionDetailService.GetAll();
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
        public HttpResponseMessage GetPulmonaryFunctionDetailById(int id)
        {
            try
            {
                var data = PulmonaryFunctionDetailService.GetById(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [EnableCors("*", "*", "Post")]
        [HttpPost]
        [Route("create")]
        public HttpResponseMessage CreatePulmonaryFunctionDetail(PulmonaryFunctionDetailDTO obj)
        {
            try
            {
                var result = PulmonaryFunctionDetailService.Create(obj);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [EnableCors("*", "*", "Put")]
        [HttpPut]
        [Route("update")]
        public HttpResponseMessage UpdatePulmonaryFunctionDetail(PulmonaryFunctionDetailDTO obj)
        {
            try
            {
                var result = PulmonaryFunctionDetailService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [EnableCors("*", "*", "Delete")]
        [HttpDelete]
        [Route("{id}")]
        public HttpResponseMessage DeletePulmonaryFunctionDetail(int id)
        {
            try
            {
                PulmonaryFunctionDetailService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Pulmonary Function details deleted successfully.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("patient/{id}")]
        public HttpResponseMessage GetPulmonaryFunctionDetailByPatientId(int id)
        {
            try
            {
                var data = PulmonaryFunctionDetailService.GetPulmonaryFunctionDetailByPatientId(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }
}
