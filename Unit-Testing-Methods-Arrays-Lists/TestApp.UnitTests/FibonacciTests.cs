using NUnit.Framework;
using static TestApp.Fibonacci;

namespace TestApp.UnitTests;

public class FibonacciTests
{
    [Test]
    public void Test_CalculateFibonacci_NegativeInput()
    {
        // Arrange
        int n = -1;

        // Act & Assert
        Assert.That(() => CalculateFibonacci(n), Throws.ArgumentException);
    }

    [Test]
    public void Test_CalculateFibonacci_ZeroInput()
    {
        // Arrange
        int n = 0;

        // Act
        int output = CalculateFibonacci(n);

        // Assert
        Assert.That(output, Is.EqualTo(0));
    }

    [Test]
    public void Test_CalculateFibonacci_PositiveInput()
    {
        // Arrange
        int n = 7;

        // Act
        int output = CalculateFibonacci(n);

        // Assert
        Assert.That(output, Is.EqualTo(13));    }
}