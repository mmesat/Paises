﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Paises.Data;

#nullable disable

namespace Paises.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20230318130107_ajusteCampos")]
    partial class ajusteCampos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.15")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Paises.Entity.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Code")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Language")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Paises.Entity.CountryHotel", b =>
                {
                    b.Property<int>("IdHotel")
                        .HasColumnType("int");

                    b.Property<int>("IdCountry")
                        .HasColumnType("int");

                    b.HasKey("IdHotel", "IdCountry");

                    b.HasIndex("IdCountry");

                    b.ToTable("CountryHotel");
                });

            modelBuilder.Entity("Paises.Entity.CountryRestaurant", b =>
                {
                    b.Property<int>("IdRestaurant")
                        .HasColumnType("int");

                    b.Property<int>("IdCountry")
                        .HasColumnType("int");

                    b.HasKey("IdRestaurant", "IdCountry");

                    b.HasIndex("IdCountry");

                    b.ToTable("countryRestaurants");
                });

            modelBuilder.Entity("Paises.Entity.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Hotels");
                });

            modelBuilder.Entity("Paises.Entity.Restaurant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Restaurants");
                });

            modelBuilder.Entity("Paises.Entity.CountryHotel", b =>
                {
                    b.HasOne("Paises.Entity.Country", "country")
                        .WithMany("CountryHotels")
                        .HasForeignKey("IdCountry")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Paises.Entity.Hotel", "hotel")
                        .WithMany("CountryHotels")
                        .HasForeignKey("IdHotel")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("country");

                    b.Navigation("hotel");
                });

            modelBuilder.Entity("Paises.Entity.CountryRestaurant", b =>
                {
                    b.HasOne("Paises.Entity.Country", "country")
                        .WithMany("CountryRestaurants")
                        .HasForeignKey("IdCountry")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Paises.Entity.Restaurant", "restaurant")
                        .WithMany("CountryRestaurants")
                        .HasForeignKey("IdRestaurant")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("country");

                    b.Navigation("restaurant");
                });

            modelBuilder.Entity("Paises.Entity.Country", b =>
                {
                    b.Navigation("CountryHotels");

                    b.Navigation("CountryRestaurants");
                });

            modelBuilder.Entity("Paises.Entity.Hotel", b =>
                {
                    b.Navigation("CountryHotels");
                });

            modelBuilder.Entity("Paises.Entity.Restaurant", b =>
                {
                    b.Navigation("CountryRestaurants");
                });
#pragma warning restore 612, 618
        }
    }
}