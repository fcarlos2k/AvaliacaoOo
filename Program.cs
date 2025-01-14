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
            var customer = new Customer(1, "Customer 01"); 

            var order = new Order(customer);

            order.Itens.Add((new Product (1, "Produto A", 200), 5));
            order.Itens.Add((new Product (2, "Produto B", 1000),1));
            order.Itens.Add((new Product (3, "Produto C", 100),1)); 


            //IPaymentMethod paymentMethod = new PaymentPix();
            IPaymentMethod paymentMethod = new PaymentCreditCard();

            decimal totalValue = order.FinishOrder(paymentMethod);

            if (totalValue == 0)
            {
                Console.WriteLine("Order not finished");
                return;
            }
            Console.WriteLine($"Customer: {customer.Name}");
            Console.WriteLine($"Total order: {totalValue:C}");
        }
    }
}