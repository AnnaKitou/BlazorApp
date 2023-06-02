﻿// <auto-generated />
using System;
using BlazorProducts.Server.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BlazorProducts.Server.Migrations
{
    [DbContext(typeof(ProductContext))]
    [Migration("20210316065512_InitialRoleSeed")]
    partial class InitialRoleSeed
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.4")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Entities.Models.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Price")
                        .HasColumnType("float");

                    b.Property<string>("Supplier")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("0102f709-1dd7-40de-af3d-23598c6bbd1f"),
                            Description = "Features:\r\n- Features wraparound prints\r\n- Top rack dishwasher safe\r\n- Insulated stainless steel with removable lid\r\n- Mug holds 15oz(443ml)",
                            ImageUrl = "https://ih1.redbubble.net/image.1062161969.4889/mug,travel,x1000,center-pad,1000x1000,f8f8f8.u2.jpg",
                            Name = "Travel Mug",
                            Price = 11.0,
                            Supplier = "Code Maze"
                        },
                        new
                        {
                            Id = new Guid("ac7de2dc-049c-4328-ab06-6cde3ebe8aa7"),
                            Description = "Features\r\n- Features wraparound prints\r\n- Dishwasher safe\r\n- Made from ceramic\r\n- Mug holds 11oz (325ml)",
                            ImageUrl = "https://ih1.redbubble.net/image.1063377597.4889/ur,mug_lifestyle,square,1000x1000.u2.jpg",
                            Name = "Classic Mug",
                            Price = 22.0,
                            Supplier = "Code Maze"
                        },
                        new
                        {
                            Id = new Guid("d26384cb-64b9-4aca-acb0-4ebb8fc53ba2"),
                            Description = "Features\r\n- The standard, traditional t-shirt for everyday wear\r\n- Classic, generous, boxy fit\r\n- Heavyweight 5.3 oz / 180 gsm fabric, solid colors are 100% preshrunk cotton, heather grey is 90% cotton/10% polyester, denim heather is 50% cotton/ 50% polyester\r\n- Double-needle hems and neck band for durability",
                            ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,vneck,x1900,101010:01c5ca27c6,front-c,160,70,1000,1000-bg,f8f8f8.u2.jpg",
                            Name = "Code Maze Logo T-Shirt",
                            Price = 20.0,
                            Supplier = "Code Maze"
                        },
                        new
                        {
                            Id = new Guid("b47d4c3c-3e29-49b9-b6be-28e5ee4625be"),
                            Description = "Features\r\n- Heavyweight 9oz preshrunk cotton rich fleece made from 80% Cotton, 20% Polyester\r\n- Front pouch pocket, matching drawstring and rib cuffs\r\n- Ethically sourced following the World Responsible Apparel Practices Standards\r\n- Note: If you like your hoodies baggy go 2 sizes up",
                            ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodie,mens,101010:01c5ca27c6,front,square_three_quarter,x1000-bg,f8f8f8.1u2.jpg",
                            Name = "Pullover Hoodie",
                            Price = 30.0,
                            Supplier = "Code Maze"
                        },
                        new
                        {
                            Id = new Guid("54b2f952-b63e-4cad-8b38-c09955fe4c62"),
                            Description = "Features\r\n- Scoop neck, cap sleeves, and fitted cut add up to a fashionably casual tee\r\n- Slim fit, so consider going a size up if that's not your thing\r\n- Model shown is 5'11\" / 180 cm tall and wearing size Medium\r\n- Solid colors are 100 % cotton; heathered fabrics are 90 % cotton, 10 % polyester\r\n- Cold wash and hang dry to preserve your print",
                            ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ssrco,mhoodiez,mens,101010:01c5ca27c6,front,square_three_quarter,1000x1000-bg,f8f8f8.u2.jpg",
                            Name = "Fitted Scoop T-Shirt",
                            Price = 40.0,
                            Supplier = "Code Maze"
                        },
                        new
                        {
                            Id = new Guid("83e0aa87-158f-4e5f-a8f7-e5a98d13e3a5"),
                            Description = "Features\r\n- Heavyweight 9 oz preshrunk cotton rich fleece 80% cotton, 20% polyester\r\n- Front pouch pocket, matching drawstring and rib cuffs\r\n- Ethically sourced following the World Responsible Apparel Practices Standards\r\n- Note: If you like your hoodies baggy go 2 sizes up",
                            ImageUrl = "https://ih1.redbubble.net/image.1063364659.4889/ra,fitted_scoop,x2000,101010:01c5ca27c6,front-c,160,143,1000,1000-bg,f8f8f8.u2.jpg",
                            Name = "Zipped Hoodie",
                            Price = 55.0,
                            Supplier = "Code Maze"
                        },
                        new
                        {
                            Id = new Guid("488aaa0e-aa7e-4820-b4e9-5715f0e5186e"),
                            Description = "Features\r\n- Double layer clip-on protective case with extra durability\r\n- Impact resistant polycarbonate shell and shock absorbing inner TPU liner\r\n- Super-bright colors embedded directly into the case\r\n- Secure fit with design wrapping around side of the case and full access to ports\r\n- Compatible with Qi-standard wireless charging\r\n- Thickness 1/8 inch (3mm), weight 30g",
                            ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,iphone_11_soft,back,a,x1000-pad,1000x1000,f8f8f8.u2.jpg",
                            Name = "iPhone Case & Cover",
                            Price = 25.0,
                            Supplier = "Code Maze"
                        },
                        new
                        {
                            Id = new Guid("4e693871-788d-4db4-89e5-dd7678db975e"),
                            Description = "Features\r\n- Double layer clip-on protective case with extra durability\r\n- Impact resistant polycarbonate shell and shock absorbing liner\r\n- Super-bright colors embedded directly into the case\r\n- Secure fit with design wrapping around side of the case and full access to ports\r\n- Compatible with Qi-standard wireless charging\r\n- Thickness 1/8 inch (3mm), weight 30g",
                            ImageUrl = "https://ih1.redbubble.net/image.1062161956.4889/icr,samsung_galaxy_s10_snap,back,a,x1000-pad,1000x1000,f8f8f8.1u2.jpg",
                            Name = "Case & Skin for Samsung Galaxy",
                            Price = 35.0,
                            Supplier = "Code Maze"
                        },
                        new
                        {
                            Id = new Guid("2d3c2abe-85ec-4d1e-9fef-9b4bfea5f459"),
                            Description = "Features\r\n- Form fitting removable vinyl decal with laminate top coat\r\n- Scratch resistant backing\r\n- 3M Controltac with air bubble grooves for easy, bubble-free placement\r\n- Compatible with Qi-standard wireless charging\r\n- Weight <5g\r\n- Thickness <1/32 inch (<1mm)",
                            ImageUrl = "https://ih1.redbubble.net/image.1063329780.4889/mwo,x1000,ipad_2_snap-pad,1000x1000,f8f8f8.u2.jpg",
                            Name = "iPad Case & Skin",
                            Price = 45.0,
                            Supplier = "Code Maze"
                        },
                        new
                        {
                            Id = new Guid("d1f22836-6342-480a-be2f-035eeb010fd0"),
                            Description = "Features\r\n- Modern printed polypropylene with plexiglass face\r\n- Bamboo wood frame with natural finish or painted black or white\r\n- 4 customizable metal hand colors to choose from\r\n- Quartz clock mechanism(AA battery not included)\r\n- Built in hook at back for easy hanging",
                            ImageUrl = "https://ih1.redbubble.net/image.1062161997.4889/clkc,bamboo,white,1000x1000-bg,f8f8f8.u2.jpg",
                            Name = "Wall Clock",
                            Price = 25.0,
                            Supplier = "Code Maze"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasData(
                        new
                        {
                            Id = "912443f3-44dd-4b86-b579-be7ed236db7a",
                            ConcurrencyStamp = "caf4b2b6-26e5-42cc-b8a5-a3f48dae3d35",
                            Name = "Viewer",
                            NormalizedName = "VIEWER"
                        },
                        new
                        {
                            Id = "9fb74770-f526-4cdb-8f87-744dedbe0400",
                            ConcurrencyStamp = "189f9e0d-bba7-44ab-b29b-64c870575453",
                            Name = "Administrator",
                            NormalizedName = "ADMINISTRATOR"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}