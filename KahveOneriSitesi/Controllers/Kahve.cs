using KahveOneriSitesi.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KahveOneriSitesi.Data.Models;

namespace KahveOneriSitesi.Controllers
{
    public class Kahve : Controller
    {
        KahveRepository kahveRepository = new KahveRepository();
        public IActionResult Index()
        {
            return View(kahveRepository.TList());
        }
        [HttpGet]
        public IActionResult KahveEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult KahveEkle(Data.Models.Kahve p)
        {
            kahveRepository.TAdd(p);
            return RedirectToAction("Index");
        }

        public IActionResult KahveSil(int id)
        {
            kahveRepository.TDelete(new Data.Models.Kahve { KahveID=id});
            return RedirectToAction("Index");
        }

        public IActionResult KahveGet(int id)
        {
            var x = kahveRepository.TGet(id);
            Data.Models.Kahve ct = new()
            {
                KahveID = x.KahveID,
                KahveAd = x.KahveAd,
                KahveMalzeme = x.KahveMalzeme,
                KahveTarif = x.KahveTarif,
                KahveTarih = x.KahveTarih,
                KahveTur = x.KahveTur,
                KahveResim = x.KahveResim,
            };
            return View(ct);
        }

        [HttpPost]
        public IActionResult KahveGuncelle(Data.Models.Kahve p)
        {
            var x = kahveRepository.TGet(p.KahveID);
            x.KahveAd = p.KahveAd;
            x.KahveMalzeme = p.KahveMalzeme;
            x.KahveTarif = p.KahveTarif;
            x.KahveTarih = p.KahveTarih;
            x.KahveResim = p.KahveResim;
            x.KahveTur = p.KahveTur;
            kahveRepository.TUpdate(x);
            return RedirectToAction("Index");
        }

    }
}
