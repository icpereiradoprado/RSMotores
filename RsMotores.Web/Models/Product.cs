using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RsMotores.Web.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string NameProduct { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Product()
        {

        }
        public Product(int id, string nameProduct, double price, int quantity)
        {
            Id = id;
            NameProduct = nameProduct;
            Price = price;
            Quantity = quantity;
        }
    }
}
