using AspNetCore8._0DinamikPortfolyoProjesi2024.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore8._0DinamikPortfolyoProjesi2024.Controllers
{
    public class UrunController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Urunler()
        {
            var urun = new UrunModel();
            urun.UrunId = 1;
            urun.UrunAdi = "Bilgisayar";
            urun.UrunAciklama = "I7 8GB RAM 2 GB Nvidia Ekran Kartı";
            urun.UrunFiyat = 20000;
            urun.UrunAdedi = 10;
            return View(urun);
        }

        public IActionResult UrunListesi() {

            var urunListesi = new List<UrunModel>{

                new UrunModel() { UrunId = 1,UrunAdi="Ütü",UrunAciklama="Tefal",UrunFiyat=5000,UrunAdedi=2},
                new UrunModel() { UrunId = 2,UrunAdi="Robot Süpürge",UrunAciklama="Mi",UrunFiyat=15000,UrunAdedi=12},
                new UrunModel() { UrunId = 3,UrunAdi="TV",UrunAciklama="Vestel",UrunFiyat=12000,UrunAdedi=7},
                new UrunModel() { UrunId = 4,UrunAdi="Buzdolabı",UrunAciklama="Samsung",UrunFiyat=25000,UrunAdedi=32}

            };

            return View(urunListesi);
        }
    }
}
