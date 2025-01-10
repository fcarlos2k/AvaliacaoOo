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
        public Customer Customer { get; set; }
        public List<(Product product, int qtd)> Itens { get; set; }

        public Order(Customer customer)
        {
            Customer = customer;
            Itens = new List<(Product, int)>();
        }

        public decimal FinishOrder(IPaymentMethod paymentMethod)
        {
            decimal totalValue = 0;

            foreach (var item in Itens)
            {
                totalValue += item.product.Price * item.qtd;
            }
            return paymentMethod.CalculateFinalValue(totalValue);
        }
    }
}

