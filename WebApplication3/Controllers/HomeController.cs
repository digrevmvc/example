using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;
using WebApplication3.Veri;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Listele()
        {
            List<Personel> model = PersonelVeriler.listPersoneller;

            return View(model);
        }

        [HttpGet]
        public ActionResult Ekle()
        {


            return View();
        }

        public ActionResult Ekle(Personel p)
        {
            PersonelVeriler.listPersoneller.Add(p);

            return RedirectToAction("Listele");
        }
    }
}