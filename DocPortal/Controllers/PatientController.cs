using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web;
using System.Web.Http;
using BLL.DTOs;
using System.Net.Http.Headers;
using System.Web.Http.Cors;
using DocPortal.AuthFilters;
using DocPortal.Models;

namespace DocPortal.Controllers




{
    [RoutePrefix("api/patient")]

    public class PatientController: ApiController
    {
        [EnableCors("*", "*", "post")]
        [HttpPost]
        [Route("login")]
        public HttpResponseMessage Login(LoginModel data)
        {
            try
            {
                var token = PatientAuthService.PatientLogin(data.Email, data.Password);
                if (token != null)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, token);
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.Unauthorized, new { Msg = "Invalid Credentials" });
                }
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("logout/{id}")]
        [PatientLogged]
        public HttpResponseMessage Logout(int id)
        {
            try
            {
                PatientLogged.InvalidateToken(id);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Logged out successfully" });
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/patient/all")]
        public HttpResponseMessage GetAll()
        {
            try
            {
                var data = PatientService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [EnableCors("*", "*", "get")] // Enable CORS for all origins, all headers, get methods
        [HttpGet]
        [Route("api/patient/id/{id}")]
        public HttpResponseMessage GetById(int id)
        {
            try
            {
                var data = PatientService.GetById(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/patient/create")]
        public HttpResponseMessage Create(PatientDTO obj)
        {
            try
            {
                var data = PatientService.Create(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }
        }
        [HttpPost]
        [Route("api/patient/update")]
        public HttpResponseMessage Update(PatientDTO obj)
        {
            try
            {
                var data = PatientService.Update(obj);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }
        }
        [HttpGet]
        [Route("api/patient/delete/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = PatientService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = ex.Message });
            }
        }


        [HttpGet]
        [Route("api/patient/name/{name}")]
        public HttpResponseMessage GetByName(string name)
        {
            try
            {
                var data = PatientService.GetByName(name);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }



    }
}