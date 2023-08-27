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
    public class HemoglobinController : ApiController
    {
        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("hemoglobin")]
        public HttpResponseMessage GetAllHemoglobinDetail()
        {
            try
            {
                var data = HemoglobinDetailService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("hemoglobin/{id}")]
        public HttpResponseMessage GetHemoglobinDetailById(int id)
        {
            try
            {
                var data = HemoglobinDetailService.GetById(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "delete")]
        [HttpDelete]
        [Route("hemoglobin/{id}")]
        public HttpResponseMessage DeleteHemoglobinDetail(int id)
        {
            try
            {
                HemoglobinDetailService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Successfully deleted.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "put")]
        [HttpPut]
        [Route("hemoglobin/{id}")]
        public HttpResponseMessage UpdateHemoglobinDetail(HemoglobinDetailDTO hemoglobinDetail)
        {
            try
            {
              
                HemoglobinDetailService.Update(hemoglobinDetail);
                return Request.CreateResponse(HttpStatusCode.OK, "Successfully updated.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


    }
}
