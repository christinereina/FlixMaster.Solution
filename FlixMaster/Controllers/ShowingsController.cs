using Microsoft.AspNetCore.Mvc;
using FlixMaster.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FlixMaster.Controllers
{
  public class ShowingsController : Controller
  {
    private readonly FlixMasterContext _db;

    public ShowingsController(FlixMasterContext db)
    {
    _db = db;
    }
    public ActionResult Index()
    {
      var model = _db.MovieShowing.ToList();
      ViewBag.Showings = _db.Showings.ToList();
      ViewBag.Movies = _db.Movies.ToList();
      return View(model);
    }
    
    public ActionResult Create()
    {
      ViewBag.MovieId = new SelectList (_db.Movies, "MovieId", "Title"); //MovieID associates with specific instance of movie - title associates with that specific field
      ViewBag.Rating = new SelectList (_db.Movies, "MovieId", "Rating");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Showing showing)
    {
      _db.Showings.Add(showing);
      _db.SaveChanges();
      return RedirectToAction("Index");
    }
  }
}