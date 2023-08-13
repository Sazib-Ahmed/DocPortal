using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web;
using System.Web.Http;

namespace DocPortal.Controllers
{
    
    
        public class AppointmentController : ApiController
        {
            [HttpGet]
            [Route("api/appointment/all")]
            public HttpResponseMessage GetAll()
            {
                try
                {
                    var data = AppointmentService.GetAll();
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
                }
            }

            [HttpGet]
            [Route("api/appointment/id/{id}")]
            public HttpResponseMessage GetById(int id)
            {
                try
                {
                    var data = AppointmentService.GetById(id);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
                }
            }

            [HttpGet]
            [Route("api/appointment/doctor/{doctorId}")]
            public HttpResponseMessage GetByDoctor(int doctorId)
            {
                try
                {
                    var data = AppointmentService.GetByDoctor(doctorId);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                catch (Exception ex)
                {
                    return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
                }
            }
        }
    }
