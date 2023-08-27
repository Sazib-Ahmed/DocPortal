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
    public class GlucoseLevelController : ApiController
    {
        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("glucoselevel")]
        public HttpResponseMessage GetAllGlucoseLevelDetail()
        {
            try
            {
                var data = GlucoseLevelDetailService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("glucoselevel/{id}")]
        public HttpResponseMessage GetGlucoseLevelDetailById(int id)
        {
            try
            {
                var data = GlucoseLevelDetailService.GetById(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "delete")]
        [HttpDelete]
        [Route("glucoselevel/{id}")]
        public HttpResponseMessage DeleteGlucoseLevelDetail(int id)
        {
            try
            {
                GlucoseLevelDetailService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Successfully deleted.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "put")]
        [HttpPut]
        [Route("glucoselevel/{id}")]
        public HttpResponseMessage UpdateGlucoseLevelDetail(GlucoseLevelDetailDTO clucoseLevelDetail)
        {
            try
            {
                GlucoseLevelDetailService.Update(clucoseLevelDetail);
                return Request.CreateResponse(HttpStatusCode.OK, "Successfully updated.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }
}
