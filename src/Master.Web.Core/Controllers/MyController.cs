using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;

namespace Master.Controllers
{
    public class MyController: MasterControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
