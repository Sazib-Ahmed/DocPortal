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
    public class PatientAuthService
    {
        public static PatientTokenDTO PatientLogin(string email, string password)
        {
            string encryptedPassword = Cryptography.EncryptPassword(password);


            var patient = DataAccessFactory.PatientAuthData().Authenticate(email, encryptedPassword);
            if (patient != null)
            {
                String originalTokenKey = Guid.NewGuid().ToString();
                String encryptedTokenKey = Cryptography.EncryptToken(originalTokenKey);
                var token = new PatientTokenDTO()
                {
                    PatientId = patient.PatientId,
                    TokenKey = encryptedTokenKey,
                    RetrievalCount = 0,
                    CreatedAt = DateTime.Now,
                    ExpiredAt = DateTime.Now.AddMinutes(30),  // Set to 30 minutes from now
                    LastUsedAt = DateTime.Now,
                    IpAddress = null,
                    IsActive = true,
                    Purpose = "To Access Patient Services"
                };
                var mapper = MapperService<PatientTokenDTO, PatientToken>.GetMapper();
                var mapped = mapper.Map<PatientToken>(token);
                DataAccessFactory.PatientTokenData().Create(mapped);
                token.TokenKey = originalTokenKey;
                return token;
            }
            return null;
        }

        public static bool IsTokenValid(string token)
        {
            String encryptedTokenKey = Cryptography.EncryptToken(token);
            var currentTime = DateTime.Now;
            var tk = (from t in DataAccessFactory.PatientTokenData().Get()
                      where t.TokenKey.Equals(encryptedTokenKey)
                      && t.IsActive == true
                      && (t.ExpiredAt == null || t.ExpiredAt > currentTime)
                      select t).SingleOrDefault();
            if (tk != null)
            {
                tk.RetrievalCount++;
                tk.LastUsedAt = currentTime;
                tk.ExpiredAt = currentTime.AddMinutes(30);
                DataAccessFactory.PatientTokenData().Update(tk);
                return true;
            }
            return false;
        }

        public static bool InvalidateToken(int id)
        {
            var currentTime = DateTime.Now;
            var tokens = DataAccessFactory.PatientTokenData().Get().Where(t => t.PatientId == id && t.ExpiredAt == null || t.PatientId == id && t.IsActive == true || t.PatientId == id && t.ExpiredAt > currentTime).ToList();

            if (tokens.Any())
            {
                foreach (var tk in tokens)
                {
                    tk.ExpiredAt = DateTime.Now;
                    tk.IsActive = false;
                    DataAccessFactory.PatientTokenData().Update(tk);
                }

                return true;
            }

            return false;
        }
    }
}
