using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ProductsOrders
    {
        [ForeignKey("Product")]
        public string ProductId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; }
        public ProductsOrders()
        {

        }
        public ProductsOrders(string productId, int orderId, int quantity)
        {
            ProductId = productId;
            OrderId = orderId;
            Quantity = quantity;
        }
    }
}
