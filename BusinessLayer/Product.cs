using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Product
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int AvailableQuantity { get; set; }
        [Required]
        public ProductType Type { get; set; }
        public List<Customer> Customers { get; set; }
        public List<ProductsOrders> Orders { get; set; }
        public Product()
        {
            Customers = new List<Customer>();
            Orders = new List<ProductsOrders>();
        }
        public Product(string id,string name, string description, decimal price, int availableQuantity,ProductType type)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            AvailableQuantity = availableQuantity;
            Type = type;
            Customers = new List<Customer>();
            Orders = new List<ProductsOrders>();
        }

    }
}