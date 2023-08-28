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
    [RoutePrefix("api/patient/kidneyfunction")]
    public class KidneyFunctionController : ApiController
    {
        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("all")]
        public HttpResponseMessage GetAllKidneyFunctionDetail()
        {
            try
            {
                var data = KidneyFunctionDetailService.GetAll();
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
        public HttpResponseMessage GetKidneyFunctionDetailById(int id)
        {
            try
            {
                var data = KidneyFunctionDetailService.GetById(id);
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
        public HttpResponseMessage AddKidneyFunctionDetail(KidneyFunctionDetailDTO kidneyFunctionDetail)
        {
            try
            {
                var result = KidneyFunctionDetailService.Create(kidneyFunctionDetail);
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
        public HttpResponseMessage UpdateKidneyFunctionDetail(KidneyFunctionDetailDTO kidneyFunctionDetail)
        {
            try
            {
                var result = KidneyFunctionDetailService.Update(kidneyFunctionDetail);
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
        public HttpResponseMessage DeleteKidneyFunctionDetail(int id)
        {
            try
            {
                KidneyFunctionDetailService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Deleted successfully");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
