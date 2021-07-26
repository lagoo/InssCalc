using ConsoleApp.Implementations;
using ConsoleApp.Models;
using FluentAssertions;
using Microsoft.Extensions.Options;
using Moq;
using System;
using Xunit;

namespace ConsoleAppTests.Implementations
{
    public class AliquotServiceTests
    {
        private readonly AliquotService _stu;

        public AliquotServiceTests()
        {
            Mock<IOptionsSnapshot<InssConfig>> mock = new();
            mock.Setup(e => e.Value).Returns(InssConfigFactory.Config);

            _stu = new AliquotService(mock.Object);
        }

        [Fact()]
        public void HasAliquot_InvalidYear_ShouldThrowException()
        {
            // Arrange & Act & Assert
            Assert.ThrowsAny<Exception>(() => _stu.HasAliquot(2000, 1000));
        }

        [Fact()]
        public void HasAliquot_WageOverCelling_ShouldReturnFalse()
        {
            // Arrange & Act
            var result = _stu.HasAliquot(2012, 5000);

            // Assert
            result.Should().BeFalse();
            _stu.Celling.Should().Be(500);
        }

        [Fact()]
        public void HasAliquot_WageBellowCelling_ShouldReturnTrue()
        {
            // Arrange & Act
            var result = _stu.HasAliquot(2012, 1000);

            // Assert
            result.Should().BeTrue();
            _stu.Aliquot.Should().Be(7.00m);
        }
    }
}
