using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class NumberFrequencyTests
{
    [Test]
    public void Test_CountDigits_ZeroNumber_ReturnsEmptyDictionary()
    {
        // Arrange
        int number = 0;
        var expected = new Dictionary<int, int> { };

        // Act
        var result = NumberFrequency.CountDigits(number);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CountDigits_SingleDigitNumber_ReturnsDictionaryWithSingleEntry()
    {
        // Arrange
        int number = 3;
        var expected = new Dictionary<int, int> { { 3, 1 } };

        // Act
        var result = NumberFrequency.CountDigits(number);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CountDigits_MultipleDigitNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        int number = 3244;
        var expected = new Dictionary<int, int> { { 3, 1 }, { 2, 1 }, { 4, 2 } };

        // Act
        var result = NumberFrequency.CountDigits(number);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CountDigits_NegativeNumber_ReturnsDictionaryWithDigitFrequencies()
    {
        int number = -3;
        var expected = new Dictionary<int, int> { { 3, 1 } };

        // Act
        var result = NumberFrequency.CountDigits(number);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
