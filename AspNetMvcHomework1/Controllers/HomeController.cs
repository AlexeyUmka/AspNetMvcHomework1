using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetMvcHomework1.Models;

namespace AspNetMvcHomework1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Guest()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [HttpGet]
        public ActionResult Worksheet()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Worksheet(string inputName, string inputSurname, string inputWishes, string inputBrazil, string inputDance, string inputParty)
        {
            SheetInformation sheet = new SheetInformation();
            sheet.Name = inputName;
            sheet.Surname = inputSurname;
            sheet.Wishes = inputWishes;
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