using System;

using NUnit.Framework;

namespace TestApp.UnitTests;

public class FactorialTests
{
    [Test]
    public void CalculateFactorial_InputZero_ReturnsOne()
    {
        // Arrange
        int num = 0;

        // Act
        int result = Factorial.CalculateFactorial(num);

        // Assert
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void CalculateFactorial_InputPositiveNumber_ReturnsCorrectFactorial()
    {
        // Arrange
        int num = 4;

        // Act
        int result = Factorial.CalculateFactorial(num);

        // Assert
        Assert.That(result, Is.EqualTo(24));
    }

    [Test]
    public void CalculateFactorial_InputNegativeNumber_ThrowsException()
    {
        // Arrange
        int num = -1;

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => Factorial.CalculateFactorial(num));
    }
}
