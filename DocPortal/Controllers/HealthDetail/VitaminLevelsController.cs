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
    [RoutePrefix("api/patient/vitaminlevels")]
    public class VitaminLevelsController : ApiController
    {
        [EnableCors("*","*","get")]
        [HttpGet]
        [Route("all")]
        public HttpResponseMessage GetAllVitaminLevelsDetail()
        {
            try
            {
                var data = VitaminLevelsDetailService.GetAll();
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
        public HttpResponseMessage GetVitaminLevelsDetailById(int id)
        {
            try
            {
                var data = VitaminLevelsDetailService.GetById(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "Post")]
        [HttpPost]
        [Route("create")]
        public HttpResponseMessage CreateVitaminLevelsDetail(VitaminLevelsDetailDTO obj)
        {
            try
            {
                var result = VitaminLevelsDetailService.Create(obj);
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
        public HttpResponseMessage UpdateVitaminLevelsDetail(VitaminLevelsDetailDTO obj)
        {
            try
            {
                var result = VitaminLevelsDetailService.Update(obj);
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
        public HttpResponseMessage DeleteVitaminLevelsDetail(int id)
        {
            try
            {
                VitaminLevelsDetailService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Vitamin Levels details deleted successfully.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
