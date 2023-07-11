using KahveOneriSitesi.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KahveOneriSitesi.Controllers
{
    public class SizdenGelenler : Controller
    {
        OneriRepository oneriRepository = new OneriRepository();
        public IActionResult Index()
        {
            return View(oneriRepository.TList());
        }
        [HttpGet]
        public IActionResult OneriEkle()
        {
            return View();
        }
        [HttpPost]
        public IActionResult OneriEkle(Data.Models.Oneri p)
        {
            oneriRepository.TAdd(p);
            return RedirectToAction("Index");
        }
        public IActionResult OneriSil(int id)
        {
            oneriRepository.TDelete(new Data.Models.Oneri { OneriID = id });
            return RedirectToAction("Index");
        }

        public IActionResult OneriGet(int id)
        {
            var x = oneriRepository.TGet(id);
            Data.Models.Oneri ct = new()
            {
                OneriID = x.OneriID,
                OneriAd = x.OneriAd,
                OneriMalzeme = x.OneriMalzeme,
                OneriTarif = x.OneriTarif,
                OneriTarih = x.OneriTarih,
                OneriTur = x.OneriTur,
                OneriResim = x.OneriResim,
                OnerenAdSoyad=x.OnerenAdSoyad,
                OneriDurum =x.OneriDurum
            };
            return View(ct);
        }

        [HttpPost]
        public IActionResult OneriGuncelle(Data.Models.Oneri p)
        {
            var x = oneriRepository.TGet(p.OneriID);
            x.OneriAd = p.OneriAd;
            x.OneriMalzeme = p.OneriMalzeme;
            x.OneriTarif = p.OneriTarif;
            x.OneriTarih = p.OneriTarih;
            x.OneriResim = p.OneriResim;
            x.OneriTur = p.OneriTur;
            x.OnerenAdSoyad = p.OnerenAdSoyad;
            x.OneriDurum = p.OneriDurum;
            oneriRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
        public IActionResult OneriDurumTrue(int id)
        {
            var x = oneriRepository.TGet(id);
            x.OneriDurum = true;
            oneriRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
        public IActionResult OneriDurumFalse(int id)
        {
            var x = oneriRepository.TGet(id);
            x.OneriDurum = false;
            oneriRepository.TUpdate(x);
            return RedirectToAction("Index");
        }
        [AllowAnonymous]
        public IActionResult SizdenGelenlerWeb()
        {
            OneriRepository oneriRepository = new OneriRepository();
            var onerilistele = oneriRepository.List(x => x.OneriDurum == true);
            return View(onerilistele);
        }
        [AllowAnonymous]
        public IActionResult OneriBegen(int id)
        {
            if(!HttpContext.Session.TryGetValue($"oneriBegen-{id}", out byte[] _))
    {
                var x = oneriRepository.TGet(id);
                x.OneriBegeni++;
                oneriRepository.TUpdate(x);

                HttpContext.Session.Set($"oneriBegen-{id}", Encoding.UTF8.GetBytes("begenildi"));
            }

            return RedirectToAction("SizdenGelenlerWeb");
        }
        [AllowAnonymous]
        public IActionResult OneriBegenme(int id)
        {
            if (!HttpContext.Session.TryGetValue($"oneriBegen-{id}", out byte[] _))
            {
                var x = oneriRepository.TGet(id);
                x.OneriBegeni--;
                oneriRepository.TUpdate(x);

                HttpContext.Session.Set($"oneriBegen-{id}", Encoding.UTF8.GetBytes("begenildi"));
            }

            return RedirectToAction("SizdenGelenlerWeb");
        }

    }
}
