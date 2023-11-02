using System;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class StringReverseTests
{
    [Test]
    public void Test_Reverse_WhenGivenEmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = String.Empty;

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.IsEmpty(actual);
    }

    [Test]
    public void Test_Reverse_WhenGivenSingleCharacterString_ReturnsSameCharacter()
    {
        // Arrange
        string input = "d";

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.That(actual, Is.EqualTo(input));
    }

    [Test]
    public void Test_Reverse_WhenGivenNormalString_ReturnsReversedString()
    {
        // Arrange
        string input = "kamino";
        string expected = "onimak";

        // Act
        string actual = StringReverse.Reverse(input);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
