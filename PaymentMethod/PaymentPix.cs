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
            if (totalValue <= 0 || totalValue == null)
            {
                return 0;
            }
            return totalValue * 0.95m;
        }
    }
}
