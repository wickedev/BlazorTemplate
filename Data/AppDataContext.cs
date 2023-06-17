using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using BlazorTemplate.Data;

#pragma warning disable CS8618
public class AppDataContext : IdentityDbContext
{
    public AppDataContext(DbContextOptions<AppDataContext> options)
         : base(options)
    {
    }

    public DbSet<WeatherForecast> WeatherForecasts { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        var Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        var startDate = DateTime.UtcNow;

        modelBuilder.Entity<WeatherForecast>().ToTable("forecasts");
        modelBuilder.Entity<WeatherForecast>().HasData(
            Enumerable.Range(1, 50).Select(index => new WeatherForecast
            {
                Id = index,
                DateTimeAt = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }
        ));
    }

}
#pragma warning restore CS8618