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
    public class KidneyFunctionController : ApiController
    {
        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("kidneyfunction")]
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
        [Route("kidneyfunction/{id}")]
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
        [Route("kidneyfunction")]
        public HttpResponseMessage AddKidneyFunctionDetail()
        {
            try
            {
                // implement add logic here
                return Request.CreateResponse(HttpStatusCode.OK, "Added successfully");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "put")]
        [HttpPut]
        [Route("kidneyfunction/update")]
        public HttpResponseMessage UpdateKidneyFunctionDetail(KidneyFunctionDetailDTO kidneyFunctionDetail)
        {
            try
            {
                KidneyFunctionDetailService.Update(kidneyFunctionDetail);
                return Request.CreateResponse(HttpStatusCode.OK, "Updated successfully");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [EnableCors("*", "*", "delete")]
        [HttpDelete]
        [Route("kidneyfunction/{id}")]
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
