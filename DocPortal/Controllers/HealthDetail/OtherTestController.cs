﻿using BLL.DTOs.PatientHealthDetailDTO;
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
    public class OtherTestController : ApiController
    {
        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("othertest")]
        public HttpResponseMessage GetAllOtherTestDetail()
        {
            try
            {
                var data = OtherTestDetailService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("othertest/{id}")]
        public HttpResponseMessage GetOtherTestDetailById(int id)
        {
            try
            {
                var data = OtherTestDetailService.GetById(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [EnableCors("*", "*", "Post")]
        [HttpPost]
        [Route("othertest/create")]
        public HttpResponseMessage CreateOtherTestDetail(OtherTestDetailDTO obj)
        {
            try
            {
                OtherTestDetailService.Create(obj);
                return Request.CreateResponse(HttpStatusCode.Created);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "Put")]
        [HttpPut]
        [Route("othertest/update")]
        public HttpResponseMessage UpdateOtherTestDetail(OtherTestDetailDTO obj)
        {
            try
            {
                OtherTestDetailService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "Delete")]
        [HttpDelete]
        [Route("othertest/{id}")]
        public HttpResponseMessage DeleteOtherTestDetail(int id)
        {
            try
            {
                OtherTestDetailService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}