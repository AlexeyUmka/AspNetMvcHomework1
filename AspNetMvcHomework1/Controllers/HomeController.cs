using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspNetMvcHomework1.Infrastructure.Data;
using AspNetMvcHomework1.Domain.Core.BasicModels;
using AspNetMvcHomework1.Models;
using AspNetMvcHomework1.Models.VoteSystem;
using AspNetMvcHomework1.Domain.Core.BasicModels.VoteSystem;
using AspNetMvcHomework1.Models.Pagination;
using System.Data.Entity;

namespace AspNetMvcHomework1.Controllers
{
    public class HomeController : Controller
    {
        UnitOfWork unitOfWork;
        ArticleList articleList;
        ElementsOfVoteSystemList elementsOfVoteSystemList;
        public HomeController()
        {
            unitOfWork = new UnitOfWork();
            articleList = new ArticleList();
            elementsOfVoteSystemList = new ElementsOfVoteSystemList();
            elementsOfVoteSystemList.Votes.AddVoteFromDB((unitOfWork.GetBlogContext().Votes.Include(m => m.Voter).Include(m => m.Voting)).ToList());
            ViewBag.ElementsOfVoteSystemList = elementsOfVoteSystemList;
        }
        [HttpPost]
        public ActionResult Vote(string inputVote, int votingID, int voterID)
        {
            bool f = false;
            foreach (var w in unitOfWork.Votings.GetElement(votingID).Options.Split(','))
            {
                if (w == inputVote)
                {
                    f = true;
                    break;
                }
            }
            if (f)
            {
                unitOfWork.Votes.Create(new Vote() { VoterID = voterID, VotingID = votingID, SelectedOption = inputVote });
                unitOfWork.Save();
            }
            else
                ModelState.AddModelError("inputVote", "INVALID VOTE");
            return RedirectToActionPermanent("Index");
        }
        public ActionResult Index(int page = 1)
        {
            ViewBag.CurrentAction = "Home/Index";
            int pageSize = 5; // количество объектов на страницу
            articleList.Articles.AddSimpleArticles(unitOfWork.SimpleArticles.GetElementsOfRepository());
            IEnumerable<Article> articlesPerPages = articleList.Articles.Skip((page - 1) * pageSize).Take(pageSize);
            PageInfo pageInfo = new PageInfo { PageNumber = page, PageSize = pageSize, TotalItems = articleList.Articles.Count };
            articleList.Articles = articlesPerPages.ToList();
            IndexViewModel ivm = new IndexViewModel { PageInfo = pageInfo, ArticleList = articleList };
            return View(ivm);
        }
        [HttpPost]
        public ActionResult Article(int articleID)
        {
            articleList.Articles.AddSimpleArticle(unitOfWork.SimpleArticles.GetElement(articleID));
            return View(articleList.Articles.Last());
        }
        [HttpGet]
        public ActionResult Guest()
        {
            return View(unitOfWork.SimpleReviews.GetElementsOfRepository());
        }
        [HttpPost]
        public ActionResult Guest(string inputName, string inputReview, DateTime PostedAt)
        {
            SimpleReview simpleReview = new SimpleReview { Name = inputName.Replace(" ", ""), ReviewMes = inputReview.Replace(" ", ""), PostedAt = PostedAt };
            if (TryValidateModel(simpleReview))
            {
                unitOfWork.SimpleReviews.Create(simpleReview);
                unitOfWork.Save();
            }
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
                Name = inputName.Replace(" ", ""),
                Surname = inputSurname.Replace(" ", ""),
                Wishes = inputWishes.Replace(" ", ""),
                Gender = inputGender,
            };
            if (inputBrazil == "on")
                sheet.Interests.Add("Brazil");
            if (inputDance == "on")
                sheet.Interests.Add("Dancing");
            if (inputParty == "on")
                sheet.Interests.Add("Party");
            if (TryValidateModel(sheet))
                return View("WorksheetFilled", sheet);
            else return View();
        }
    }
}