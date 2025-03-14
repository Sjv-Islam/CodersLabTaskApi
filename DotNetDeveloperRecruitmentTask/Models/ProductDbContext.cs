﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using DotNetDeveloperRecruitmentTask.Models;

namespace DotNetDeveloperRecruitmentTask.Models
{
    public class ProductDbContext : IdentityDbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Variant> Variants { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public ProductDbContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUserLogin<string>>()
            .HasKey(u => new { u.UserId, u.LoginProvider, u.ProviderKey });

            modelBuilder.Entity<IdentityUserRole<string>>()

            .HasKey(r => new { r.UserId, r.RoleId });



            modelBuilder.Entity<Product>().HasData(new Product[]
            {
                new Product
                {
                    Id = 1,
                    Name = "Excel",
                    Brand = "Sharif",
                    Type = ProductType.Mug
                },
                new Product
                {
                    Id = 2,
                    Name = "Centre",
                    Brand = "N Mohammad",
                    Type = ProductType.Jug
                },
                new Product
                {
                    Id = 3,
                    Name = "Lime",
                    Brand = "Unique",
                    Type = ProductType.Glass
                },

            });


            modelBuilder.Entity<Variant>().HasData(new Variant[]
           {
                new Variant
                {
                    Id = 1,
                    Color = "Red",
                    Specification = "Standard",
                    Size = Size.Large,
                    ProductId = 1,
                },
               new Variant
                {
                    Id = 2,
                    Color = "Purple",
                    Specification = "Special",
                    Size = Size.Medium,
                    ProductId = 1,
                },
               new Variant
                {
                    Id = 3,
                    Color = "Blue",
                    Specification = "Printed",
                    Size = Size.Medium,
                    ProductId = 2,
                },
               new Variant
                {
                    Id = 4,
                    Color = "Black",
                    Specification = "Plain",
                    Size = Size.Large,
                    ProductId = 2,
                },
               new Variant
                {
                    Id = 5,
                    Color = "White",
                    Specification = "Plain",
                    Size = Size.Small,
                    ProductId = 3,
                },
               new Variant
                {
                    Id = 6,
                    Color = "Blue",
                    Specification = "Printed",
                    Size = Size.Medium,
                    ProductId = 3,
                },


           });

        }
        public DbSet<DotNetDeveloperRecruitmentTask.Models.Order> Order { get; set; } = default!;
    }
}
