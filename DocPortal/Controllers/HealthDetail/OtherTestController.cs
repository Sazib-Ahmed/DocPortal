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
    [RoutePrefix("api/patient/othertest")]
    public class OtherTestController : ApiController
    {
        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("all")]
        public HttpResponseMessage GetAllOtherTestDetail()
        {
            try
            {
                var data = OtherTestDetailService.GetAll();
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
        public HttpResponseMessage GetOtherTestDetailById(int id)
        {
            try
            {
                var data = OtherTestDetailService.GetById(id);
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
        public HttpResponseMessage CreateOtherTestDetail(OtherTestDetailDTO obj)
        {
            try
            {
                var result = OtherTestDetailService.Create(obj);
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
        public HttpResponseMessage UpdateOtherTestDetail(OtherTestDetailDTO obj)
        {
            try
            {
                var result = OtherTestDetailService.Update(obj);
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
        public HttpResponseMessage DeleteOtherTestDetail(int id)
        {
            try
            {
                OtherTestDetailService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Test Detail deleted successfully.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("patient/{id}")]
        public HttpResponseMessage GetOtherTestDetailByPatientId(int id)
        {
            try
            {
                var data = OtherTestDetailService.GetOtherTestDetailByPatientId(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
