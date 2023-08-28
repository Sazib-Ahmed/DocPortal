using BLL.DTOs.PatientHealthDetailDTO;
using BLL.Services.PatientHealthDetailService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DocPortal.Controllers.HealthDetail
{
    [RoutePrefix("api/patient/thyroid")]
    public class ThyroidController : ApiController
    {
        [HttpGet]
        [Route("all")]
        public HttpResponseMessage GetAllThyroidDetail()
        {
            try
            {
                var data = ThyroidDetailService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage GetThyroidDetailById(int id)
        {
            try
            {
                var data = ThyroidDetailService.GetById(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("update")]
        public HttpResponseMessage UpdateThyroidDetail(ThyroidDetailDTO obj)
        {
            try
            {
                var result = ThyroidDetailService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public HttpResponseMessage DeleteThyroidDetail(int id)
        {
            try
            {
                ThyroidDetailService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Thyroid details deleted successfully.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("create")]
        public HttpResponseMessage CreateThyroidDetail(ThyroidDetailDTO obj)
        {
            try
            {
                var result = ThyroidDetailService.Create(obj);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
