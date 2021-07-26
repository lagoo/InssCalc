using ConsoleApp.Implementations;
using ConsoleApp.Interfaces;
using FluentAssertions;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ConsoleAppTests.Implementations
{
    public class CalculadorInssTests
    { 
        [Fact()]
        public void HasAliquot_WageOverCelling_ShouldReturnFalse()
        {
            //Arrange
            Mock<IAliquotService> mock = new();
            mock.Setup(e => e.HasAliquot(It.IsAny<int>(), It.IsAny<decimal>())).Returns(true);
            mock.Setup(e => e.Celling).Returns(500);

            CalculadorInss _stu = new CalculadorInss(mock.Object);

            // Act
            var result = _stu.CalcularDesconto(new DateTime(2011,1,1), 5000);

            // Assert
            result.Should().Be(500m);
        }

        [Fact()]
        public void HasAliquot_WageBellowCelling_ShouldReturnTrue()
        {
            //Arrange
            Mock<IAliquotService> mock = new();
            mock.Setup(e => e.HasAliquot(It.IsAny<int>(), It.IsAny<decimal>())).Returns(false);
            mock.Setup(e => e.Aliquot).Returns(8.00m);

            CalculadorInss _stu = new CalculadorInss(mock.Object);

            // Act
            var result = _stu.CalcularDesconto(new DateTime(2011, 1, 1), 1000);

            // Assert
            result.Should().Be(80);
        }
    }
}
