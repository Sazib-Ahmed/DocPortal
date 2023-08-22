using BLL.DTOs;
using BLL.Services;
using DocPortal.AuthFilters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DocPortal.Controllers
{
    [RoutePrefix("api/doctor")]
    public class DoctorController : ApiController
    {
        
        [HttpGet]
        [Route("all")]
        [DoctorLogged]
        public HttpResponseMessage GetAll()
        {
            try 
            {
                var data = DoctorService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        //public IHttpActionResult GetAll()
        //{
        // var data = BLL.Services.DoctorService.GetAll();
        // return Ok(data);
        //}

        [HttpGet]
        [Route("id/{id}")]
        public HttpResponseMessage GetById(int id)
        {
            try
            {
                var data = DoctorService.GetById(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("create")]
        public HttpResponseMessage Create(DoctorDTO obj)
        {
            try
            {
                var data = DoctorService.Create(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }
        }
        [HttpPut]
        [Route("update")]
        public HttpResponseMessage Update(DoctorDTO obj)
        {
            try
            {
                var data = DoctorService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }
        }
        [HttpDelete]
        [Route("delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = DoctorService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }
        }


        [HttpGet]
        [Route("name/{name}")]
        public HttpResponseMessage GetByName(string name)
        {
            try
            {
                var data = DoctorService.GetByName(name);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }



        //[HttpGet]
        //[Route("prescription/patient/{id}")]
        //public HttpResponseMessage GetByPatientId(int id)
        //{
        //    try
        //    {
        //        var data = PrescriptionService.GetByPatientId(id);
        //        return Request.CreateResponse(HttpStatusCode.OK, data);
        //    }
        //    catch (Exception ex)
        //    {
        //        return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
        //    }
        //}

    }
}