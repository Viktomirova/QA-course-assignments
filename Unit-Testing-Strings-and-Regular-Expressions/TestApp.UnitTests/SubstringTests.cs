using System;
using System.Linq;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class SubstringTests
{
    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromMiddle()
    {
        // Arrange
        string toRemove = "fox";
        string input = "The quick brown fox jumps over the lazy dog";

        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.That(result, Is.EqualTo("The quick brown jumps over the lazy dog"));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromStart()
    {
        // Arrange
        string input = "The quick brown fox jumps over the lazy dog";
        string toRemove = input.Substring(0, 10);

        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.That(result, Is.EqualTo("brown fox jumps over the lazy dog"));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesSubstringFromEnd()
    {
        // Arrange
        string input = "The quick brown fox jumps over the lazy dog";
        string toRemove = input.Substring(input.Length - 10, 10);

        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.That(result, Is.EqualTo("The quick brown fox jumps over th"));
    }

    [Test]
    public void Test_RemoveOccurrences_RemovesAllOccurrences()
    {
        // Arrange
        string input = "The quick brown fox jumps over the lazy dog";
        string toRemove = "the";

        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.That(result, Is.EqualTo("quick brown fox jumps over lazy dog"));
    }

    
    [Test]
    public void Test_RemoveOccurrences_RemovesAllOccurrences_ReturnEmptyString()
    {
        // Arrange
        string input = "cat cat cat cat cat cat cat ";
        string toRemove = "cat";

        // Act
        string result = Substring.RemoveOccurrences(toRemove, input);

        // Assert
        Assert.That(result, Is.EqualTo(string.Empty));
    }

}
