using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DocPortal.Controllers
{
    public class DoctorController : ApiController
    {



        [HttpGet]
        [Route("api/doctor/all")]
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

        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}