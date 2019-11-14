using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Master.Controllers;

namespace Master.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : MasterControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
