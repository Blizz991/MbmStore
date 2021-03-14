using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class Product
    {
        private decimal price;
        public int ProductId { get; set; }
        public string Title { get; set; }
        public decimal Price
        {
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Price is not accepted");
                }
                else
                {
                    price = value;
                }
            }
            get { return price; }
        }
        public string ImageFileName { get; set; }

        public Product() { }

        public Product(string title, decimal price)
        {
            Title = title;
            this.price = price;
        }

        public Product(string title, decimal price, string imageFileName)
        {
            Title = title;
            this.price = price;
            ImageFileName = imageFileName;
        }
        public Product(int productId ,string title, decimal price, string imageFileName)
        {
            ProductId = productId;
            Title = title;
            this.price = price;
            ImageFileName = imageFileName;

        }
    }
}
