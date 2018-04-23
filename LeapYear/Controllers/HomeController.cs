using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using LeapYear.Models;

namespace LeapYear.Controllers
{
  public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return new EmptyResult();
      }


    }
}
