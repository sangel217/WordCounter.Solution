using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class CountersController : Controller
  {

    [HttpGet("/counters")]
    public ActionResult Index(string word, string sentence)
    {
      Counter newCounter = new Counter(word, sentence);
      return View(newCounter);
    }

    [HttpGet("/counters/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/counters")]
    public ActionResult Create(string word, string sentence)
    {
      Counter newCounter = new Counter(word, sentence);
      return View("Index", newCounter);
    }
  }
}
