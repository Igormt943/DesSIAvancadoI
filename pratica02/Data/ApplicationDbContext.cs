using Microsoft.EntityFrameworkCore;
using pratica02.Models;

namespace pratica02.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Carro> Carros { get; set; }
    }
}
