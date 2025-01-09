using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoOo.Entities
{
    internal class Customer
    {
        int Id { get; set; }
        string Name { get; set; }

        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public Customer()
        {           
        }
    }
}
