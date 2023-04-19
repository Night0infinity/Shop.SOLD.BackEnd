using Microsoft.EntityFrameworkCore;
using Shop.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Components for work with database
namespace Shop.DAL
{
    internal class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
    
        }
        public DbSet<Product> Product { get; set; } //creature
    }

}
