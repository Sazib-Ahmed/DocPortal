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
    [RoutePrefix("api/patient/urineanalysis")]
    public class UrineAnalysisController : ApiController
    {
        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("all")]
        public HttpResponseMessage GetAllUrineAnalysisDetail()
        {
            try
            {
                var data = UrineAnalysisDetailService.GetAll();
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
        public HttpResponseMessage GetUrineAnalysisDetailById(int id)
        {
            try
            {
                var data = UrineAnalysisDetailService.GetById(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [EnableCors("*", "*", "post")]
        [HttpPost]
        [Route("create")]
        public HttpResponseMessage CreateUrineAnalysisDetail(UrineAnalysisDetailDTO obj)
        {
            try
            {
                var result = UrineAnalysisDetailService.Create(obj);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "put")]
        [HttpPut]
        [Route("update")]
        public HttpResponseMessage UpdateUrineAnalysisDetail(UrineAnalysisDetailDTO obj)
        {
            try
            {
                var result = UrineAnalysisDetailService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "delete")]
        [HttpDelete]
        [Route("{id}")]
        public HttpResponseMessage DeleteUrineAnalysisDetail(int id)
        {
            try
            {
                UrineAnalysisDetailService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Urine Analysis detail deleted successfully.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


    }
}
