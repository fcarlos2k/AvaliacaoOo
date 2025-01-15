using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvaliacaoOo.Entities;
using AvaliacaoOo.Interfaces;
using Moq;


namespace AvaliacaoOo.Tests.Entities
{
    public class OrderTests
    {

        [Fact]
        public void Constructor_GivenValidCustomer_ShouldInitializeOrderCorrectly()
        {
            // Arrange
            var customer = new Customer(1, "Cliente 01");

            // Act
            var order = new Order(customer);

            // Assert
            Assert.Equal(customer, order.Customer);
            Assert.NotNull(order.Itens);
            Assert.Empty(order.Itens);
        }

        [Fact]
        public void FinishOrder_GivenNullPaymentMethod_ShouldReturnZero()
        {
            // Arrange
            var customer = new Customer(1, "Cliente 01");
            var order = new Order(customer);

            // Act
            var result = order.FinishOrder(null);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void FinishOrder_GivenEmptyItems_ShouldReturnZero()
        {
            // Arrange
            var customer = new Customer(1, "Cliente 01");
            var order = new Order(customer);
            var paymentMethod = new Mock<IPaymentMethod>().Object;

            // Act
            var result = order.FinishOrder(paymentMethod);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void FinishOrder_GivenItemWithZeroQuantity_ShouldReturnZero()
        {
            // Arrange
            var customer = new Customer(1, "Cliente 01");
            var order = new Order(customer);
            order.Itens.Add((new Product(1, "Notebook", 3000m), 0));
            var paymentMethod = new Mock<IPaymentMethod>().Object;

            // Act
            var result = order.FinishOrder(paymentMethod);

            // Assert
            Assert.Equal(0, result);
        }

        [Fact]
        public void FinishOrder_GivenValidItemsAndPaymentMethodPix_ShouldReturnCorrectValue()
        {
            // Arrange
            var customer = new Customer(1, "Cliente 01");
            var order = new Order(customer);
            order.Itens.Add((new Product(1, "Notebook", 500m), 1)); 
            order.Itens.Add((new Product(2, "Mouse", 500m), 1)); 

            var paymentMethodMock = new Mock<IPaymentMethod>();
            paymentMethodMock.Setup(m => m.CalculateFinalValue(1000m)).Returns(950m); 

            // Act
            var result = order.FinishOrder(paymentMethodMock.Object);

            // Assert
            Assert.Equal(950m, result);
        }

        [Fact]
        public void FinishOrder_GivenValidItemsAndPaymentMethodCreditCard_ShouldReturnCorrectValue()
        {
            // Arrange
            var customer = new Customer(1, "Cliente 01");
            var order = new Order(customer);
            order.Itens.Add((new Product(1, "Notebook", 3000m), 1));
            order.Itens.Add((new Product(2, "Mouse", 150m), 1));

            var paymentMethodMock = new Mock<IPaymentMethod>();
            paymentMethodMock.Setup(m => m.CalculateFinalValue(3150m)).Returns(3150m);

            // Act
            var result = order.FinishOrder(paymentMethodMock.Object);

            // Assert
            Assert.Equal(3150m, result);
        }




    }
}
