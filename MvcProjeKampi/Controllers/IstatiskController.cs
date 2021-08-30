using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcProjeKampi.Controllers
{
    public class IstatiskController : Controller
    {

        Context c = new Context();

        public ActionResult Index()
        {
            //Toplam Kategori
            var totalCategory = c.Categories.Count();
            ViewBag.CategoryCount = totalCategory;

            //Başlık tablosunda "yazılım" kategorisine ait başlık sayısı
            var numberofTitlesWithSoftwareName = c.Headings.Where(heading => heading.CategoryID == 19).Count().ToString();
            ViewBag.numberofTitlesWithSoftwareName = numberofTitlesWithSoftwareName;

            //Yazar adında "a" harfi geçen yazar sayısı
            var authorsWiththeLetterAinTheirName =  c.Writers.Where(w => w.WriterName.Contains("a") || w.WriterName.Contains("A")).Count();
            ViewBag.authorsWiththeLetterAinTheirName = authorsWiththeLetterAinTheirName;

            var categoryWithTheMostTitles = c.Categories.Where(u => u.CategoryID == c.Headings.GroupBy(x => x.CategoryID).OrderByDescending(x => x.Count())
                 .Select(x => x.Key).FirstOrDefault()).Select(x => x.CategoryName).FirstOrDefault();
            ViewBag.categoryWithTheMostTitles = categoryWithTheMostTitles;

            //Kategori tablosunda durumu true olan kategoriler ile false olan kategoriler arasındaki sayısal fark
            var trueValueCategory = c.Categories.Count(m => m.CategoryStatus == true);
            var falseValueCategory = c.Categories.Count(x=>x.CategoryStatus==false);
            var difference = trueValueCategory - falseValueCategory;
            ViewBag.StatusDiffrerent = difference;


            return View();
        }
    }
}