// <auto-generated />
using CarStore.WebUI.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarStore.WebUI.Migrations
{
    [DbContext(typeof(EFCarContext))]
    [Migration("20220928192429_first")]
    partial class first
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CarStore.WebUI.Models.Entities.BodyType", b =>
                {
                    b.Property<string>("BodyType1")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("body_type");

                    b.HasKey("BodyType1")
                        .HasName("PK__Body_Typ__5DC6EDB60A71CA35");

                    b.ToTable("Body_Type", (string)null);
                });

            modelBuilder.Entity("CarStore.WebUI.Models.Entities.Brand", b =>
                {
                    b.Property<string>("BrandName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("brand_name");

                    b.HasKey("BrandName")
                        .HasName("PK__Brand__0C0C3B5910D68796");

                    b.ToTable("Brand", (string)null);
                });

            modelBuilder.Entity("CarStore.WebUI.Models.Entities.Car", b =>
                {
                    b.Property<string>("ModelName")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("model_name");

                    b.Property<string>("BodyType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("body_type");

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("brand_name");

                    b.Property<string>("FuelType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("fuel_type");

                    b.Property<string>("TransmissionType")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("transmission_type");

                    b.HasKey("ModelName")
                        .HasName("PK__Car__5DD3F6BAF8D20AEF");

                    b.HasIndex("BodyType");

                    b.HasIndex("BrandName");

                    b.HasIndex("FuelType");

                    b.HasIndex("TransmissionType");

                    b.ToTable("Car", (string)null);
                });

            modelBuilder.Entity("CarStore.WebUI.Models.Entities.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("customer_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"), 1L, 1);

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("customer_name");

                    b.Property<string>("CustomerSurname")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("customer_surname");

                    b.Property<string>("FacebookLink")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("facebook_link");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("phone_number");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer", (string)null);
                });

            modelBuilder.Entity("CarStore.WebUI.Models.Entities.FuelType", b =>
                {
                    b.Property<string>("FuelType1")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("fuel_type");

                    b.HasKey("FuelType1")
                        .HasName("PK__Fuel_Typ__D2CA04354606B6F1");

                    b.ToTable("Fuel_Type", (string)null);
                });

            modelBuilder.Entity("CarStore.WebUI.Models.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("order_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                    b.Property<string>("AdditInfo")
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)")
                        .HasColumnName("addit_info");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int")
                        .HasColumnName("customer_id");

                    b.Property<string>("DeliveryAddress")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("delivery_address");

                    b.Property<string>("ModelName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("model_name");

                    b.HasKey("OrderId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("ModelName");

                    b.ToTable("Order", (string)null);
                });

            modelBuilder.Entity("CarStore.WebUI.Models.Entities.TransmissionType", b =>
                {
                    b.Property<string>("TransmissionType1")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("transmission_type");

                    b.HasKey("TransmissionType1")
                        .HasName("PK__Transmis__99F9313D4AF84CB6");

                    b.ToTable("Transmission_Type", (string)null);
                });

            modelBuilder.Entity("CarStore.WebUI.Models.Entities.Car", b =>
                {
                    b.HasOne("CarStore.WebUI.Models.Entities.BodyType", "BodyTypeNavigation")
                        .WithMany("Cars")
                        .HasForeignKey("BodyType")
                        .IsRequired()
                        .HasConstraintName("FK__Car__body_type__2D27B809");

                    b.HasOne("CarStore.WebUI.Models.Entities.Brand", "BrandNameNavigation")
                        .WithMany("Cars")
                        .HasForeignKey("BrandName")
                        .IsRequired()
                        .HasConstraintName("FK__Car__brand_name__2C3393D0");

                    b.HasOne("CarStore.WebUI.Models.Entities.FuelType", "FuelTypeNavigation")
                        .WithMany("Cars")
                        .HasForeignKey("FuelType")
                        .IsRequired()
                        .HasConstraintName("FK__Car__fuel_type__2F10007B");

                    b.HasOne("CarStore.WebUI.Models.Entities.TransmissionType", "TransmissionTypeNavigation")
                        .WithMany("Cars")
                        .HasForeignKey("TransmissionType")
                        .IsRequired()
                        .HasConstraintName("FK__Car__transmissio__2E1BDC42");

                    b.Navigation("BodyTypeNavigation");

                    b.Navigation("BrandNameNavigation");

                    b.Navigation("FuelTypeNavigation");

                    b.Navigation("TransmissionTypeNavigation");
                });

            modelBuilder.Entity("CarStore.WebUI.Models.Entities.Order", b =>
                {
                    b.HasOne("CarStore.WebUI.Models.Entities.Customer", "Customer")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Orders__customer__34C8D9D1");

                    b.HasOne("CarStore.WebUI.Models.Entities.Car", "ModelNameNavigation")
                        .WithMany("Orders")
                        .HasForeignKey("ModelName")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Orders__model_na__33D4B598");

                    b.Navigation("Customer");

                    b.Navigation("ModelNameNavigation");
                });

            modelBuilder.Entity("CarStore.WebUI.Models.Entities.BodyType", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("CarStore.WebUI.Models.Entities.Brand", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("CarStore.WebUI.Models.Entities.Car", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("CarStore.WebUI.Models.Entities.Customer", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("CarStore.WebUI.Models.Entities.FuelType", b =>
                {
                    b.Navigation("Cars");
                });

            modelBuilder.Entity("CarStore.WebUI.Models.Entities.TransmissionType", b =>
                {
                    b.Navigation("Cars");
                });
#pragma warning restore 612, 618
        }
    }
}
