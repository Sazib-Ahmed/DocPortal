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
    public class PatientController: ApiController
    {


        [HttpGet]
        [Route("api/patient/all")]
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
        [HttpGet]
        [Route("api/doctor/id/{id}")]
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
        [HttpGet]
        [Route("api/doctor/name/{name}")]
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



    }
}