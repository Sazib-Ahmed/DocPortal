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
    public class ImmunizationHistoryController : ApiController
    {
        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("immunizationhistory")]
        public HttpResponseMessage GetAllImmunizationHistoryDetail()
        {
            try
            {
                var data = ImmunizationHistoryDetailService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("immunizationhistory/{id}")]
        public HttpResponseMessage GetImmunizationHistoryDetailById(int id)
        {
            try
            {
                var data = ImmunizationHistoryDetailService.GetById(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "delete")]
        [HttpDelete]
        [Route("immunizationhistory/{id}")]
        public HttpResponseMessage DeleteImmunizationHistoryDetailById(int id)
        {
            try
            {
                ImmunizationHistoryDetailService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "put")]
        [HttpPut]
        [Route("immunizationhistory/{id}")]
        public HttpResponseMessage UpdateImmunizationHistoryDetailById(ImmunizationHistoryDetailDTO immunizationHistoryDetail)
        {
            try
            {
                ImmunizationHistoryDetailService.Update(immunizationHistoryDetail);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "post")]
        [HttpPost]
        [Route("immunizationhistory/create")]
        public HttpResponseMessage CreateImmunizationHistoryDetail(ImmunizationHistoryDetailDTO immunizationHistoryDetail)
        {
            try
            {
                ImmunizationHistoryDetailService.Create(immunizationHistoryDetail);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }
}
