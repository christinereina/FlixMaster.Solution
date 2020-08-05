
namespace FlixMaster.Models
{
  public class MovieShowing
  {
    public int MovieShowingId { get; set;}
    public int MovieId { get; set; }
    public Movie Movie { get; set; }
    public int ShowingId { get; set; }
    public Showing Showing { get; set; }
  }
}

