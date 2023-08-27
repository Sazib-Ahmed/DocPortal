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
    [RoutePrefix("api/health/detail")]
    public class BloodPresureController : ApiController
    {
        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("bloodpressure")]
        public HttpResponseMessage GetAllBloodPressureDetail()
        {
            try
            {
                var data = BloodPressureDetailService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("bloodpressure/{id}")]
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


        [EnableCors("*", "*", "post")]
        [HttpDelete]
        [Route("bloodpressure/{id}")]
        public HttpResponseMessage DeleteBloodPressureDetail(int id)
        {
            try
            {
                BloodPressureDetailService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Successfully deleted.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [EnableCors("*", "*", "put")]
        [HttpPut]
        [Route("bloodpressure/update")]
        public HttpResponseMessage UpdateBloodPressureDetail(BloodPressureDetailDTO bloodPressureDetail)
        {
            try
            {
                var result = BloodPressureDetailService.Update(bloodPressureDetail);
                return Request.CreateResponse(HttpStatusCode.OK, true);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


    }
}
