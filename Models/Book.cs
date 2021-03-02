using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Book : Product
    {
        public string Author { get; set; }
        public string Publisher { get; set; }
        //public short Published { get; set; }
        public string ISBN { get; set;  }

        public Book() { }

        //public Book(string author, string title, decimal price, short published)
        public Book(string author, string title, decimal price, string publisher, string isbn)
        {
            Author = author;
            Title = title;
            Price = price;
            Publisher = publisher;
            ISBN = isbn;
        }

        public Book( int productId, string author, string title, decimal price, string publisher, string imageFileName, string isbn)
        {
            Author = author;
            Title = title;
            Price = price;
            Publisher = publisher;
            ImageFileName = imageFileName;
            ISBN = isbn;
            ProductId = productId;
        }
    }
}
