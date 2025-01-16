using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvaliacaoOo.PaymentMethod;

namespace AvaliacaoOo.Tests.PaymentMethod
{
    public class PaymentPixTests
    {

        [Fact]
        public void CalculateFinalValue_GivenPositiveValue_ShouldApplyDiscount()
        {
            // Arrange
            var paymentPix = new PaymentPix();
            decimal totalValue = 100m;
            decimal expectedValue = 95m;

            // Act
            var result = paymentPix.CalculateFinalValue(totalValue);

            // Assert
            Assert.Equal(expectedValue, result);
        }

        [Fact]
        public void CalculateFinalValue_GivenZeroValue_ShouldReturnZero()
        {
            // Arrange
            var paymentPix = new PaymentPix();
            decimal totalValue = 0m;

            // Act
            var exception = Assert.Throws<Exception>(() => paymentPix.CalculateFinalValue(totalValue));

            //Assert
            Assert.Equal("The total itens must be greater than zero or positive (Err.: 4).", exception.Message);
        }

        [Fact]
        public void CalculateFinalValue_GivenNegativeValue_ShouldReturnZero()
        {
            // Arrange
            var paymentPix = new PaymentPix();
            decimal totalValue = -100m;
            decimal expectedValue = 0;

            // Act
            var exception = Assert.Throws<Exception>(() => paymentPix.CalculateFinalValue(totalValue));

            // Assert
            Assert.Equal("The total itens must be greater than zero or positive (Err.: 4).", exception.Message);
        }


    }
}
