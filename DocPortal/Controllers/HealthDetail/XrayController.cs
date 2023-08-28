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
    [RoutePrefix("api/health/detail")]
    public class XrayController : ApiController
    {
        [EnableCors("*","*","get")]
        [HttpGet]
        [Route("xray")]
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
        [Route("xray/{id}")]
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
        [Route("xray/create")]
        public HttpResponseMessage CreateXrayDetail(XrayDetailDTO obj)
        {
            try
            {
                XrayDetailService.Create(obj);
                return Request.CreateResponse(HttpStatusCode.Created);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "Put")]
        [HttpPut]
        [Route("xray/update")]
        public HttpResponseMessage UpdateXrayDetail(XrayDetailDTO obj)
        {
            try
            {
                XrayDetailService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "Delete")]
        [HttpDelete]
        [Route("xray/delete/{id}")]
        public HttpResponseMessage DeleteXrayDetail(int id)
        {
            try
            {
                XrayDetailService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


    }
}
