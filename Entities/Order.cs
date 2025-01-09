using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvaliacaoOo.Interfaces;

namespace AvaliacaoOo.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public Customer Customer { get; set; }
        public List<Product> Products { get; set; } = new List<Product>();

        public Order(Customer customer)
        {
            Customer = customer;
        }

        public decimal finishPayment(IPaymentMethod paymentMethod)
        {
            decimal finalValue = Products.Sum(p => p.Preco);
            decimal finalValue = formaPagamento.CalcularValor(valorBase);
            return finalValue;
        }
    }
}
