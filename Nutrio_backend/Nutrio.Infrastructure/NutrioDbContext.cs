using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Nutrio.Domain.Entities;

namespace Nutrio.Infrastructure
{
    public class NutrioDbContext : DbContext
    {
        public NutrioDbContext(DbContextOptions<NutrioDbContext> options) : base(options)
        {
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<DayCounter> DayCounters { get; set; }
        public DbSet<Bodymetrix> BodymetrixRecords { get; set; }

    

    protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Users
            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(u => u.Id);

                entity.Property(u => u.Email)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.HasIndex(u => u.Email)
                    .IsUnique();

                entity.Property(u => u.Name).HasMaxLength(50);
                entity.Property(u => u.LastName).HasMaxLength(50);
                entity.Property(u => u.PasswordHash).IsRequired(false);
                entity.Property(u => u.RefreshToken).HasMaxLength(500);

                entity.Property(u => u.Weight).HasPrecision(5, 2); 
                entity.Property(u => u.Height).HasPrecision(5, 2);
            });

            // Products
            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasKey(p => p.Id);

                entity.Property(p => p.ProductName)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(p => p.Calories).HasPrecision(10, 2);
                entity.Property(p => p.Protein).HasPrecision(10, 2);
                entity.Property(p => p.Fat).HasPrecision(10, 2);
                entity.Property(p => p.Carbs).HasPrecision(10, 2);
                entity.Property(p => p.Fiber).HasPrecision(10, 2);
            });

            // DayCounter
            modelBuilder.Entity<DayCounter>(entity =>
            {
                entity.HasKey(d => d.Id);

                // Users conection
                entity.HasOne(d => d.User)
                    .WithMany(u => u.DayCounters)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade); 

                // Products conection
                entity.HasOne(d => d.Product)
                    .WithMany() // У продукту немає колекції DayCounters (це нормально)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Restrict); 

                entity.Property(d => d.Quantity).HasPrecision(10, 2);

                entity.Property(d => d.TypeMeal)
                    .HasConversion<string>();
            });

            // Bodymetrix
            modelBuilder.Entity<Bodymetrix>(entity =>
            {
                entity.HasKey(b => b.Id);

                entity.HasOne(b => b.User)
                    .WithMany(u => u.BodymetrixRecords)
                    .HasForeignKey(b => b.UserId)
                    .OnDelete(DeleteBehavior.Cascade);


            });

            //тестові дані для продуктів
            
         }

    }
} 