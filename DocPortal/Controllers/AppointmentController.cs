using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web;
using System.Web.Http;
using BLL.DTOs;
using DAL.EF.DTOs;

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


        [HttpPost]
        [Route("api/appointment/create")]
        public HttpResponseMessage Create(AppointmentDTO obj)
        {
            try
            {
                var data = AppointmentService.Create(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }
        }


        [HttpPost]
        [Route("api/appointment/update")]
        public HttpResponseMessage Update(AppointmentDTO obj)
        {
            try
            {
                var data = AppointmentService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }
        }


        [HttpGet]
        [Route("api/appointment/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = AppointmentService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
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
