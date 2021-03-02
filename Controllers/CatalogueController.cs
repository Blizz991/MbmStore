using MbmStore.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Controllers
{
    public class CatalogueController : Controller
    {
        public IActionResult Index()
        {
            List<Book> books = new List<Book> {
            new Book(
                "Steve Turner",
                "A Hard Day's Write: The Stories Behind Every Beatles Song",
                150.00m,
                "HarperCollins Publishers",
                "hardDaysWrite.jpg",
                "6214241"
                ),
            new Book(
                "That Author",
                "A title that makes no sense!",
                15078.00m,
                "Who even cares who publishes things",
                "jungleBook.jpg",
                "9999"
                )
            };

            List<MusicCD> musicCDs = new List<MusicCD>
            {
                new MusicCD(
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

            List<Movie> movies = new List<Movie>
            {
                new Movie("Jungle Book", 160.50m, "Someone 1", "junglebook.jpg"),
                new Movie("Gladiator", 99.99m, "Someone 2", "gladiator.jpg"),
                new Movie("Forrest Gump", 129.99m, "Someone 3", "forrest-gump.jpg"),
            };

            ViewBag.Books = books;
            ViewBag.MusicCDs = musicCDs;
            ViewBag.Movies = movies;

            return View();
        }
    }
}
