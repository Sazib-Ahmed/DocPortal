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
    public class CompleteBloodCountController : ApiController
    {
        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("completebloodcount")]
        public HttpResponseMessage GetAllCompleteBloodCountDetail()
        {
            try
            {
                var data = CompleteBloodCountDetailService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("completebloodcount/{id}")]
        public HttpResponseMessage GetCompleteBloodCountDetailById(int id)
        {
            try
            {
                var data = CompleteBloodCountDetailService.GetById(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "delete")]
        [HttpDelete]
        [Route("completebloodcount/{id}")]
        public HttpResponseMessage DeleteCompleteBloodCountDetail(int id)
        {
            try
            {
                CompleteBloodCountDetailService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Successfully deleted.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "put")]
        [HttpPut]
        [Route("completebloodcount/{id}")]
        public HttpResponseMessage UpdateCompleteBloodCountDetail(CompleteBloodCountDetailDTO completeBloodCountDetail)
        {
            try
            {
                CompleteBloodCountDetailService.Update(completeBloodCountDetail);
                return Request.CreateResponse(HttpStatusCode.OK, "Successfully updated.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "post")]
        [HttpPost]
        [Route("completebloodcount/create")]
        public HttpResponseMessage AddCompleteBloodCountDetail(CompleteBloodCountDetailDTO completeBloodCountDetail)
        {
            try
            {
                CompleteBloodCountDetailService.Create(completeBloodCountDetail);
                return Request.CreateResponse(HttpStatusCode.OK, "Successfully added.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
