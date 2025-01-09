using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvaliacaoOo.Interfaces;

namespace AvaliacaoOo.PaymentMethod
{
    public class Pix : IPaymentMethod
    {
        public decimal MakePayment(decimal totalValue)
        {
            return totalValue * 0.95m;
        }
    }
}
