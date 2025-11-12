using Microsoft.EntityFrameworkCore;
using SafeRoute.API.Models;

namespace SafeRoute.API.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Pedido> Pedidos { get; set; }
    }
}
