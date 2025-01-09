using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaliacaoOo.Interfaces
{
    public interface IPaymentMethod
    {
        decimal MakePayment(decimal totalValue);

    }
}
