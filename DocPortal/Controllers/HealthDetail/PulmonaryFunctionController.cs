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
    public class PulmonaryFunctionController : ApiController
    {
        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("pulmonaryfunction")]
        public HttpResponseMessage GetAllPulmonaryFunctionDetail()
        {
            try
            {
                var data = PulmonaryFunctionDetailService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("pulmonaryfunction/{id}")]
        public HttpResponseMessage GetPulmonaryFunctionDetailById(int id)
        {
            try
            {
                var data = PulmonaryFunctionDetailService.GetById(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [EnableCors("*", "*", "Post")]
        [HttpPost]
        [Route("pulmonaryfunction/create")]
        public HttpResponseMessage CreatePulmonaryFunctionDetail(PulmonaryFunctionDetailDTO obj)
        {
            try
            {
                PulmonaryFunctionDetailService.Create(obj);
                return Request.CreateResponse(HttpStatusCode.Created);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [EnableCors("*", "*", "Put")]
        [HttpPut]
        [Route("pulmonaryfunction/update")]
        public HttpResponseMessage UpdatePulmonaryFunctionDetail(PulmonaryFunctionDetailDTO obj)
        {
            try
            {
                PulmonaryFunctionDetailService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [EnableCors("*", "*", "Delete")]
        [HttpDelete]
        [Route("pulmonaryfunction/delete")]
        public HttpResponseMessage DeletePulmonaryFunctionDetail(int id)
        {
            try
            {
                PulmonaryFunctionDetailService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }
}
