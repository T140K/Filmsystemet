using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;

namespace Filmsystem.Models
{
    public class FilmsystemContext : DbContext
    {
        public FilmsystemContext(DbContextOptions<FilmsystemContext> options)
            : base(options)
        {
            
        }

        public DbSet<Movie> Movie { get; set; }
    }
}
