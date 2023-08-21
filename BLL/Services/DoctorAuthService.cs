using BLL.DTOs;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class DoctorAuthService
    {
        public static DoctorTokenDTO DoctorLogin(string email, string password)
        {
            var doctor = DataAccessFactory.DoctorAuthData().Authenticate(email, password);
            if (doctor != null)
            {
                var token = new DoctorToken()
                {
                    DoctorId = doctor.DoctorId,
                    TokenKey = Guid.NewGuid().ToString(),
                    CreatedAt = DateTime.Now,
                    ExpiredAt = null, //DateTime.Now.AddDays(30),
                    LastUsedAt = DateTime.Now,
                    IpAddress = null,
                    IsActive = true,
                    Purpose = "To Access Doctor Services"
                };
                var tk = DataAccessFactory.DoctorTokenData().Create(token);
                var mapper = MapperService<DoctorToken, DoctorTokenDTO>.GetMapper();
                var mapped = mapper.Map<DoctorTokenDTO>(tk);
                return mapped;
            }
            return null;
        }
    }
}
