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

        public Movie(int productId, string title, decimal price, string director, string imageFileName)
        {
            Title = title;
            Price = price;
            Director = director;
            ImageFileName = imageFileName;
            ProductId = productId;
        }

        public Movie(int productId, string title, decimal price, string director, string imageFileName, string category)
        {
            Title = title;
            Price = price;
            Director = director;
            ImageFileName = imageFileName;
            ProductId = productId;
            Category = category;

        }

    }
}