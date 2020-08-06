using Microsoft.AspNetCore.Mvc;
using FlixMaster.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace FlixMaster.Controllers
{
  public class MoviesController : Controller
  {
    private readonly FlixMasterContext _db;

    public MoviesController(FlixMasterContext db)
    {
      _db = db; 
    }

    public ActionResult Index ()
    {
      return View (_db.Movies.ToList());
    }

    public ActionResult Create ()
    {
      ViewBag.ShowingId = new SelectList(_db.Showings, "ShowingsId", "ShowingDate");
      return View();
    }

    [HttpPost]
    public ActionResult Create (Movie movie, int ShowingId)
    {
      _db.Movies.Add(movie);
      if (ShowingId != 0)
      {
        _db.MovieShowing.Add(new MovieShowing() {ShowingId = ShowingId, MovieId = movie.MovieId });
      }
      _db.SaveChanges(); 
      return RedirectToAction("Index");
    }
  }
}