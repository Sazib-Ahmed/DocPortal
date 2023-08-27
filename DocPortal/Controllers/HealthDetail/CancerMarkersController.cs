﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using BLL.DTOs.PatientHealthDetailDTO;
using BLL.Services.PatientHealthDetailService;

namespace DocPortal.Controllers.HealthDetail
{
    [RoutePrefix("api/health/detail")]
    public class CancerMarkersController : ApiController
    {

        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("cancermarkers")]
        public HttpResponseMessage GetAllCancerMarkersDetail()
        {
            try
            {
                var data = CancerMarkersDetailService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("cancermarkers/{id}")]
        public HttpResponseMessage GetCancerMarkersDetailById(int id)
        {
            try
            {
                var data = CancerMarkersDetailService.GetById(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "delete")]
        [HttpDelete]
        [Route("cancermarkers/{id}")]
        public HttpResponseMessage DeleteCancerMarkersDetail(int id)
        {
            try
            {
                CancerMarkersDetailService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, "Successfully deleted.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "put")]
        [HttpPut]
        [Route("cancermarkers/update")]
        public HttpResponseMessage UpdateCancerMarkersDetail(CancerMarkersDetailDTO cancerMarkersDetail)
        {
            try
            {
                CancerMarkersDetailService.Update(cancerMarkersDetail);
                return Request.CreateResponse(HttpStatusCode.OK, "Successfully updated.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }



    }
}
