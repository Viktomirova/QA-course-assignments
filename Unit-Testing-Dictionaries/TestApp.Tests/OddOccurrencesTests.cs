using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class OddOccurrencesTests
{
    [Test]
    public void Test_FindOdd_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] words = Array.Empty<string>();

        // Act
        string result = OddOccurrences.FindOdd(words);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindOdd_WithNoOddOccurrences_ShouldReturnEmptyString()
    {
        // Arrange
        string[] words = new []{"even", "even"};

        // Act
        string result = OddOccurrences.FindOdd(words);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_FindOdd_WithSingleOddOccurrence_ShouldReturnTheOddWord()
    {
        // Arrange
        string[] words = new []{"odd", "odd", "Odd"};

        // Act
        string result = OddOccurrences.FindOdd(words);

        // Assert
        Assert.That(result, Is.EqualTo("odd"));
    }

    [Test]
    public void Test_FindOdd_WithMultipleOddOccurrences_ShouldReturnAllOddWords()
    {
        // Arrange
        string[] words = new []{"odd", "odd", "Odd", "even", "even"};

        // Act
        string result = OddOccurrences.FindOdd(words);

        // Assert
        Assert.That(result, Is.EqualTo("odd"));
    }

    [Test]
    public void Test_FindOdd_WithMixedCaseWords_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] words = new []{"odd", "odd", "Odd", "even", "even"};

        // Act
        string result = OddOccurrences.FindOdd(words);

        // Assert
        Assert.That(result, Is.EqualTo("odd"));
    }
}
