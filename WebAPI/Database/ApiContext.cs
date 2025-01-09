using Microsoft.EntityFrameworkCore;

namespace WebAPI.Database
{
    public class ApiContext : DbContext
    {
        public DbSet<WeatherForecast> WeatherForecasts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) => optionsBuilder.UseSqlite("DataSource=forecast.db");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<WeatherForecast>().HasKey(x => x.Id);
            base.OnModelCreating(modelBuilder);
        }
    }
}
