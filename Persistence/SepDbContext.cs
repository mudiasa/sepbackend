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
        public DbSet<Request> Requests { get; set; }
        public DbSet<Preference> Preferences { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Event> Events { get; set; }
    }
}