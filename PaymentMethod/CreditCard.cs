using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvaliacaoOo.Interfaces;

namespace AvaliacaoOo.PaymentMethod
{
    public class CreditCard :IPaymentMethod
    {
        public decimal MakePayment(decimal totalValue)
        {
            // Lógica para calcular valor com juros, parcelamento, etc.
            return totalValue * 1.1m; // Simulação de juros de 10%
        }
    }
}
