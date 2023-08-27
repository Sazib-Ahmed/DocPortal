using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BLL.DTOs.PatientHealthDetailDTO;
using BLL.Services.PatientHealthDetailService;

namespace DocPortal.Controllers.HealthDetail
{
    [RoutePrefix("api/health/detail")]
    public class CholesterolLevelController : ApiController
    {
        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("cholesterollevel")]
        public HttpResponseMessage GetAllCholesterolLevelDetail()
        {
            try
            {
                var data = CholesterolLevelDetailService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("cholesterollevel/{id}")]
        public HttpResponseMessage GetCholesterolLevelDetailById(int id)
        {
            try
            {
                var data = CholesterolLevelDetailService.GetById(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "delete")]
        [HttpDelete]
        [Route("cholesterollevel/{id}")]
        public HttpResponseMessage DeleteCholesterolLevelDetail(int id)
        {
            try
            {
                CholesterolLevelDetailService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Successfully deleted.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "put")]
        [HttpPut]
        [Route("cholesterollevel/update")]
        public HttpResponseMessage UpdateCholesterolLevelDetail(CholesterolLevelDetailDTO cholesterolLevelDetail)
        {
            try
            {
                var data = CholesterolLevelDetailService.Update(cholesterolLevelDetail);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


    }
}
