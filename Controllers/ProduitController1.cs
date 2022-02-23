using Microsoft.AspNetCore.Mvc;
using WebAppMVCCore6.Models;

namespace WebAppMVCCore6.Controllers
{
    public class ProduitController1 : Controller
    {

        public IActionResult Index()
        {

            Produit P = new Produit();
            {
                P.reference = "ref1";
                P.quantity = 23;
                P.price = 123;
            }

            return View("Index", P);


        }
        
    }
}
