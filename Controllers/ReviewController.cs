using ProiectFinal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProiectFinal.Controllers
{
    public class ReviewController : Controller
    {
        private MainDBContext context=new MainDBContext();
        // GET: Review
        public ActionResult Index()
        {
            return View(context.Reviews.ToList());
        }

        [HttpGet]
        public ActionResult Create() 
        { 
            ReviewModel review= new ReviewModel();
            return View(review);
        }

        [HttpPost]
        public ActionResult Create(ReviewModel review)
        {
            context.Reviews.Add(review);
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Sort() 
        {
            var res = from r in context.Reviews
                      orderby r.NumberOfStars
                      select r;
            return View(res);
        }
    }
}