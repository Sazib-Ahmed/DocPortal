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
    public class CTScanController : ApiController
    {
        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("ctscan")]
        public HttpResponseMessage GetAllCTScanDetail()
        {
            try
            {
                var data = CTScanDetailService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("ctscan/{id}")]
        public HttpResponseMessage GetCTScanDetailById(int id)
        {
            try
            {
                var data = CTScanDetailService.GetById(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "delete")]
        [HttpDelete]
        [Route("ctscan/{id}")]
        public HttpResponseMessage DeleteCTScanDetail(int id)
        {
            try
            {
                CTScanDetailService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Successfully deleted.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "put")]
        [HttpPut]
        [Route("ctscan/{id}")]
        public HttpResponseMessage UpdateCTScanDetail(CTScanDetailDTO ctScanDetail)
        {
            try
            {
                
                CTScanDetailService.Update(ctScanDetail);
                return Request.CreateResponse(HttpStatusCode.OK, "Successfully updated.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "post")]
        [HttpPost]
        [Route("ctscan/create")]
        public HttpResponseMessage AddCTScanDetail(CTScanDetailDTO ctScanDetail)
        {
            try
            {
                CTScanDetailService.Create(ctScanDetail);
                return Request.CreateResponse(HttpStatusCode.OK, "Successfully added.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }
}
