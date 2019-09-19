using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetMvcHomework1.Models;

namespace AspNetMvcHomework1.Controllers
{
    public static class ReviewsRepository
    {
        public static List<Review> reviews = new List<Review>();
    }
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Guest()
        {
            return View(ReviewsRepository.reviews);
        }
        [HttpPost]
        public ActionResult Guest(string inputName, string inputReview)
        {
            ReviewsRepository.reviews.Insert(0,new Review(inputName, inputReview));
            return View(ReviewsRepository.reviews);
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