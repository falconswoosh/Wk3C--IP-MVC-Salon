using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using HairSalon.Models;

namespace HairSalon.Controllers
{
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        return View();
      }
      [HttpGet("/stylist")]
      public ActionResult AddStylist()
      {
        return View();
      }
      [HttpPost("/stylist/new")]
      public ActionResult NewStylist()
      {
        Stylist newStylist = new Stylist(Request.Form["lastname"], Request.Form["firstname"]);
        newStylist.Save();
        return Redirect("/");
      }
    }
}
