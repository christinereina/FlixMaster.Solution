using Microsoft.EntityFrameworkCore;

namespace FlixMaster.Models
{
  public class FlixMasterContext : DbContext
  {
    public virtual DbSet<Showing> Showings { get; set; }
    public DbSet<Movie> Movies { get; set; }
    public DbSet<MovieShowing> MovieShowing {get; set; }
    
    public FlixMasterContext(DbContextOptions options) : base(options) { }
  }
}