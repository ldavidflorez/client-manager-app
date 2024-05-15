using Microsoft.EntityFrameworkCore;

namespace MyWebApi.Models
{
    public class ClientContext : DbContext
    {
        public ClientContext(DbContextOptions<ClientContext> options) : base(options)
        {

        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<AppUser> AppUsers { get; set; } 
    }
}
