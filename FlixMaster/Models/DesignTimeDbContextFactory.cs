using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace FlixMaster.Models
{
  public class FlixMasterContextFactory : IDesignTimeDbContextFactory<FlixMasterContext>
  {

    FlixMasterContext IDesignTimeDbContextFactory<FlixMasterContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<FlixMasterContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new FlixMasterContext(builder.Options);
    }
  }
}