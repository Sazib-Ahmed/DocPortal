using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.Services.PatientHealthDetailService;
using BLL.DTOs.PatientHealthDetailDTO;
using System.Web.Http.Cors;

namespace DocPortal.Controllers
{
    [RoutePrefix("api/patient/bloodpressure")]
    public class BloodPresureController : ApiController
    {
        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("all")]
        public HttpResponseMessage GetAllBloodPressureDetail()
        {
            try
            {
                var data = BloodPressureDetailService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK,data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("{id}")]
        public HttpResponseMessage GetBloodPressureDetailById(int id)
        {
            try
            {
                var data = BloodPressureDetailService.GetById(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "delete")]
        [HttpDelete]
        [Route("{id}")]
        public HttpResponseMessage DeleteBloodPressureDetail(int id)
        {
            try
            {
                BloodPressureDetailService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Successfully deleted blood pressure detail with id " + id + ".");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "put")]
        [HttpPut]
        [Route("update")]
        public HttpResponseMessage UpdateBloodPressureDetail(BloodPressureDetailDTO bloodPressureDetail)
        {
            try
            {
                var result = BloodPressureDetailService.Update(bloodPressureDetail);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "post")]
        [HttpPost]
        [Route("create")]
        public HttpResponseMessage CreateBloodPressureDetail(BloodPressureDetailDTO bloodPressureDetail)
        {
            try
            {
                var result = BloodPressureDetailService.Create(bloodPressureDetail);
                return Request.CreateResponse(HttpStatusCode.OK, result);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("bloodpressure/patient/{id}")]
        public HttpResponseMessage GetBloodPressureDetailByPatientId(int id)
        {
            try
            {
                var data = BloodPressureDetailService.GetBloodPressureDetailByPatientId(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        //[EnableCors("*", "*", "get")]
        //[HttpGet]
        //[Route("bloodpressure/patient/{id}/last")]
        //public HttpResponseMessage GetLastBloodPressureDetailByPatientId(int id)
        //{
        //    try
        //    {
        //        var data = BloodPressureDetailService.GetLastBloodPressureDetailByPatientId(id);
        //        return Request.CreateResponse(HttpStatusCode.OK, data);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
        //    }   
        //}


        //[EnableCors("*", "*", "get")]
        //[HttpGet]
        //[Route("bloodpressure/patient/{id}/detail")]

    }
}
