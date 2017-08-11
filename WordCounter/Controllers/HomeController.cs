using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
    public class HomeController : Controller
    {

        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost("/wordcounter/results")]
        public ActionResult Results()
        {
          RepeatCounter newCount = new RepeatCounter(Request.Form["new-sentence"], Request.Form["count-word"]);
          int totalCount = newCount.CountRepeats();
          return View(totalCount);
        }
    }
}
