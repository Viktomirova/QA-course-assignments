using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class CharacterRangeTests
{
    [Test]
    public void Test_GetRange_WithAAndBInOrder_ReturnsEmptyString()
    {
        // Arrange
        char a = 'a';
        char b = 'b';
        string expected = string.Empty;

        // Act
        string result = CharacterRange.GetRange(a, b);

        // Assert
        Assert.That(expected, Is.EqualTo(result));
        Assert.IsEmpty(result);
    }

    [Test]
    public void Test_GetRange_WithBAndAInOrder_ReturnsEmptyString()
    {
        // Arrange
        char a = 'B';
        char b = 'A';
        string expected = string.Empty;

        // Act
        string result = CharacterRange.GetRange(a, b);

        // Assert
        Assert.That(expected, Is.EqualTo(result));
        Assert.IsEmpty(result);
    }

    [Test]
    public void Test_GetRange_WithAAndCInOrder_ReturnsB()
    {
        // Arrange
        char a = 'A';
        char b = 'C';
        string expected =  "B" ;

        // Act
        string result = CharacterRange.GetRange(a, b);

        // Assert
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_GetRange_WithDAndGInOrder_Returns_E_F()
    {
        // Arrange
        char a = 'D';
        char b = 'G';
        string expected =  "E F" ;

        // Act
        string result = CharacterRange.GetRange(a, b);

        // Assert
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_GetRange_WithXAndZInOrder_Returns_Y()
    {
        // Arrange
        char a = 'X';
        char b = 'Z';
        string expected =  "Y" ;

        // Act
        string result = CharacterRange.GetRange(a, b);

        // Assert
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_GetRange_WithAnySymbolsInOrder_Returns_RightResult()
    {
        // Arrange
        char a = '<';
        char b = '>';
        string expected =  "=" ;

        // Act
        string result = CharacterRange.GetRange(a, b);

        // Assert
        Assert.That(expected, Is.EqualTo(result));
    }
}