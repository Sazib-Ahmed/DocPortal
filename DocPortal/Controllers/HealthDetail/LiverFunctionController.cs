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
    public class LiverFunctionController : ApiController
    {
        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("liverfunction")]
        public HttpResponseMessage GetAllLiverFunctionDetail()
        {
            try
            {
                var data = LiverFunctionDetailService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("liverfunction/{id}")]
        public HttpResponseMessage GetLiverFunctionDetailById(int id)
        {
            try
            {
                var data = LiverFunctionDetailService.GetById(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [EnableCors("*", "*", "delete")]
        [HttpDelete]
        [Route("liverfunction/{id}")]
        public HttpResponseMessage DeleteLiverFunctionDetail(int id)
        {
            try
            {
                LiverFunctionDetailService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Successfully deleted.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "post")]
        [HttpPost]
        [Route("liverfunction/create")]
        public HttpResponseMessage CreateLiverFunctionDetail(LiverFunctionDetailDTO liverFunctionDetail)
        {
            try
            {
                LiverFunctionDetailService.Create(liverFunctionDetail);
                return Request.CreateResponse(HttpStatusCode.OK, "Successfully created.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "put")]
        [HttpPut]
        [Route("liverfunction/update")]
        public HttpResponseMessage UpdateLiverFunctionDetail(LiverFunctionDetailDTO liverFunctionDetail)
        {
            try
            {
                LiverFunctionDetailService.Update(liverFunctionDetail);
                return Request.CreateResponse(HttpStatusCode.OK, "Successfully updated.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
