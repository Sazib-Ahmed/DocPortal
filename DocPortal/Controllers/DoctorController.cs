using BLL.DTOs;
using BLL.Services;
using DocPortal.AuthFilters;
using DocPortal.Models;
using DocPortal.Others;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace DocPortal.Controllers
{
    [RoutePrefix("api/doctor")]
    public class DoctorController : ApiController
    {

        [EnableCors("*", "*", "post")]
        [HttpPost]
        [Route("login")]
        public HttpResponseMessage Login(LoginModel data)
        {
            try
            {
                // Get client IP address
                string clientIp = IpAddressHelper.GetClientIpAddress(Request);

                var token = DoctorAuthService.DoctorLogin(data.Email, data.Password, clientIp);
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


        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("logout/{id}")]
        [DoctorLogged]
        public HttpResponseMessage Logout(int id)
        {
            try
            {
                DoctorLogged.InvalidateToken(id);
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Logged out successfully" });
            }
            catch (Exception ex)
            {
                
                return Request.CreateResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [EnableCors("*", "*", "get")]
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


        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("{id}")]
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


        [EnableCors("*", "*", "post")]
        [HttpPost]
        [Route("create")]
        public async Task<HttpResponseMessage> Create()
        {
            try
            {
                var form = await Request.Content.ReadAsMultipartAsync();
                var doctorDTOJson = form.Contents.FirstOrDefault(c => c.Headers.ContentDisposition.Name.Trim('"') == "DoctorDTO");
                var imageDataContent = form.Contents.FirstOrDefault(c => c.Headers.ContentDisposition.Name.Trim('"') == "ImageData");

                if (doctorDTOJson == null || imageDataContent == null)
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, new { Msg = "Invalid input data" });
                }

                string doctorDTOJsonString = await doctorDTOJson.ReadAsStringAsync();
                DoctorDTO doctorDTO = JsonConvert.DeserializeObject<DoctorDTO>(doctorDTOJsonString);

                byte[] imageData = await imageDataContent.ReadAsByteArrayAsync();

                var regNumber = doctorDTO.RegistrationNumber;
                

                bool imageUploadResult = DoctorService.UploadImage(imageData, regNumber);

                if (!imageUploadResult)
                {
                    return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = "Failed to upload image" });
                }
                doctorDTO.Image = DoctorService.SetImageName(regNumber);

                var data = DoctorService.Create(doctorDTO);

                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError, new { Msg = "Error" });
            }
        }

        [EnableCors("*", "*", "get")]
        [HttpGet]
        [Route("image/{id}")]
        public HttpResponseMessage GetImage(int id)
        {
            try
            {
                byte[] imageData = DoctorService.GetDoctorImage(id); 

                if (imageData != null)
                {
                    var response = Request.CreateResponse(HttpStatusCode.OK);
                    response.Content = new ByteArrayContent(imageData);
                    response.Content.Headers.ContentType = new MediaTypeHeaderValue("image/png"); 
                    return response;
                }
                else
                {
                    return Request.CreateResponse(HttpStatusCode.BadRequest, "Image not found");
                }
            }
            catch (Exception)
            {
                return Request.CreateResponse(HttpStatusCode.InternalServerError);
            }
        }



        [EnableCors("*", "*", "put")]
        [HttpPut]
        [DoctorLogged]
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

        [EnableCors("*", "*", "delete")]
        [HttpDelete]
        [DoctorLogged]
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

        [EnableCors("*", "*", "get")]
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