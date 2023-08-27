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
    public class ECGController : ApiController
    {
        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("ecg")]
        public HttpResponseMessage GetAllECGDetail()
        {
            try
            {
                var data = ECGDetailService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("ecg/{id}")]
        public HttpResponseMessage GetECGDetailById(int id)
        {
            try
            {
                var data = ECGDetailService.GetById(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [EnableCors("*", "*", "delete")]
        [HttpDelete]
        [Route("ecg/{id}")]
        public HttpResponseMessage DeleteECGDetail(int id)
        {
            try
            {
                ECGDetailService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Successfully deleted.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "put")]
        [HttpPut]
        [Route("ecg/{id}")]
        public HttpResponseMessage PutECGDetail(ECGDetailDTO ecgDetail)
        {
            try
            {
                ECGDetailService.Update(ecgDetail);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


    }
}
