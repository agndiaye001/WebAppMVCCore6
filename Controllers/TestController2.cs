using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppCoreMvc.Models;

namespace WebAppMVCCore6.Controllers
{
    public class TestController2 : Controller
    {

        [Route("test")]
        public ActionResult Index()
        {
            ViewData["age2"] = TempData["age"];


            return View();
        }

    }
}
