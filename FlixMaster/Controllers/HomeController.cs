using Microsoft.AspNetCore.Mvc;
using FlixMaster.Models;
using System.Collections.Generic;

namespace FlixMaster.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}