using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DocPortal.Controllers
{
    public class PrescriptionController : ApiController
    {
        [HttpGet]
        [Route("api/prescription/all")]
        public HttpResponseMessage GetAll()
        {
            try
            {
                var data = BLL.Services.PrescriptionService.GetAll();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/prescription/date/{date}")]
        public HttpResponseMessage GetByDate(DateTime date)
        {
            try
            {
                var data = BLL.Services.PrescriptionService.GetByDate(date);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


    }
}
