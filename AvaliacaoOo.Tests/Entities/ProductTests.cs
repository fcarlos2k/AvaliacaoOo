using AvaliacaoOo.Entities;
using Xunit.Abstractions;

namespace AvaliacaoOo.AvaliacaoOo.Tests
{
    public class ProductTests
    {
        [Fact]
        public void Constructor_GivenAllParameters_ThenShouldSetTheProprietisCorrecly()
        {
            // Arrange
            var expectedId = 1;
            var expectedName = "Product 1";
            var expectedPrice = 10.0m;

            // Act
            var product = new Product(expectedId, expectedName, expectedPrice);

            // Assert
            Assert.Equal(expectedId, product.Id);
            Assert.Equal(expectedName, product.Name);
            Assert.Equal(expectedPrice, product.Price);

            Assert.IsType<int>(product.Id);
            Assert.IsType<string>(product.Name);
            Assert.IsType<decimal>(product.Price);
        }
    }
}