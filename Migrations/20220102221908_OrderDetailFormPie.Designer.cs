﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PieShop.Models;

namespace PieShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220102221908_OrderDetailFormPie")]
    partial class OrderDetailFormPie
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PieShop.Models.Category", b =>
                {
                    b.Property<int>("CateGoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CateGoryID");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CateGoryID = 1,
                            CategoryName = "Fruit pies"
                        },
                        new
                        {
                            CateGoryID = 2,
                            CategoryName = "Cheese cakes"
                        },
                        new
                        {
                            CateGoryID = 3,
                            CategoryName = "Seasonal pies"
                        });
                });

            modelBuilder.Entity("PieShop.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AddressLine2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("OrderPlaced")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("OrderTotal")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("State")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("PieShop.Models.OrderDetail", b =>
                {
                    b.Property<int>("OderDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<int>("PieID")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OderDetailID");

                    b.HasIndex("OrderID");

                    b.HasIndex("PieID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("PieShop.Models.Pie", b =>
                {
                    b.Property<int>("pieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AllergyInformation")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryID")
                        .HasColumnType("int");

                    b.Property<string>("LongDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("ShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageThumbnailURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("imageURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("inStock")
                        .HasColumnType("bit");

                    b.Property<bool>("isPieOfTheWeek")
                        .HasColumnType("bit");

                    b.HasKey("pieID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Pies");

                    b.HasData(
                        new
                        {
                            pieID = 1,
                            AllergyInformation = "",
                            CategoryID = 1,
                            LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Name = "Apple Pie",
                            Price = 12.95m,
                            ShortDescription = "Our famous apple pies!",
                            imageThumbnailURL = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg",
                            imageURL = "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg",
                            inStock = true,
                            isPieOfTheWeek = true
                        },
                        new
                        {
                            pieID = 2,
                            AllergyInformation = "",
                            CategoryID = 2,
                            LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Name = "Blueberry Cheese Cake",
                            Price = 18.95m,
                            ShortDescription = "You'll love it!",
                            imageThumbnailURL = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecakesmall.jpg",
                            imageURL = "https://gillcleerenpluralsight.blob.core.windows.net/files/blueberrycheesecake.jpg",
                            inStock = true,
                            isPieOfTheWeek = false
                        },
                        new
                        {
                            pieID = 3,
                            AllergyInformation = "",
                            CategoryID = 2,
                            LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Name = "Cheese Cake",
                            Price = 18.95m,
                            ShortDescription = "Plain cheese cake. Plain pleasure.",
                            imageThumbnailURL = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecakesmall.jpg",
                            imageURL = "https://gillcleerenpluralsight.blob.core.windows.net/files/cheesecake.jpg",
                            inStock = true,
                            isPieOfTheWeek = false
                        },
                        new
                        {
                            pieID = 4,
                            AllergyInformation = "",
                            CategoryID = 1,
                            LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Name = "Cherry Pie",
                            Price = 15.95m,
                            ShortDescription = "A summer classic!",
                            imageThumbnailURL = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypiesmall.jpg",
                            imageURL = "https://gillcleerenpluralsight.blob.core.windows.net/files/cherrypie.jpg",
                            inStock = true,
                            isPieOfTheWeek = false
                        },
                        new
                        {
                            pieID = 5,
                            AllergyInformation = "",
                            CategoryID = 3,
                            LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Name = "Christmas Apple Pie",
                            Price = 13.95m,
                            ShortDescription = "Happy holidays with this pie!",
                            imageThumbnailURL = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepiesmall.jpg",
                            imageURL = "https://gillcleerenpluralsight.blob.core.windows.net/files/christmasapplepie.jpg",
                            inStock = true,
                            isPieOfTheWeek = false
                        },
                        new
                        {
                            pieID = 6,
                            AllergyInformation = "",
                            CategoryID = 3,
                            LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Name = "Cranberry Pie",
                            Price = 17.95m,
                            ShortDescription = "A Christmas favorite",
                            imageThumbnailURL = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypiesmall.jpg",
                            imageURL = "https://gillcleerenpluralsight.blob.core.windows.net/files/cranberrypie.jpg",
                            inStock = true,
                            isPieOfTheWeek = false
                        },
                        new
                        {
                            pieID = 7,
                            AllergyInformation = "",
                            CategoryID = 1,
                            LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Name = "Peach Pie",
                            Price = 15.95m,
                            ShortDescription = "Sweet as peach",
                            imageThumbnailURL = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpiesmall.jpg",
                            imageURL = "https://gillcleerenpluralsight.blob.core.windows.net/files/peachpie.jpg",
                            inStock = false,
                            isPieOfTheWeek = false
                        },
                        new
                        {
                            pieID = 8,
                            AllergyInformation = "",
                            CategoryID = 3,
                            LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Name = "Pumpkin Pie",
                            Price = 12.95m,
                            ShortDescription = "Our Halloween favorite",
                            imageThumbnailURL = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpiesmall.jpg",
                            imageURL = "https://gillcleerenpluralsight.blob.core.windows.net/files/pumpkinpie.jpg",
                            inStock = true,
                            isPieOfTheWeek = true
                        },
                        new
                        {
                            pieID = 9,
                            AllergyInformation = "",
                            CategoryID = 1,
                            LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Name = "Rhubarb Pie",
                            Price = 15.95m,
                            ShortDescription = "My God, so sweet!",
                            imageThumbnailURL = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpiesmall.jpg",
                            imageURL = "https://gillcleerenpluralsight.blob.core.windows.net/files/rhubarbpie.jpg",
                            inStock = true,
                            isPieOfTheWeek = true
                        },
                        new
                        {
                            pieID = 10,
                            AllergyInformation = "",
                            CategoryID = 1,
                            LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Name = "Strawberry Pie",
                            Price = 15.95m,
                            ShortDescription = "Our delicious strawberry pie!",
                            imageThumbnailURL = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypiesmall.jpg",
                            imageURL = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrypie.jpg",
                            inStock = true,
                            isPieOfTheWeek = false
                        },
                        new
                        {
                            pieID = 11,
                            AllergyInformation = "",
                            CategoryID = 2,
                            LongDescription = "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Name = "Strawberry Cheese Cake",
                            Price = 18.95m,
                            ShortDescription = "You'll love it!",
                            imageThumbnailURL = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecakesmall.jpg",
                            imageURL = "https://gillcleerenpluralsight.blob.core.windows.net/files/strawberrycheesecake.jpg",
                            inStock = false,
                            isPieOfTheWeek = false
                        });
                });

            modelBuilder.Entity("PieShop.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("ShoppingCartID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("pieID")
                        .HasColumnType("int");

                    b.HasKey("ShoppingCartItemID");

                    b.HasIndex("pieID");

                    b.ToTable("ShoppingCart");
                });

            modelBuilder.Entity("PieShop.Models.OrderDetail", b =>
                {
                    b.HasOne("PieShop.Models.Order", "Order")
                        .WithMany("OrderDetail")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PieShop.Models.Pie", "Pie")
                        .WithMany()
                        .HasForeignKey("PieID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Pie");
                });

            modelBuilder.Entity("PieShop.Models.Pie", b =>
                {
                    b.HasOne("PieShop.Models.Category", "Category")
                        .WithMany("pies")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("PieShop.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("PieShop.Models.Pie", "pie")
                        .WithMany()
                        .HasForeignKey("pieID");

                    b.Navigation("pie");
                });

            modelBuilder.Entity("PieShop.Models.Category", b =>
                {
                    b.Navigation("pies");
                });

            modelBuilder.Entity("PieShop.Models.Order", b =>
                {
                    b.Navigation("OrderDetail");
                });
#pragma warning restore 612, 618
        }
    }
}
