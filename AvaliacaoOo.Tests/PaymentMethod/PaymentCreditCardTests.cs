using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvaliacaoOo.PaymentMethod;

namespace AvaliacaoOo.Tests.PaymentMethod
{
    public class PaymentCreditCardTests
    {

        [Fact]
        public void CalculateFinalValue_GivenPositiveValue_ShouldNoDiscount()
        {
            // Arrange
            var paymentCreditCard = new PaymentCreditCard();
            decimal totalValue = 100m;
            decimal expectedValue = 100m;
            // Act
            var result = paymentCreditCard.CalculateFinalValue(totalValue);
            // Assert
            Assert.Equal(expectedValue, result);
        }

        [Fact]
        public void CalculateFinalValue_GivenZeroValue_ShouldReturnZero()
        {
            // Arrange
            var paymentCreditCard = new PaymentCreditCard();
            decimal totalValue = 0m;
            // Act
            var exception = Assert.Throws<Exception>(() => paymentCreditCard.CalculateFinalValue(totalValue));

            // Verificar a mensagem da exceção
            Assert.Equal("The total itens must be greater than zero or positive (Err.: 3).", exception.Message);
        }

        [Fact]
        public void CalculateFinalValue_GivenNegativeValue_ShouldReturnZero()
        {
            // Arrange
            var paymentCreditCard = new PaymentCreditCard();
            decimal totalValue = -100m;
            decimal expectedValue = 0m;
            // Act
            var exception = Assert.Throws<Exception>(() => paymentCreditCard.CalculateFinalValue(totalValue));

            // Assert
            Assert.Equal("The total itens must be greater than zero or positive (Err.: 3).", exception.Message);
        }
    }
}
