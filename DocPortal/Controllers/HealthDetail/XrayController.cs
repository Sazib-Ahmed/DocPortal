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
    [RoutePrefix("api/patient/xray")]
    public class XrayController : ApiController
    {
        [EnableCors("*","*","get")]
        [HttpGet]
        [Route("all")]
        public HttpResponseMessage GetAllXrayDetail()
        {
            try
            {
                var data = XrayDetailService.GetAll();
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
        public HttpResponseMessage GetXrayDetailById(int id)
        {
            try
            {
                var data = XrayDetailService.GetById(id);
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
        public HttpResponseMessage CreateXrayDetail(XrayDetailDTO obj)
        {
            try
            {
                var result = XrayDetailService.Create(obj);
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
        public HttpResponseMessage UpdateXrayDetail(XrayDetailDTO obj)
        {
            try
            {
                var result = XrayDetailService.Update(obj);
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
        public HttpResponseMessage DeleteXrayDetail(int id)
        {
            try
            {
                XrayDetailService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Xray details deleted successfully.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("patient/{id}")]
        public HttpResponseMessage GetXrayDetailByPatientId(int id)
        {
            try
            {
                var data = XrayDetailService.GetXrayDetailByPatientId(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


    }
}
