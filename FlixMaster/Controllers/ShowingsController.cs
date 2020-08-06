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
    public ActionResult Index(int id)
    {
      var thisShowing = _db.Showings
      .Include(showing => showing.Movies)
      .ThenInclude(join => join.Movie)
      .FirstOrDefault(showing => showing.ShowingId == id);
      return View(thisShowing);
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