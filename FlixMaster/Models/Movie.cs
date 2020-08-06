using System.Collections.Generic;
using System;

namespace FlixMaster.Models
{
  public class Movie
  {
    public Movie ()
    {
      this.Showings = new HashSet<MovieShowing>();
    }
    
    public int MovieId {get; set; }
    public string Title {get; set;}
    public string Description {get; set; }
    public string Genre {get; set;}
    public string Rating {get; set; }

    public List<string> Actors {get; set; } = new List<string>();

    public virtual ICollection<MovieShowing> Showings {get; }

  }
}