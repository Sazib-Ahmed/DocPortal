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
        public static DoctorTokenDTO DoctorLogin(string email, string password, string ipAddress)
        {
            string encryptedPassword = Cryptography.EncryptPassword(password);

            var doctor = DataAccessFactory.DoctorAuthData().Authenticate(email, encryptedPassword);
            if (doctor == null)
            {
                doctor = DataAccessFactory.DoctorData().Get().Where(d => d.Email == email).SingleOrDefault();
                if (doctor != null)
                {
                    doctor.FailedLoginAttempts++;
                    doctor.LockoutEnd= DateTime.Now.AddDays(30);
                    DataAccessFactory.DoctorData().Update(doctor);
                    
                }
                return null;
            }
            if (doctor != null)
            {
                if (doctor.FailedLoginAttempts >= 3 && doctor.LockoutEnd > DateTime.Now)
                {
                    return null;
                }
                doctor.FailedLoginAttempts = 0;
                doctor.LockoutEnd = null;
                DataAccessFactory.DoctorData().Update(doctor);

                String originalTokenKey = Guid.NewGuid().ToString();
                String encryptedTokenKey = Cryptography.EncryptToken(originalTokenKey);
                var token = new DoctorTokenDTO()
                {
                    DoctorId = doctor.DoctorId,
                    TokenKey = encryptedTokenKey,
                    RetrievalCount = 0,
                    CreatedAt = DateTime.Now,
                    ExpiredAt = DateTime.Now.AddMinutes(30),  // Set to 30 minutes from now
                                                              //DateTime.Now.AddDays(30),
                    LastUsedAt = DateTime.Now,
                    IpAddress = ipAddress,
                    IsActive = true,
                    Purpose = "To Access Doctor Services"
                };
                var mapper = MapperService<DoctorTokenDTO, DoctorToken>.GetMapper();
                var mapped = mapper.Map<DoctorToken>(token);
                DataAccessFactory.DoctorTokenData().Create(mapped);
                token.TokenKey = originalTokenKey;
                return token;
            }
            
            return null;
        }

        public static bool IsTokenValid(string token)
        {
            String encryptedTokenKey = Cryptography.EncryptToken(token);
            var currentTime = DateTime.Now;
            var tk = (from t in DataAccessFactory.DoctorTokenData().Get()
                      where t.TokenKey.Equals(encryptedTokenKey) 
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
