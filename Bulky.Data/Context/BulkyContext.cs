using BulkyWeb.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bulky.Data.Context
{
    public class BulkyContext: DbContext
    {
        public BulkyContext(DbContextOptions<BulkyContext> options):base(options) {
        
        }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(new Category()
            {
                Id = 1,
                Name = "Action",
                DisplayOrder = 1
            });

        }
    }
}
