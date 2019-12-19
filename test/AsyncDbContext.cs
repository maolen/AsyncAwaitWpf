using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    public class AsyncDbContext : DbContext
    {
        public AsyncDbContext()
        {
            Database.EnsureCreated();
        }
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=A-104-14;Database=AsyncDatabase332;Trusted_Connection=true;");
        }
    }
}
