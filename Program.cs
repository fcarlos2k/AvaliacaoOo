using System;
using AvaliacaoOo.Entities;

namespace AvaliacaoOo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Criar um cliente
            var customer = new Customer (1, "João da Silva");

            // Criar um pedido
            var order = new Order();
            pedido.Produtos.Add(new Produto(1, "Produto A", 10));
            pedido.Produtos.Add(new Produto(2, "Produto B", 20));

            // Escolher a forma de pagamento (pode ser alterada para qualquer outra que implemente IPaymentMethod)
            IFormaPagamento formaPagamento = new PixPagamento();

            // Concluir o pedido e obter o valor total
            decimal valorTotal = pedido.Concluir(formaPagamento);

            // Exibir o valor total
            Console.WriteLine($"Valor total a ser pago: R$ {valorTotal}");
        }
    }
}