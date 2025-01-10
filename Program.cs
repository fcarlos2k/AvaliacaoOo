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

            order.Itens.Add((new Product (1, "Produto A", 0), 1));
            order.Itens.Add((new Product (2, "Produto B", 1000m),1));
            order.Itens.Add((new Product (3, "Produto C", 0m),1)); 


            IPaymentMethod paymentMethod = new PaymentPix(); 

            decimal totalValue = order.FinishOrder(paymentMethod);

            
            Console.WriteLine($"Customer: {customer.Name}");
            Console.WriteLine($"Total order: {totalValue:C}");
        }
    }
}