using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoOo.Entities
{
    internal class Product
    {
        int Id { get; set; }
        string Name { get; set; }
        double Price { get; set; }
        int Quantity { get; set; }
        public Product(int id, string name, double price, int quantity)
        {
            Id = id;
            Name = name;
            Price = price;
            Quantity = quantity;
        }
        public Product()
        {
        }
    }
}
