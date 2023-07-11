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
    public class MesajAt : Controller
    {
        MesajlarRepository mesajlarRepository = new MesajlarRepository();
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MesajEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult MesajEkle(Data.Models.Mesajlar model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index");
            }
            mesajlarRepository.TAdd(model);
            return RedirectToAction("Index");
        }

    }
}
