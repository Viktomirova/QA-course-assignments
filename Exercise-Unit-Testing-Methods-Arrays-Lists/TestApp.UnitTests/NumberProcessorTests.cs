using System;
using NUnit.Framework;

using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace TestApp.UnitTests;

public class NumberProcessorTests
{
    [Test]
    public void Test_ProcessNumbers_SquareEvenNumbers()
    {
        // Arrange
        List<int> input = new() { 2, 4, 6 };
        List<double> expected = new() { 4, 16, 36 };

        // Act
        List<double> actual = NumberProcessor.ProcessNumbers(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_ProcessNumbers_SquareRootOddNumbers()
    {
        // Arrange
        List<int> input = new() { 9, 25, 49 };
        List<double> expected = new() { 3, 5, 7 };

        // Act
        List<double> actual = NumberProcessor.ProcessNumbers(input);

        // Assert
        CollectionAssert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_ProcessNumbers_HandleZero()
    {
        // Arrange
        List<int> input = new() { 0 };
        List<int> expected = new() { 0 };

        // Act
        List<double> actual = NumberProcessor.ProcessNumbers(input);

        // Assert
        CollectionAssert.AreEquivalent(expected, actual, null);
        Assert.That(() => NumberProcessor.ProcessNumbers(input), Throws.Nothing);
    }

    [Test]
    public void Test_ProcessNumbers_HandleNegativeNumbers()
    {
        List<int> input = new() { -1, -9 };

        // Act & Assert
        Assert.Throws<ArgumentException>(() => NumberProcessor.ProcessNumbers(input));
    }

    [Test]
    public void Test_ProcessNumbers_EmptyInput()
    {
        // Arrange
        List<int> input = new() {  };

        // Act
        List<double> actual = NumberProcessor.ProcessNumbers(input);

        // Assert
        CollectionAssert.AreEquivalent(Enumerable.Empty<double>(), actual);
    }
}
