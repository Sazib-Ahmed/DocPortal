using BLL.Services;
using DocPortal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DocPortal.Controllers
{
    public class DoctorAuthController : ApiController
    {
        [HttpPost]
        [Route("api/Doctor/Login")]
        public HttpResponseMessage Login(LoginModel data)
        {
            var token = DoctorAuthService.DoctorLogin(data.Email, data.Password);   
            if (token != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, token);
            }
            return Request.CreateResponse(HttpStatusCode.Unauthorized, new { Msg = "Invalid Credentials" });
        }
    }
}
