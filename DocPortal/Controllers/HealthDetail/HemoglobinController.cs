using BLL.DTOs.PatientHealthDetailDTO;
using BLL.Services.PatientHealthDetailService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Results;

namespace DocPortal.Controllers.HealthDetail
{
    [RoutePrefix("api/patient/hemoglobin")]
    public class HemoglobinController : ApiController
    {
        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("all")]
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
        [Route("{id}")]
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
        [Route("{id}")]
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
        [Route("update")]
        public HttpResponseMessage UpdateHemoglobinDetail(HemoglobinDetailDTO hemoglobinDetail)
        {
            try
            {

                var result = HemoglobinDetailService.Update(hemoglobinDetail);
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
        public HttpResponseMessage CreateHemoglobinDetail(HemoglobinDetailDTO hemoglobinDetail)
        {
            try
            {
                var result = HemoglobinDetailService.Create(hemoglobinDetail);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


    }
}
