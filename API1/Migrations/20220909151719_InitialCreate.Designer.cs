// <auto-generated />
using System;
using ContosoPizza.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace API1.Migrations
{
    [DbContext(typeof(PizzaContext))]
    [Migration("20220909151719_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.8");

            modelBuilder.Entity("API1.Models.Pizza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("SauceId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SauceId");

                    b.ToTable("Pizzas");
                });

            modelBuilder.Entity("API1.Models.Sauce", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Sauces");
                });

            modelBuilder.Entity("API1.Models.Topping", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("PizzaId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("PizzaId");

                    b.ToTable("Toppings");
                });

            modelBuilder.Entity("API1.Models.Pizza", b =>
                {
                    b.HasOne("API1.Models.Sauce", "Sauce")
                        .WithMany()
                        .HasForeignKey("SauceId");

                    b.Navigation("Sauce");
                });

            modelBuilder.Entity("API1.Models.Topping", b =>
                {
                    b.HasOne("API1.Models.Pizza", null)
                        .WithMany("Toppings")
                        .HasForeignKey("PizzaId");
                });

            modelBuilder.Entity("API1.Models.Pizza", b =>
                {
                    b.Navigation("Toppings");
                });
#pragma warning restore 612, 618
        }
    }
}
