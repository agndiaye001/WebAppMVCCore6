using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebAppCoreMvc.Models;
using WebAppMVCCore6.Models;

namespace WebAppCoreMvc.Controllers
{
    public class HomeController : Controller
    {
        /*  public ActionResult Index()

          {​​​​​​
              /*ViewData["Nom"] = "monnom";
              ViewData["Prenom"] = "monprenom";

              return View();
          }​​​​​​*/

        public ActionResult Index()
        {
            /*ViewData["Prenom"] = "monprenom";
            ViewData["nom"] = "monenom";*/

            /*TempData["age"] = "test Index ";
            var data = TempData["age"];
            ViewData["age"] = data;

            // save during life  
            TempData.Keep();*/

            Client P = new Client();
            {
                P.rcs = "2222";
                P.email = "email22";
            }
            return View("Index", P);


        }


        
        [Route("welcom")]
        public ActionResult Welcom()
        {
            ViewData["Number"] = 10 + 20;

            var maC = ViewData["Number"]; ;

            return View();
        }

    }

}