using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoOo.Entities
{
    internal class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public List<Product> Products { get; } = new List<Product>();

        public Order(Customer customer)
        {
            Customer = customer;
        }
    }
}
