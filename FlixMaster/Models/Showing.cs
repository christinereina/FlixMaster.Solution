using System.Collections.Generic;
using System;
using System.ComponentModel;

namespace FlixMaster.Models
{
  public class Showing
  {
    public Showing() {
      this.Movies = new HashSet<MovieShowing>();
    }
    public int ShowingId { get; set; }

    [DisplayName("Date:")]
    public DateTime ShowingDate { get; set; }

    [DisplayName("Time:")]
    public DateTime ShowingTime { get; set; }
    public virtual ICollection<MovieShowing> Movies { get; set; }
  }
}