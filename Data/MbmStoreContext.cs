using MbmStore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Data
{
    public class MbmStoreContext : DbContext
    {
        public MbmStoreContext(DbContextOptions<MbmStoreContext> options) : base(options)
        {

        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Phone> Phones { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MusicCD> MusicCDs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            if (modelBuilder != null)
            {
                modelBuilder.Entity<Customer>().ToTable("Customer");
                modelBuilder.Entity<Phone>().ToTable("Phone");
                modelBuilder.Entity<Invoice>().ToTable("Invoice");
                modelBuilder.Entity<OrderItem>().ToTable("OrderItem");
                modelBuilder.Entity<Product>().ToTable("Product");

                modelBuilder.Entity<Book>().HasData(
                    new Book
                    {
                        ProductId = 1,
                        Author = "Steve Turner",
                        Title = "A Hard Day's Write: The Stories Behind Every Beatles Song",
                        Price = 150.00m,
                        Publisher = "HarperCollins Publishers",
                        ImageFileName = "hardDaysWrite.jpg",
                        ISBN = "6214241",
                        Category = "Book"
                    },
                    new Book
                    {
                        ProductId = 2,
                        Author = "That Author",
                        Title = "A title that makes no sense!",
                        Price = 15078.00m,
                        Publisher = "Who even cares who publishes things",
                        ImageFileName = "jungleBook.jpg",
                        ISBN = "9999",
                        Category = "Book"
                    }
                );

                modelBuilder.Entity<MusicCD>().HasData(
                    new MusicCD
                    {
                        ProductId = 3,
                        Artist = "Beatles",
                        Title = "Abbey Road (Remastered)",
                        Price = 128.00m,
                        Publisher = "EMI (2009)",
                        Label = "EMI",
                        ImageFileName = "BeatlesAbbeyRoad.jpg",
                        Category = "MusicCD",
                    },
                    new MusicCD
                    {
                        ProductId = 4,
                        Artist = "Stuff",
                        Title = "Things",
                        Price = 1289.00m,
                        Publisher = "Some Random Publisher",
                        Label = "That Label",
                        ImageFileName = "gladiator.jpg",
                        Category = "MusicCD"
                    }
                );

                modelBuilder.Entity<Track>().HasData(
                    new Track { TrackId = 1, Title = "Come Together", Composer = "Someone1", Length = new TimeSpan(0, 0, 2, 28), ProductId = 3},
                    new Track { TrackId = 2, Title = "Something", Composer = "Someone2", Length = new TimeSpan(0, 0, 1, 28), ProductId = 3 },
                    new Track { TrackId = 3, Title = "Maxwell's Silver Hammer", Composer = "Someone1", Length = new TimeSpan(0, 0, 2, 38), ProductId = 3 },
                    new Track { TrackId = 4, Title = "Oh! Darling", Composer = "Someone3", Length = new TimeSpan(0, 0, 2, 57), ProductId = 3 },
                    new Track { TrackId = 5, Title = "Octopus' Garden", Composer = "Someone1", Length = new TimeSpan(0, 0, 2, 15), ProductId = 3 },
                    new Track { TrackId = 6, Title = "I Want You (She's So Heavy", Composer = "Someone4", Length = new TimeSpan(0, 0, 1, 14), ProductId = 3 },
                    new Track { TrackId = 7, Title = "Here Comes The Sun", Composer = "Someone1", Length = new TimeSpan(0, 0, 2, 28), ProductId = 3 },
                    new Track { TrackId = 8, Title = "Because", Composer = "Someone1", Length = new TimeSpan(0, 0, 9, 11), ProductId = 3 },
                    new Track { TrackId = 9, Title = "You Never Give Me Your Money", Composer = "Someone5", Length = new TimeSpan(0, 0, 5, 7), ProductId = 3 },
                    new Track { TrackId = 10, Title = "Sun King", Composer = "Someone1", Length = new TimeSpan(0, 0, 2, 28), ProductId = 3 },
                    new Track { TrackId = 11, Title = "Mean Mr. Mustard", Composer = "Someone1", Length = new TimeSpan(0, 0, 2, 28), ProductId = 3 },
                    new Track { TrackId = 12, Title = "Polythene Pam", Composer = "Someone6", Length = new TimeSpan(0, 0, 2, 28), ProductId = 3 },
                    new Track { TrackId = 13, Title = "She Came In Through The Bathroom Window", Composer = "Someone1", Length = new TimeSpan(0, 0, 2, 28), ProductId = 3 },
                    new Track { TrackId = 14, Title = "Golden Slumbers", Composer = "Someone1", Length = new TimeSpan(0, 0, 2, 28), ProductId = 3 },
                    new Track { TrackId = 15, Title = "Carry That Weight", Composer = "Someone1", Length = new TimeSpan(0, 0, 2, 28), ProductId = 3 },
                    new Track { TrackId = 16, Title = "The End", Composer = "Someone1", Length = new TimeSpan(0, 0, 2, 28), ProductId = 3 },
                    new Track { TrackId = 17, Title = "Her Majesty", Composer = "Someone1", Length = new TimeSpan(0, 0, 2, 28), ProductId = 3 },

                    new Track { TrackId = 18, Title = "Come Together", Composer = "Someone1", Length = new TimeSpan(0, 0, 2, 28), ProductId = 4 },
                    new Track { TrackId = 19, Title = "Something", Composer = "Someone2", Length = new TimeSpan(0, 0, 1, 28), ProductId = 4 },
                    new Track { TrackId = 20, Title = "Sun King", Composer = "Someone1", Length = new TimeSpan(0, 0, 2, 28), ProductId = 4 },
                    new Track { TrackId = 21, Title = "Mean Mr. Mustard", Composer = "Someone1", Length = new TimeSpan(0, 0, 2, 28), ProductId = 4 },
                    new Track { TrackId = 22, Title = "Polythene Pam", Composer = "Someone6", Length = new TimeSpan(0, 0, 2, 28), ProductId = 4 },
                    new Track { TrackId = 23, Title = "She Came In Through The Bathroom Window", Composer = "Someone1", Length = new TimeSpan(0, 0, 2, 28), ProductId = 4 },
                    new Track { TrackId = 24, Title = "I Want You (She's So Heavy", Composer = "Someone4", Length = new TimeSpan(0, 0, 1, 14), ProductId = 4 },
                    new Track { TrackId = 25, Title = "Here Comes The Sun", Composer = "Someone1", Length = new TimeSpan(0, 0, 2, 28), ProductId = 4 },
                    new Track { TrackId = 26, Title = "Because", Composer = "Someone1", Length = new TimeSpan(0, 0, 9, 11), ProductId = 4 },
                    new Track { TrackId = 27, Title = "You Never Give Me Your Money", Composer = "Someone5", Length = new TimeSpan(0, 0, 5, 7), ProductId = 4 }
                );

                modelBuilder.Entity<Movie>().HasData(
                    new Movie
                    {
                        ProductId = 5,
                        Title = "Jungle Book",
                        Price = 160.50m,
                        Director = "Someone 1",
                        ImageFileName = "junglebook.jpg",
                        Category = "Movie"
                    },
                    new Movie
                    {
                        ProductId = 6,
                        Title = "Gladiator",
                        Price = 99.99m,
                        Director = "Someone 2",
                        ImageFileName = "gladiator.jpg",
                        Category = "Movie"
                    },
                    new Movie
                    {
                        ProductId = 7,
                        Title = "Forrest Gump",
                        Price = 129.99m,
                        Director = "Someone 3",
                        ImageFileName = "forrest-gump.jpg",
                        Category = "Movie"
                    },
                    new Movie
                    {
                        ProductId = 8,
                        Title = "Nocturne",
                        Price = 190.56m,
                        Director = "Zu Quirke",
                        ImageFileName = "nocturne.jpg",
                        Category = "Movie"
                    },
                    new Movie
                    {
                        ProductId = 9,
                        Title = "All my friends are dead",
                        Price = 180.45m,
                        Director = "Jan Belcl",
                        ImageFileName = "deadfriends.jpg",
                        Category = "Movie"
                    }
                );

                modelBuilder.Entity<Customer>().HasData(
                    new Customer
                    {
                        CustomerId = 1,
                        FirstName = "Lasse",
                        LastName = "Olsen",
                        BirthDate = new DateTime(1991, 02, 09),
                        Address = " Naturvej 22",
                        ZipCode = 8361,
                        City = "Hasselager",
                    },
                    new Customer
                    {
                        CustomerId = 2,
                        FirstName = "Mikkel",
                        LastName = "Viadith",
                        BirthDate = new DateTime(1957, 05, 17),
                        Address = "Danskgade 23",
                        ZipCode = 8000,
                        City = "Aarhus",
                    },
                    new Customer
                    {
                        CustomerId = 3,
                        FirstName = "Oscar",
                        LastName = "Lacour",
                        BirthDate = new DateTime (1965, 04, 22),
                        Address = "Violvej 121",
                        ZipCode = 800,
                        City = "Aarhus",

                    },
                     new Customer 
                     {
                         CustomerId = 4 ,
                         FirstName = "Bente",
                         LastName = "Hansen",
                         BirthDate = new DateTime (1911,12,23),
                         Address = "Slotsgade",
                         ZipCode = 8000,
                         City = "Aarhus"
                     },
                     new Customer
                     {
                         CustomerId = 5,
                         FirstName = "Viola",
                         LastName = "Fisker",
                         BirthDate = new DateTime (1945,10,11),
                         Address = "Bavnestraede 221",
                         ZipCode = 8000,
                         City = "Aarhus",
                     },
                     new Customer
                     {
                         CustomerId = 6,
                         FirstName = "Trine",
                         LastName = "Jakobsen",
                         BirthDate = new DateTime (2010,03,28),
                         Address = "Toften 69 ",
                         ZipCode = 8361,
                         City = "Hasselager",
                         
                     },
                     new Customer
                     {
                         CustomerId = 7,
                         FirstName = "Mads",
                         LastName = "Kristiansen",
                         BirthDate = new DateTime(2000, 07, 18),
                         Address = "Solbakkevej 6 ",
                         ZipCode = 8260,
                         City = "Viby J ",
                     },
                     new Customer
                     {
                         CustomerId = 8,
                         FirstName = "Ole",
                         LastName = "Sorensen",
                         BirthDate = new DateTime(1985, 01, 19),
                         Address = "Solvangsvej 12",
                         ZipCode = 8260,
                         City = "Viby J ",
                     }
                );

                modelBuilder.Entity<Phone>().HasData(
                    new Phone{ PhoneId = 1, CustomerId = 1, PhoneType = "landline", Number = 12345678  },
                    new Phone{ PhoneId = 2, CustomerId = 1, PhoneType = "mobile", Number = 23456789 },
                    new Phone{ PhoneId = 3, CustomerId = 2, PhoneType = "fax", Number = 49203491},
                    new Phone{ PhoneId = 4, CustomerId = 3, PhoneType = "mobile", Number = 95832849},
                    new Phone{ PhoneId = 5, CustomerId = 4, PhoneType = "landline", Number = 48219342},
                    new Phone{ PhoneId = 6, CustomerId = 5, PhoneType = "landline", Number = 67129433},
                    new Phone{ PhoneId = 7, CustomerId = 6, PhoneType = "mobile", Number = 78959922},
                    new Phone{ PhoneId = 8, CustomerId = 7, PhoneType = "mobile", Number = 11944332},
                    new Phone{ PhoneId = 9, CustomerId = 8, PhoneType = "mobile", Number = 32424323} 
                );

                modelBuilder.Entity<Invoice>().HasData(
                    new Invoice
                    {
                        InvoiceId = 1,
                        OrderDate = new DateTime(2021, 02, 01),
                        CustomerId = 1
                    },
                    new Invoice
                    {
                        InvoiceId = 2,
                        OrderDate = new DateTime(2021, 02, 17),
                        CustomerId = 2

                    }

                );
                modelBuilder.Entity<OrderItem>().HasData(
                    new OrderItem { OrderItemId = 1, ProductId = 4, Quantity = 13, InvoiceId = 1 },
                    new OrderItem { OrderItemId = 2, ProductId = 1, Quantity = 1, InvoiceId = 1 },
                    new OrderItem { OrderItemId = 3, ProductId = 8, Quantity = 5, InvoiceId = 1 },
                    new OrderItem { OrderItemId = 4, ProductId = 6, Quantity = 8, InvoiceId = 2 },
                    new OrderItem { OrderItemId = 5, ProductId = 7, Quantity = 4, InvoiceId = 2 },
                    new OrderItem { OrderItemId = 6, ProductId = 2, Quantity = 2, InvoiceId = 2 },
                    new OrderItem { OrderItemId = 7, ProductId = 5, Quantity = 1, InvoiceId = 2 }
                );
            }
        }
    }
}
