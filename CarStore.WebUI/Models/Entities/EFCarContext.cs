using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace CarStore.WebUI.Models.Entities
{
    public partial class EFCarContext : DbContext
    {
        public EFCarContext()
        {
        }

        public EFCarContext(DbContextOptions<EFCarContext> options)
            : base(options)
        {
        }

        public virtual DbSet<BodyType> BodyTypes { get; set; } = null!;
        public virtual DbSet<Brand> Brands { get; set; } = null!;
        public virtual DbSet<Car> Cars { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<FuelType> FuelTypes { get; set; } = null!;
        public virtual DbSet<Order> Orders { get; set; } = null!;
        public virtual DbSet<TransmissionType> TransmissionTypes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=vladsfa;Database=Car;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BodyType>(entity =>
            {
                entity.HasKey(e => e.BodyType1)
                    .HasName("PK__Body_Typ__5DC6EDB60A71CA35");

                entity.ToTable("Body_Type");

                entity.Property(e => e.BodyType1)
                    .HasMaxLength(50)
                    .HasColumnName("body_type");
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.HasKey(e => e.BrandName)
                    .HasName("PK__Brand__0C0C3B5910D68796");

                entity.ToTable("Brand");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(50)
                    .HasColumnName("brand_name");
            });

            modelBuilder.Entity<Car>(entity =>
            {
                entity.HasKey(e => e.ModelName)
                    .HasName("PK__Car__5DD3F6BAF8D20AEF");

                entity.ToTable("Car");

                entity.Property(e => e.ModelName)
                    .HasMaxLength(50)
                    .HasColumnName("model_name");

                entity.Property(e => e.BodyType)
                    .HasMaxLength(50)
                    .HasColumnName("body_type");

                entity.Property(e => e.BrandName)
                    .HasMaxLength(50)
                    .HasColumnName("brand_name");

                entity.Property(e => e.FuelType)
                    .HasMaxLength(50)
                    .HasColumnName("fuel_type");

                entity.Property(e => e.TransmissionType)
                    .HasMaxLength(50)
                    .HasColumnName("transmission_type");

                entity.HasOne(d => d.BodyTypeNavigation)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.BodyType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Car__body_type__2D27B809");

                entity.HasOne(d => d.BrandNameNavigation)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.BrandName)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Car__brand_name__2C3393D0");

                entity.HasOne(d => d.FuelTypeNavigation)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.FuelType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Car__fuel_type__2F10007B");

                entity.HasOne(d => d.TransmissionTypeNavigation)
                    .WithMany(p => p.Cars)
                    .HasForeignKey(d => d.TransmissionType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Car__transmissio__2E1BDC42");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .HasColumnName("customer_name");

                entity.Property(e => e.CustomerSurname)
                    .HasMaxLength(50)
                    .HasColumnName("customer_surname");

                entity.Property(e => e.FacebookLink)
                    .HasMaxLength(100)
                    .HasColumnName("facebook_link");

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(50)
                    .HasColumnName("phone_number");
            });

            modelBuilder.Entity<FuelType>(entity =>
            {
                entity.HasKey(e => e.FuelType1)
                    .HasName("PK__Fuel_Typ__D2CA04354606B6F1");

                entity.ToTable("Fuel_Type");

                entity.Property(e => e.FuelType1)
                    .HasMaxLength(50)
                    .HasColumnName("fuel_type");
            });

            modelBuilder.Entity<Order>(entity =>
            {
                entity.ToTable("Order");

                entity.Property(e => e.OrderId).HasColumnName("order_id");

                entity.Property(e => e.AdditInfo)
                    .HasMaxLength(500)
                    .HasColumnName("addit_info");

                entity.Property(e => e.CustomerId).HasColumnName("customer_id");

                entity.Property(e => e.DeliveryAddress)
                    .HasMaxLength(100)
                    .HasColumnName("delivery_address");

                entity.Property(e => e.ModelName)
                    .HasMaxLength(50)
                    .HasColumnName("model_name");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Orders__customer__34C8D9D1");

                entity.HasOne(d => d.ModelNameNavigation)
                    .WithMany(p => p.Orders)
                    .HasForeignKey(d => d.ModelName)
                    .HasConstraintName("FK__Orders__model_na__33D4B598");
            });

            modelBuilder.Entity<TransmissionType>(entity =>
            {
                entity.HasKey(e => e.TransmissionType1)
                    .HasName("PK__Transmis__99F9313D4AF84CB6");

                entity.ToTable("Transmission_Type");

                entity.Property(e => e.TransmissionType1)
                    .HasMaxLength(50)
                    .HasColumnName("transmission_type");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
