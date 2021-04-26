using Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace Data
{
    public class ContextProducts : DbContext
    {
        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Test1;Integrated Security=True");
        }
    }
}
