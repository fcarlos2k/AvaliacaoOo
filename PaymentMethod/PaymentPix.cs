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
            return totalValue * 0.95m;
        }
    }
}
