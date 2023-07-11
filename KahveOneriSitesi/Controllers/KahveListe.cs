using KahveOneriSitesi.Data.Models;
using KahveOneriSitesi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KahveOneriSitesi.Controllers
{
    [AllowAnonymous]
    public class KahveListe : Controller
    {
        KahveRepository kahveRepository = new KahveRepository();
        Context c = new Context();
        public IActionResult Index()
        {
            return View(kahveRepository.TList());
        }

        public IActionResult KahveDetay(int id)
        {
            //@ViewBag.id = id;
            return View(kahveRepository.List(x => x.KahveID == id));
        }
    }
}
