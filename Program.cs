using System;
using AvaliacaoOo.Entities;
using AvaliacaoOo.Interfaces;
using AvaliacaoOo.PaymentMethod;

namespace AvaliacaoOo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var customer = new Customer(1, "Customer 01");

                var order = new Order(customer);

                order.Itens.Add((new Product(1, "Produto A", 100), 0));
                //order.Itens.Add((new Product(2, "Produto B", 100), 1));
                //order.Itens.Add((new Product(3, "Produto C", 100), 1));


                IPaymentMethod paymentMethod = new PaymentPix();
                //IPaymentMethod paymentMethod = new PaymentCreditCard();

                decimal totalValue = order.FinishOrder(paymentMethod);

                Console.WriteLine($"Customer: {customer.Name}");
                Console.WriteLine($"Total order: {totalValue:C}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}