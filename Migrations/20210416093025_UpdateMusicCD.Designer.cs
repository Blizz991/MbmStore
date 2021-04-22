﻿// <auto-generated />
using System;
using MbmStore.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MbmStore.Migrations
{
    [DbContext(typeof(MbmStoreContext))]
    [Migration("20210416093025_UpdateMusicCD")]
    partial class UpdateMusicCD
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MbmStore.Models.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ZipCode")
                        .HasColumnType("int");

                    b.HasKey("CustomerId");

                    b.ToTable("Customer");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Address = " Naturvej 22",
                            BirthDate = new DateTime(1991, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Hasselager",
                            FirstName = "Lasse",
                            LastName = "Olsen",
                            ZipCode = 8361
                        },
                        new
                        {
                            CustomerId = 2,
                            Address = "Danskgade 23",
                            BirthDate = new DateTime(1957, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Aarhus",
                            FirstName = "Mikkel",
                            LastName = "Viadith",
                            ZipCode = 8000
                        },
                        new
                        {
                            CustomerId = 3,
                            Address = "Violvej 121",
                            BirthDate = new DateTime(1965, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Aarhus",
                            FirstName = "Oscar",
                            LastName = "Lacour",
                            ZipCode = 800
                        },
                        new
                        {
                            CustomerId = 4,
                            Address = "Slotsgade",
                            BirthDate = new DateTime(1911, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Aarhus",
                            FirstName = "Bente",
                            LastName = "Hansen",
                            ZipCode = 8000
                        },
                        new
                        {
                            CustomerId = 5,
                            Address = "Bavnestraede 221",
                            BirthDate = new DateTime(1945, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Aarhus",
                            FirstName = "Viola",
                            LastName = "Fisker",
                            ZipCode = 8000
                        },
                        new
                        {
                            CustomerId = 6,
                            Address = "Toften 69 ",
                            BirthDate = new DateTime(2010, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Hasselager",
                            FirstName = "Trine",
                            LastName = "Jakobsen",
                            ZipCode = 8361
                        },
                        new
                        {
                            CustomerId = 7,
                            Address = "Solbakkevej 6 ",
                            BirthDate = new DateTime(2000, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Viby J ",
                            FirstName = "Mads",
                            LastName = "Kristiansen",
                            ZipCode = 8260
                        },
                        new
                        {
                            CustomerId = 8,
                            Address = "Solvangsvej 12",
                            BirthDate = new DateTime(1985, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            City = "Viby J ",
                            FirstName = "Ole",
                            LastName = "Sorensen",
                            ZipCode = 8260
                        });
                });

            modelBuilder.Entity("MbmStore.Models.Invoice", b =>
                {
                    b.Property<int>("InvoiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.HasKey("InvoiceId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Invoice");

                    b.HasData(
                        new
                        {
                            InvoiceId = 1,
                            CustomerId = 1,
                            OrderDate = new DateTime(2021, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            InvoiceId = 2,
                            CustomerId = 2,
                            OrderDate = new DateTime(2021, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("MbmStore.Models.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InvoiceId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderItemId");

                    b.HasIndex("InvoiceId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItem");

                    b.HasData(
                        new
                        {
                            OrderItemId = 1,
                            InvoiceId = 1,
                            ProductId = 4,
                            Quantity = 13
                        },
                        new
                        {
                            OrderItemId = 2,
                            InvoiceId = 1,
                            ProductId = 1,
                            Quantity = 1
                        },
                        new
                        {
                            OrderItemId = 3,
                            InvoiceId = 1,
                            ProductId = 8,
                            Quantity = 5
                        },
                        new
                        {
                            OrderItemId = 4,
                            InvoiceId = 2,
                            ProductId = 6,
                            Quantity = 8
                        },
                        new
                        {
                            OrderItemId = 5,
                            InvoiceId = 2,
                            ProductId = 7,
                            Quantity = 4
                        },
                        new
                        {
                            OrderItemId = 6,
                            InvoiceId = 2,
                            ProductId = 2,
                            Quantity = 2
                        },
                        new
                        {
                            OrderItemId = 7,
                            InvoiceId = 2,
                            ProductId = 5,
                            Quantity = 1
                        });
                });

            modelBuilder.Entity("MbmStore.Models.Phone", b =>
                {
                    b.Property<int>("PhoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("Number")
                        .HasColumnType("int");

                    b.Property<string>("PhoneType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PhoneId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Phone");

                    b.HasData(
                        new
                        {
                            PhoneId = 1,
                            CustomerId = 1,
                            Number = 12345678,
                            PhoneType = "landline"
                        },
                        new
                        {
                            PhoneId = 2,
                            CustomerId = 1,
                            Number = 23456789,
                            PhoneType = "mobile"
                        },
                        new
                        {
                            PhoneId = 3,
                            CustomerId = 2,
                            Number = 49203491,
                            PhoneType = "fax"
                        },
                        new
                        {
                            PhoneId = 4,
                            CustomerId = 3,
                            Number = 95832849,
                            PhoneType = "mobile"
                        },
                        new
                        {
                            PhoneId = 5,
                            CustomerId = 4,
                            Number = 48219342,
                            PhoneType = "landline"
                        },
                        new
                        {
                            PhoneId = 6,
                            CustomerId = 5,
                            Number = 67129433,
                            PhoneType = "landline"
                        },
                        new
                        {
                            PhoneId = 7,
                            CustomerId = 6,
                            Number = 78959922,
                            PhoneType = "mobile"
                        },
                        new
                        {
                            PhoneId = 8,
                            CustomerId = 7,
                            Number = 11944332,
                            PhoneType = "mobile"
                        },
                        new
                        {
                            PhoneId = 9,
                            CustomerId = 8,
                            Number = 32424323,
                            PhoneType = "mobile"
                        });
                });

            modelBuilder.Entity("MbmStore.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Category")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageFileName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProductId");

                    b.ToTable("Product");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Product");
                });

            modelBuilder.Entity("MbmStore.Models.Track", b =>
                {
                    b.Property<int>("TrackId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Composer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("Length")
                        .HasColumnType("time");

                    b.Property<int?>("MusicCDProductId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TrackId");

                    b.HasIndex("MusicCDProductId");

                    b.ToTable("Track");

                    b.HasData(
                        new
                        {
                            TrackId = 1,
                            Composer = "Someone1",
                            Length = new TimeSpan(0, 0, 2, 28, 0),
                            ProductId = 3,
                            Title = "Come Together"
                        },
                        new
                        {
                            TrackId = 2,
                            Composer = "Someone2",
                            Length = new TimeSpan(0, 0, 1, 28, 0),
                            ProductId = 3,
                            Title = "Something"
                        },
                        new
                        {
                            TrackId = 3,
                            Composer = "Someone1",
                            Length = new TimeSpan(0, 0, 2, 38, 0),
                            ProductId = 3,
                            Title = "Maxwell's Silver Hammer"
                        },
                        new
                        {
                            TrackId = 4,
                            Composer = "Someone3",
                            Length = new TimeSpan(0, 0, 2, 57, 0),
                            ProductId = 3,
                            Title = "Oh! Darling"
                        },
                        new
                        {
                            TrackId = 5,
                            Composer = "Someone1",
                            Length = new TimeSpan(0, 0, 2, 15, 0),
                            ProductId = 3,
                            Title = "Octopus' Garden"
                        },
                        new
                        {
                            TrackId = 6,
                            Composer = "Someone4",
                            Length = new TimeSpan(0, 0, 1, 14, 0),
                            ProductId = 3,
                            Title = "I Want You (She's So Heavy"
                        },
                        new
                        {
                            TrackId = 7,
                            Composer = "Someone1",
                            Length = new TimeSpan(0, 0, 2, 28, 0),
                            ProductId = 3,
                            Title = "Here Comes The Sun"
                        },
                        new
                        {
                            TrackId = 8,
                            Composer = "Someone1",
                            Length = new TimeSpan(0, 0, 9, 11, 0),
                            ProductId = 3,
                            Title = "Because"
                        },
                        new
                        {
                            TrackId = 9,
                            Composer = "Someone5",
                            Length = new TimeSpan(0, 0, 5, 7, 0),
                            ProductId = 3,
                            Title = "You Never Give Me Your Money"
                        },
                        new
                        {
                            TrackId = 10,
                            Composer = "Someone1",
                            Length = new TimeSpan(0, 0, 2, 28, 0),
                            ProductId = 3,
                            Title = "Sun King"
                        },
                        new
                        {
                            TrackId = 11,
                            Composer = "Someone1",
                            Length = new TimeSpan(0, 0, 2, 28, 0),
                            ProductId = 3,
                            Title = "Mean Mr. Mustard"
                        },
                        new
                        {
                            TrackId = 12,
                            Composer = "Someone6",
                            Length = new TimeSpan(0, 0, 2, 28, 0),
                            ProductId = 3,
                            Title = "Polythene Pam"
                        },
                        new
                        {
                            TrackId = 13,
                            Composer = "Someone1",
                            Length = new TimeSpan(0, 0, 2, 28, 0),
                            ProductId = 3,
                            Title = "She Came In Through The Bathroom Window"
                        },
                        new
                        {
                            TrackId = 14,
                            Composer = "Someone1",
                            Length = new TimeSpan(0, 0, 2, 28, 0),
                            ProductId = 3,
                            Title = "Golden Slumbers"
                        },
                        new
                        {
                            TrackId = 15,
                            Composer = "Someone1",
                            Length = new TimeSpan(0, 0, 2, 28, 0),
                            ProductId = 3,
                            Title = "Carry That Weight"
                        },
                        new
                        {
                            TrackId = 16,
                            Composer = "Someone1",
                            Length = new TimeSpan(0, 0, 2, 28, 0),
                            ProductId = 3,
                            Title = "The End"
                        },
                        new
                        {
                            TrackId = 17,
                            Composer = "Someone1",
                            Length = new TimeSpan(0, 0, 2, 28, 0),
                            ProductId = 3,
                            Title = "Her Majesty"
                        },
                        new
                        {
                            TrackId = 18,
                            Composer = "Someone1",
                            Length = new TimeSpan(0, 0, 2, 28, 0),
                            ProductId = 4,
                            Title = "Come Together"
                        },
                        new
                        {
                            TrackId = 19,
                            Composer = "Someone2",
                            Length = new TimeSpan(0, 0, 1, 28, 0),
                            ProductId = 4,
                            Title = "Something"
                        },
                        new
                        {
                            TrackId = 20,
                            Composer = "Someone1",
                            Length = new TimeSpan(0, 0, 2, 28, 0),
                            ProductId = 4,
                            Title = "Sun King"
                        },
                        new
                        {
                            TrackId = 21,
                            Composer = "Someone1",
                            Length = new TimeSpan(0, 0, 2, 28, 0),
                            ProductId = 4,
                            Title = "Mean Mr. Mustard"
                        },
                        new
                        {
                            TrackId = 22,
                            Composer = "Someone6",
                            Length = new TimeSpan(0, 0, 2, 28, 0),
                            ProductId = 4,
                            Title = "Polythene Pam"
                        },
                        new
                        {
                            TrackId = 23,
                            Composer = "Someone1",
                            Length = new TimeSpan(0, 0, 2, 28, 0),
                            ProductId = 4,
                            Title = "She Came In Through The Bathroom Window"
                        },
                        new
                        {
                            TrackId = 24,
                            Composer = "Someone4",
                            Length = new TimeSpan(0, 0, 1, 14, 0),
                            ProductId = 4,
                            Title = "I Want You (She's So Heavy"
                        },
                        new
                        {
                            TrackId = 25,
                            Composer = "Someone1",
                            Length = new TimeSpan(0, 0, 2, 28, 0),
                            ProductId = 4,
                            Title = "Here Comes The Sun"
                        },
                        new
                        {
                            TrackId = 26,
                            Composer = "Someone1",
                            Length = new TimeSpan(0, 0, 9, 11, 0),
                            ProductId = 4,
                            Title = "Because"
                        },
                        new
                        {
                            TrackId = 27,
                            Composer = "Someone5",
                            Length = new TimeSpan(0, 0, 5, 7, 0),
                            ProductId = 4,
                            Title = "You Never Give Me Your Money"
                        });
                });

            modelBuilder.Entity("MbmStore.Models.Book", b =>
                {
                    b.HasBaseType("MbmStore.Models.Product");

                    b.Property<string>("Author")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ISBN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Publisher")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Book_Publisher");

                    b.HasDiscriminator().HasValue("Book");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            Category = "Book",
                            ImageFileName = "hardDaysWrite.jpg",
                            Price = 150.00m,
                            Title = "A Hard Day's Write: The Stories Behind Every Beatles Song",
                            Author = "Steve Turner",
                            ISBN = "6214241",
                            Publisher = "HarperCollins Publishers"
                        },
                        new
                        {
                            ProductId = 2,
                            Category = "Book",
                            ImageFileName = "jungleBook.jpg",
                            Price = 15078.00m,
                            Title = "A title that makes no sense!",
                            Author = "That Author",
                            ISBN = "9999",
                            Publisher = "Who even cares who publishes things"
                        });
                });

            modelBuilder.Entity("MbmStore.Models.Movie", b =>
                {
                    b.HasBaseType("MbmStore.Models.Product");

                    b.Property<string>("Director")
                        .HasColumnType("nvarchar(max)");

                    b.HasDiscriminator().HasValue("Movie");

                    b.HasData(
                        new
                        {
                            ProductId = 5,
                            Category = "Movie",
                            ImageFileName = "junglebook.jpg",
                            Price = 160.50m,
                            Title = "Jungle Book",
                            Director = "Someone 1"
                        },
                        new
                        {
                            ProductId = 6,
                            Category = "Movie",
                            ImageFileName = "gladiator.jpg",
                            Price = 99.99m,
                            Title = "Gladiator",
                            Director = "Someone 2"
                        },
                        new
                        {
                            ProductId = 7,
                            Category = "Movie",
                            ImageFileName = "forrest-gump.jpg",
                            Price = 129.99m,
                            Title = "Forrest Gump",
                            Director = "Someone 3"
                        },
                        new
                        {
                            ProductId = 8,
                            Category = "Movie",
                            ImageFileName = "nocturne.jpg",
                            Price = 190.56m,
                            Title = "Nocturne",
                            Director = "Zu Quirke"
                        },
                        new
                        {
                            ProductId = 9,
                            Category = "Movie",
                            ImageFileName = "deadfriends.jpg",
                            Price = 180.45m,
                            Title = "All my friends are dead",
                            Director = "Jan Belcl"
                        });
                });

            modelBuilder.Entity("MbmStore.Models.MusicCD", b =>
                {
                    b.HasBaseType("MbmStore.Models.Product");

                    b.Property<string>("Artist")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Label")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Publisher")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("TotalTime")
                        .HasColumnType("time");

                    b.HasDiscriminator().HasValue("MusicCD");

                    b.HasData(
                        new
                        {
                            ProductId = 3,
                            Category = "MusicCD",
                            ImageFileName = "BeatlesAbbeyRoad.jpg",
                            Price = 128.00m,
                            Title = "Abbey Road (Remastered)",
                            Artist = "Beatles",
                            Label = "EMI",
                            Publisher = "EMI (2009)",
                            TotalTime = new TimeSpan(0, 0, 0, 0, 0)
                        },
                        new
                        {
                            ProductId = 4,
                            Category = "MusicCD",
                            ImageFileName = "gladiator.jpg",
                            Price = 1289.00m,
                            Title = "Things",
                            Artist = "Stuff",
                            Label = "That Label",
                            Publisher = "Some Random Publisher",
                            TotalTime = new TimeSpan(0, 0, 0, 0, 0)
                        });
                });

            modelBuilder.Entity("MbmStore.Models.Invoice", b =>
                {
                    b.HasOne("MbmStore.Models.Customer", "Customer")
                        .WithMany("Invoices")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("MbmStore.Models.OrderItem", b =>
                {
                    b.HasOne("MbmStore.Models.Invoice", null)
                        .WithMany("OrderItems")
                        .HasForeignKey("InvoiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MbmStore.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("MbmStore.Models.Phone", b =>
                {
                    b.HasOne("MbmStore.Models.Customer", "Customer")
                        .WithMany("PhoneNumbers")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("MbmStore.Models.Track", b =>
                {
                    b.HasOne("MbmStore.Models.MusicCD", null)
                        .WithMany("Tracks")
                        .HasForeignKey("MusicCDProductId");
                });

            modelBuilder.Entity("MbmStore.Models.Customer", b =>
                {
                    b.Navigation("Invoices");

                    b.Navigation("PhoneNumbers");
                });

            modelBuilder.Entity("MbmStore.Models.Invoice", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("MbmStore.Models.MusicCD", b =>
                {
                    b.Navigation("Tracks");
                });
#pragma warning restore 612, 618
        }
    }
}