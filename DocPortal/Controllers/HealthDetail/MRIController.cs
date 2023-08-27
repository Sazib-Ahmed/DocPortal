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
    public class MRIController : ApiController
    {
        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("mri")]
        public HttpResponseMessage GetAllMRIDetail()
        {
            try
            {
                var data = MRIDetailService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("mri/{id}")]
        public HttpResponseMessage GetMRIDetail(int id)
        {
            try
            {
                var data = MRIDetailService.GetById(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "post")]
        [HttpPost]
        [Route("mri/create")]
        public HttpResponseMessage CreateMRIDetail(MRIDetailDTO mriDetail)
        {
            try
            {
                MRIDetailService.Create(mriDetail);
                return Request.CreateResponse(HttpStatusCode.OK, "MRI details are added successfully.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "put")]
        [HttpPut]
        [Route("mri/update")]
        public HttpResponseMessage UpdateMRIDetail(MRIDetailDTO mriDetail)
        {
            try
            {
                MRIDetailService.Update(mriDetail);
                return Request.CreateResponse(HttpStatusCode.OK, "MRI details are updated successfully.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "delete")]
        [HttpDelete]
        [Route("mri/{id}")]
        public HttpResponseMessage DeleteMRIDetail(int id)
        {
            try
            {
                MRIDetailService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, "MRI details are deleted successfully.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
