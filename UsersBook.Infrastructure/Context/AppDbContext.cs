using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using UsersBook.Domain.Entities;

namespace UsersBook.Infrastructure.Context
{
    public class AppDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public AppDbContext(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_configuration.GetConnectionString("ServerConection"));
        }
    }
}
