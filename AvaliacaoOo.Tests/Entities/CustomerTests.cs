using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AvaliacaoOo.Entities;

namespace AvaliacaoOo.Tests.Entities
{
    public class CustomerTests
    {
        [Fact]
        public void GivenAllParameters_ThenShouldSetTheProprietisCorrecly()
        {
            // Arrange
            var expectedId = 1;
            var expectedName = "Customer 1";
            
            // Act
            var customer = new Customer(expectedId, expectedName);

            // Assert
            Assert.Equal(expectedId, customer.Id);
            Assert.Equal(expectedName, customer.Name);
            
            Assert.IsType<int>(customer.Id);
            Assert.IsType<string>(customer.Name);
        }
    }
}
