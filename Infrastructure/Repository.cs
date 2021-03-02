using MbmStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Infrastructure
{
    public static class Repository
    {
        public static List<Product> Products = new List<Product>();
        public static List<Invoice> Invoices = new List<Invoice>();
        public static List<Customer> Customers = new List<Customer>();

        static Repository()
        {
            // List<OrderItem> orderItem = new List<OrderItem>{
            //     new OrderItem(1,200,,1,500)
            // }
            List<Book> books = new List<Book> {
            new Book(
                1,
                "Steve Turner",
                "A Hard Day's Write: The Stories Behind Every Beatles Song",
                150.00m,
                "HarperCollins Publishers",
                "hardDaysWrite.jpg",
                "6214241"
                ),
            new Book(
                2,
                "That Author",
                "A title that makes no sense!",
                15078.00m,
                "Who even cares who publishes things",
                "jungleBook.jpg",
                "9999"
                )
            };

            // Doesn't really make sense, but sticking to the previous code.
            foreach (Book book in books)
            {
                Products.Add(book);
            }

            List<MusicCD> musicCDs = new List<MusicCD>
            {
                new MusicCD(
                    3,
                    "Beatles",
                    "Abbey Road (Remastered)",
                    128.00m,
                    "EMI (2009)",
                    "BeatlesAbbeyRoad.jpg",
                    new Track[]
                    {
                        new Track("Come Together", "Someone1", new TimeSpan(0,0,2,28)),
                        new Track("Something", "Someone2", new TimeSpan(0,0,1,28)),
                        new Track("Maxwell's Silver Hammer", "Someone1", new TimeSpan(0,0,2,38)),
                        new Track("Oh! Darling", "Someone3", new TimeSpan(0,0,2,57)),
                        new Track("Octopus' Garden", "Someone1", new TimeSpan(0,0,2,15)),
                        new Track("I Want You (She's So Heavy", "Someone4", new TimeSpan(0,0,1,14)),
                        new Track("Here Comes The Sun", "Someone1", new TimeSpan(0,0,2,28)),
                        new Track("Because", "Someone1", new TimeSpan(0,0,9,11)),
                        new Track("You Never Give Me Your Money", "Someone5", new TimeSpan(0,0,5,7)),
                        new Track("Sun King", "Someone1", new TimeSpan(0,0,2,28)),
                        new Track("Mean Mr. Mustard", "Someone1", new TimeSpan(0,0,2,28)),
                        new Track("Polythene Pam", "Someone6", new TimeSpan(0,0,2,28)),
                        new Track("She Came In Through The Bathroom Window", "Someone1", new TimeSpan(0,0,2,28)),
                        new Track("Golden Slumbers", "Someone1", new TimeSpan(0,0,2,28)),
                        new Track("Carry That Weight", "Someone1", new TimeSpan(0,0,2,28)),
                        new Track("The End", "Someone1", new TimeSpan(0,0,2,28)),
                        new Track("Her Majesty", "Someone1", new TimeSpan(0,0,2,28))
                    }
                ),
                new MusicCD(
                    4,
                    "Stuff",
                    "Things",
                    1289.00m,
                    "Some Random Publisher",
                    "gladiator.jpg",
                    new Track[]
                    {
                        new Track("Come Together", "Someone1", new TimeSpan(0,0,2,28)),
                        new Track("Something", "Someone2", new TimeSpan(0,0,1,28)),
                        new Track("Sun King", "Someone1", new TimeSpan(0,0,2,28)),
                        new Track("Mean Mr. Mustard", "Someone1", new TimeSpan(0,0,2,28)),
                        new Track("Polythene Pam", "Someone6", new TimeSpan(0,0,2,28)),
                        new Track("She Came In Through The Bathroom Window", "Someone1", new TimeSpan(0,0,2,28)),
                        new Track("I Want You (She's So Heavy", "Someone4", new TimeSpan(0,0,1,14)),
                        new Track("Here Comes The Sun", "Someone1", new TimeSpan(0,0,2,28)),
                        new Track("Because", "Someone1", new TimeSpan(0,0,9,11)),
                        new Track("You Never Give Me Your Money", "Someone5", new TimeSpan(0,0,5,7)),
                    }
                )
            };

            foreach (MusicCD musicCD in musicCDs)
            {
                Products.Add(musicCD);
            }

            List<Movie> movies = new List<Movie>
            {
                new Movie(5, "Jungle Book", 160.50m, "Someone 1", "junglebook.jpg"),
                new Movie(6, "Gladiator", 99.99m, "Someone 2", "gladiator.jpg"),
                new Movie(7, "Forrest Gump", 129.99m, "Someone 3", "forrest-gump.jpg"),
                new Movie(8, "Nocturne",190.56m,"Zu Quirke","nocturne.jpg"),
                new Movie(9, "All my friends are dead",180.45m,"Jan Belcl","deadfriends.jpg")
            };

            foreach (Movie movie in movies)
            {
                Products.Add(movie);
            }

            List<Customer> customers = new List<Customer>
            {
                new Customer("Lasse", "Olsen", new DateTime(1991,02,09), "Naturvej 21", 8361, "Hasselager", new int[] {12345678, 23456789 }),
                new Customer("Mikkel", "Viadith", new DateTime(1957,05,17), "Danskgade 23", 8000, "Aarhus", new int[] {23456781, 34567892 }),
                new Customer("Oscar", "Lacour", new DateTime(1965,04,22), "Violvej 121", 8000, "Aarhus", new int[] {34567812, 45678923 }),
                new Customer("Bente", "Hansen", new DateTime(1911,12,23), "Slotsgade", 8000, "Aarhus", new int[] {45678123, 56789234 }),
                new Customer("Viola", "Fisker", new DateTime(1945,10,11), "Bavnestræde 221", 8000, "Aarhus", new int[] {56781234, 67892345 }),
                new Customer("Trine", "Jakobsen", new DateTime(2010,03,28), "Toften 69", 8361, "Hasselager", new int[] {67812345, 78923456 }),
                new Customer("Mads", "kristiansen", new DateTime(2000,07,18), "Solbakkevej 6", 8260, "Viby j", new int[] {48193105, 35914051 }),
                new Customer("Ole", "Sørensen", new DateTime(1985,01,19), "Solvangsvej 12", 8260, "Viby j", new int[] {75930148, 39503932 })
            };

            foreach (Customer customer in customers)
            {
                Customers.Add(customer);
            }

            Invoices.Add(
                new Invoice(1, new DateTime(2021, 02, 01), customers[2])
            );

            Invoices.Add(
                new Invoice(2, new DateTime(2021, 02, 17), customers[4])
            );

            Invoices.Add(
                new Invoice(3, new DateTime(2021, 02, 23), customers[3])
            );

            Invoices[0].AddOrderItem(new OrderItem(Products[4], 13));
            Invoices[0].AddOrderItem(new OrderItem(Products[1], 1));
            Invoices[0].AddOrderItem(new OrderItem(Products[8], 5));
            Invoices[1].AddOrderItem(new OrderItem(Products[6], 8));
            Invoices[1].AddOrderItem(new OrderItem(Products[7], 4));
            Invoices[1].AddOrderItem(new OrderItem(Products[0], 2));
            Invoices[1].AddOrderItem(new OrderItem(Products[5], 1));
            Invoices[2].AddOrderItem(new OrderItem(Products[5], 1));
            Invoices[2].AddOrderItem(new OrderItem(Products[6], 1));
            Invoices[2].AddOrderItem(new OrderItem(Products[8], 2));
            Invoices[2].AddOrderItem(new OrderItem(Products[2], 3));
            Invoices[2].AddOrderItem(new OrderItem(Products[3], 28));
        }
    }
}
