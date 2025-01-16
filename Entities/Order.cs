using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvaliacaoOo.Interfaces;
using Xunit.Sdk;

namespace AvaliacaoOo.Entities
{
    public class Order
    {
        public Customer Customer { get; private set; }
        public List<(Product product, int qtd)> Itens { get; private set; }

        public Order(Customer customer)
        {
            Customer = customer;
            Itens = new List<(Product, int)>();
        }

        public decimal FinishOrder(IPaymentMethod paymentMethod)
        {
            decimal totalValue = 0;

            if (paymentMethod == null || Itens == null || Itens.Count == 0)
            {
                //return 0;
                throw new Exception("The total itens must be greater than zero or positive (Err.: 1).");
            }

            foreach (var item in Itens)
            {
                totalValue += item.product.Price * item.qtd;
                if (item.qtd == 0 || item.product.Price <= 0)
                {
                    //return 0;
                    throw new Exception("The total itens must be greater than zero or positive (Err.: 2).");
                }
            }
            
            return paymentMethod.CalculateFinalValue(totalValue);
        }
    }
}

