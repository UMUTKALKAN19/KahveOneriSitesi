using KahveOneriSitesi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KahveOneriSitesi.Controllers
{
    public class Anasayfa : Controller
    {
        KahveRepository kahveRepository = new KahveRepository();
        public IActionResult Index()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult WebAnaSayfa()
        {
            return View();
        }
    }
}
