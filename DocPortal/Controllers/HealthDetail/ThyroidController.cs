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
    [RoutePrefix("api/health/detail")]
    public class ThyroidController : ApiController
    {
        [HttpGet]
        [Route("thyroid")]
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
        [Route("thyroid/{id}")]
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
        [Route("thyroid/update")]
        public HttpResponseMessage UpdateThyroidDetail(ThyroidDetailDTO obj)
        {
            try
            {
                ThyroidDetailService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("thyroid/delete/{id}")]
        public HttpResponseMessage DeleteThyroidDetail(int id)
        {
            try
            {
                ThyroidDetailService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("thyroid/create")]
        public HttpResponseMessage CreateThyroidDetail(ThyroidDetailDTO obj)
        {
            try
            {
                ThyroidDetailService.Create(obj);
                return Request.CreateResponse(HttpStatusCode.Created);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
