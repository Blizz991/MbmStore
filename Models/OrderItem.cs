using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MbmStore.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; }
        public virtual int InvoiceId { get; set; }

        public OrderItem() { }

        public OrderItem(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;

            TotalPrice = CalculateTotalPrice(product, quantity);
        }

        public static decimal CalculateTotalPrice(Product product, int quantity)
        {
            decimal totalPrice;

            if (product != null)
            {
                totalPrice = product.Price * quantity;
            }else
            {
                totalPrice = 0;
            }

            return totalPrice;
        }
    }
}
