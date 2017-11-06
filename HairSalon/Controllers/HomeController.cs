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
        List<Stylist> allStylists = Stylist.GetAll();
        return View(allStylists);
      }
    //   [HttpGet("/stylist/view")]
    //   public ActionResult ViewStylist()
    //   {
    //     List<Stylist> allStylists = Stylist.GetAll();
    //     return View(allStylists);
    //   }
      [HttpGet("/stylist/new")]
      public ActionResult AddStylist()
      {
        return View();
      }
      [HttpPost("/stylist")]
      public ActionResult NewStylist()
      {
        Stylist newStylist = new Stylist(Request.Form["lastname"], Request.Form["firstname"]);
        newStylist.Save();
        return Redirect("/");
      }
      [HttpGet("/stylist/{id}")]
      public ActionResult StylistDetail(int id)
      {
        List<Stylist> allStylists = Stylist.GetAll();
        Stylist foundStylist = Stylist.Find(id);
        return View(foundStylist);
      }
      [HttpGet("/stylist/clear")]
      public ActionResult ClearAll()
      {
        Stylist.ClearAll();
        return Redirect("/");
      }
    }
}
