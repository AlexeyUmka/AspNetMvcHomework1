using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetMvcHomework1.Infrastructure.Data;
using AspNetMvcHomework1.Domain.Core.BasicModels;

namespace AspNetMvcHomework1.Controllers
{
    public class HomeController : Controller
    {
        UnitOfWork unitOfWork;
        public HomeController()
        {
            unitOfWork = new UnitOfWork();
        }
        public ActionResult Index()
        {
            return View(unitOfWork.SimpleArticles.GetElementsOfRepository());
        }
        [HttpGet]
        public ActionResult Guest()
        {
            return View(unitOfWork.SimpleReviews.GetElementsOfRepository());
        }
        [HttpPost]
        public ActionResult Guest(string inputName, string inputReview)
        {
            unitOfWork.SimpleReviews.Create(new SimpleReview() { Name = inputName, ReviewMes = inputReview, PostedAt = DateTime.Now });
            unitOfWork.Save();
            return View(unitOfWork.SimpleReviews.GetElementsOfRepository());
        }
        [HttpGet]
        public ActionResult Worksheet()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Worksheet(string inputName, string inputSurname, string inputWishes, string inputBrazil, string inputDance, string inputParty, string inputGender)
        {
            SimpleSheet sheet = new SimpleSheet()
            {
                Name = inputName,
                Surname = inputSurname,
                Wishes = inputWishes,
                Gender = inputGender,
            };
            if (inputBrazil == "on")
                sheet.Interests.Add("Brazil");
            if (inputDance == "on")
                sheet.Interests.Add("Dancing");
            if (inputParty == "on")
                sheet.Interests.Add("Party");

            return View("WorksheetFilled", sheet);
        }
    }
}