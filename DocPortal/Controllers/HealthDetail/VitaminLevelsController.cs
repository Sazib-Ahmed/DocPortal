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
    public class VitaminLevelsController : ApiController
    {
        [EnableCors("*","*","get")]
        [HttpGet]
        [Route("vitaminlevels")]
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
        [Route("vitaminlevels/{id}")]
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
        [Route("vitaminlevels/create")]
        public HttpResponseMessage CreateVitaminLevelsDetail(VitaminLevelsDetailDTO obj)
        {
            try
            {
                VitaminLevelsDetailService.Create(obj);
                return Request.CreateResponse(HttpStatusCode.Created);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "put")]
        [HttpPut]
        [Route("vitaminlevels/update")]
        public HttpResponseMessage UpdateVitaminLevelsDetail(VitaminLevelsDetailDTO obj)
        {
            try
            {
                VitaminLevelsDetailService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "delete")]
        [HttpDelete]
        [Route("vitaminlevels/delete/{id}")]
        public HttpResponseMessage DeleteVitaminLevelsDetail(int id)
        {
            try
            {
                VitaminLevelsDetailService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
