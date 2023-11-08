using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Customer
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        public int? Age { get; set; }
        public List<Product> FavouriteProducts { get; set; }
        public List<Order> Orders { get; set; }
        public Customer()
        {
            FavouriteProducts = new List<Product>();
            Orders = new List<Order>();
        }

        public Customer(string firstName,string lastName, string address, int? age = null)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Age = age;
            FavouriteProducts = new List<Product>();
            Orders= new List<Order>();
        }

    }
}
