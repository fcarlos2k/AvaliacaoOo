using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvaliacaoOo.Interfaces;

namespace AvaliacaoOo.PaymentMethod
{
    public class PaymentPix : IPaymentMethod
    {
        public decimal CalculateFinalValue(decimal totalValue)
        {
            if (totalValue <= 0)
            {
                throw new Exception("The total itens must be greater than zero or positive (Err.: 4).");
            }
            return totalValue * 0.95m;
        }
    }
}
