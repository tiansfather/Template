using Microsoft.AspNetCore.Antiforgery;
using Master.Controllers;

namespace Master.Web.Host.Controllers
{
    public class AntiForgeryController : MasterControllerBase
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
