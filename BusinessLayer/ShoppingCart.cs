using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class ShoppingCart
    {
        public List<ProductsOrders> Items { get; set; }

        public decimal Total { get; set; }

        public ShoppingCart()
        {
            Items = new List<ProductsOrders>();
            Total = 0;
        }
    }
}
