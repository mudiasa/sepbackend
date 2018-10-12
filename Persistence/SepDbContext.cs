using Microsoft.EntityFrameworkCore;
using sepbackend.Core.Models;

namespace sepbackend.Persistence
{
    public class SepDbContext : DbContext
    {
        public SepDbContext(DbContextOptions<SepDbContext> options)
            : base(options)
        {
        }

        public DbSet<Client> Clients { get; set; }
    }
}