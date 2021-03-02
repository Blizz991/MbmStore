using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MbmStore.Models
{
    public class Movie : Product
    {
        // properties
        public string Director { get; set; }

        // constructors
        public Movie() { }

        public Movie(string title, decimal price)
        {
            Title = title;
            Price = price;
        }

        public Movie(string title, decimal price, string director)
        {
            Title = title;
            Price = price;
            Director = director;
        }

        public Movie(string title, decimal price, string director, string imageFileName)
        {
            Title = title;
            Price = price;
            Director = director;
            ImageFileName = imageFileName;
        }
    }
}