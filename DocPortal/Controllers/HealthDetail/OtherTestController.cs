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
        [EnableCors("*", "*", "put")]
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

    

    }
}
