using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using WordCounter.Models;

namespace WordCounter.Controllers
{
  public class CountersController : Controller
  {
    [HttpGet("/counters/new")]
    public ActionResult New()
    {
      return View();
    }
  }
}
