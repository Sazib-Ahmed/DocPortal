using System.Net.Http;
using System.Web;

namespace DocPortal.Others
{
    public static class IpAddressHelper
    {
        public static string GetClientIpAddress(HttpRequestMessage request)
        {
            string ipError = "Ip address not found";
            if (request.Properties.TryGetValue("MS_HttpContext", out var value) && value is HttpContextWrapper ctx)
            {
                return ctx.Request.UserHostAddress;
            }
            return ipError;
        }
    }
}
