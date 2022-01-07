using Microsoft.EntityFrameworkCore;

namespace MovieApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Movie> Movie { get; set; }
    }
}
