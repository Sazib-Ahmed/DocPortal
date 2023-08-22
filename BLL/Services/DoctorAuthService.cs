using BLL.DTOs;
using DAL.EF.Models;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL.Secrets;

namespace BLL.Services
{
    public class DoctorAuthService
    {
        public static DoctorTokenDTO DoctorLogin(string email, string password)
        {
            string encryptedPassword = Cryptography.EncryptPassword(password);

            var doctor = DataAccessFactory.DoctorAuthData().Authenticate(email, encryptedPassword);
            if (doctor != null)
            {
                
                var token = new DoctorToken()
                {
                    DoctorId = doctor.DoctorId,
                    TokenKey = Guid.NewGuid().ToString(),
                    RetrievalCount = 0,
                    CreatedAt = DateTime.Now,
                    ExpiredAt = DateTime.Now.AddMinutes(30),  // Set to 30 minutes from now
                                                              //DateTime.Now.AddDays(30),
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

        public static bool IsTokenValid(string token)
        {
            var currentTime = DateTime.Now;
            var tk = (from t in DataAccessFactory.DoctorTokenData().Get()
                      where t.TokenKey.Equals(token) 
                      && t.IsActive == true
                      && (t.ExpiredAt == null || t.ExpiredAt > currentTime)
                      select t).SingleOrDefault();
            if (tk != null)
            {
                
                tk.RetrievalCount++;
                tk.LastUsedAt = currentTime;
                tk.ExpiredAt = currentTime.AddMinutes(30);
                DataAccessFactory.DoctorTokenData().Update(tk);

                return true;
            }
            return false;
        }

        public static bool InvalidateToken(int id)
        {
            var currentTime = DateTime.Now;
            var tokens = DataAccessFactory.DoctorTokenData().Get().Where(t => t.DoctorId == id && t.ExpiredAt == null || t.DoctorId == id && t.IsActive == true || t.DoctorId == id && t.ExpiredAt > currentTime).ToList();

            if (tokens.Any())
            {
                foreach (var tk in tokens)
                {
                    tk.ExpiredAt = DateTime.Now;
                    tk.IsActive = false;
                    DataAccessFactory.DoctorTokenData().Update(tk);
                }

                return true;
            }
    
            return false;
        }



    }
}
