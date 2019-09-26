using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetMvcHomework1.Models;
using AspNetMvcHomework1.Infrastructure.Data.Contexts;
using AspNetMvcHomework1.Infrastructure.Data.Repositories;
using AspNetMvcHomework1.Domain.Core.BasicModels;

namespace AspNetMvcHomework1.Controllers
{
    public class HomeController : Controller
    {
        SimpleArticleRepository ar = new SimpleArticleRepository();
        SimpleReviewRepository rc = new SimpleReviewRepository();
        public ActionResult Index()
        {
            return View(ar.GetElementsOfRepository());
        }
        [HttpGet]
        public ActionResult Guest()
        {
            return View(rc.GetElementsOfRepository());
        }
        [HttpPost]
        public ActionResult Guest(string inputName, string inputReview)
        {
            rc.Create(new SimpleReview() { Name = inputName, ReviewMes = inputReview, PostedAt = DateTime.Now });
            rc.Save();
            return View(rc.GetElementsOfRepository());
        }
        [HttpGet]
        public ActionResult Worksheet()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Worksheet(string inputName, string inputSurname, string inputWishes, string inputBrazil, string inputDance, string inputParty,string inputGender)
        {
            SheetInformation sheet = new SheetInformation();
            sheet.Name = inputName;
            sheet.Surname = inputSurname;
            sheet.Wishes = inputWishes;
            sheet.Gender = inputGender;
            if(inputBrazil == "on")
            sheet.Interests.Add("Brazil");
            if(inputDance == "on")
            sheet.Interests.Add("Dancing");
            if(inputParty == "on")
            sheet.Interests.Add("Party");
            
            return View("WorksheetFilled", sheet);
        }
    }
}