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
    public class UrineAnalysisController : ApiController
    {
        [HttpGet]
        [Route("urineanalysis")]
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

        [HttpGet]
        [Route("urineanalysis/{id}")]
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

        [HttpPost]
        [Route("urineanalysis/create")]
        public HttpResponseMessage CreateUrineAnalysisDetail(UrineAnalysisDetailDTO obj)
        {
            try
            {
                UrineAnalysisDetailService.Create(obj);
                return Request.CreateResponse(HttpStatusCode.Created);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("urineanalysis/update")]
        public HttpResponseMessage UpdateUrineAnalysisDetail(UrineAnalysisDetailDTO obj)
        {
            try
            {
                UrineAnalysisDetailService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("urineanalysis/delete/{id}")]
        public HttpResponseMessage DeleteUrineAnalysisDetail(int id)
        {
            try
            {
                UrineAnalysisDetailService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


    }
}
