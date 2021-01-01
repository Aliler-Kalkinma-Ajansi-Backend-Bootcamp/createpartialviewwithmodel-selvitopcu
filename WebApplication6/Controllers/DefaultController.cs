using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication6.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Kategoriler(Models.Kategorilerim bilgi)
        {
            var bil = new Models.Kategorilerim();
            bil.KatAdi = "renkler";
            bil.KatAciklama = "sogukrenkler";
            bil.KatDetaylari = "soguk ve sicak renkler vardir";
            bil.Numarasi = 101;

            return View(bil);

           
        }
    }
}