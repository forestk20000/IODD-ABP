using Microsoft.AspNetCore.Antiforgery;
using IODD.Controllers;

namespace IODD.Web.Host.Controllers
{
    public class AntiForgeryController : IODDControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
