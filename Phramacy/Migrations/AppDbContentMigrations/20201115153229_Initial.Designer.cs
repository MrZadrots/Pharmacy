// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Phramacy.src;

namespace Phramacy.Migrations.AppDbContentMigrations
{
    [DbContext(typeof(AppDbContent))]
    [Migration("20201115153229_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Phramacy.src.Model.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.Property<string>("Desc");

                    b.HasKey("id");

                    b.ToTable("Category_Db");
                });

            modelBuilder.Entity("Phramacy.src.Model.Order", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("SurName")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("adress")
                        .IsRequired()
                        .HasMaxLength(35);

                    b.Property<string>("email")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<DateTime>("orderTime");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasMaxLength(11);

                    b.HasKey("id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("Phramacy.src.Model.OrderDetail", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ProductID");

                    b.Property<int>("orderID");

                    b.Property<long>("price");

                    b.HasKey("id");

                    b.HasIndex("ProductID");

                    b.HasIndex("orderID");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("Phramacy.src.Model.Product", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<bool>("IsFavourite");

                    b.Property<int>("available");

                    b.Property<string>("img");

                    b.Property<string>("longDec");

                    b.Property<string>("name");

                    b.Property<int>("price");

                    b.Property<DateTime>("shelf_life");

                    b.Property<string>("shortDec");

                    b.HasKey("id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Product_Db");
                });

            modelBuilder.Entity("Phramacy.src.Model.ShopCartItem", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ShopCartId");

                    b.Property<string>("name");

                    b.Property<int>("pric");

                    b.Property<int?>("productid");

                    b.HasKey("id");

                    b.HasIndex("productid");

                    b.ToTable("ShopCartItem");
                });

            modelBuilder.Entity("Phramacy.src.Model.OrderDetail", b =>
                {
                    b.HasOne("Phramacy.src.Model.Product", "product")
                        .WithMany()
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Phramacy.src.Model.Order", "order")
                        .WithMany("orderDetails")
                        .HasForeignKey("orderID")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Phramacy.src.Model.Product", b =>
                {
                    b.HasOne("Phramacy.src.Model.Category", "Category")
                        .WithMany("products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Phramacy.src.Model.ShopCartItem", b =>
                {
                    b.HasOne("Phramacy.src.Model.Product", "product")
                        .WithMany()
                        .HasForeignKey("productid");
                });
#pragma warning restore 612, 618
        }
    }
}
