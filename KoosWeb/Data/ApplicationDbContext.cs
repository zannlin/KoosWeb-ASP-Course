﻿using KoosWeb.Models;
using Microsoft.EntityFrameworkCore;

namespace KoosWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
                .HasData(
                    new Category { Id = 1, Name = "Electronics", DisplayOrder = 1 },
                    new Category { Id = 2, Name = "Books", DisplayOrder = 2 },
                    new Category { Id = 3, Name = "Clothing", DisplayOrder = 3 }
                );
        }
    }
}
