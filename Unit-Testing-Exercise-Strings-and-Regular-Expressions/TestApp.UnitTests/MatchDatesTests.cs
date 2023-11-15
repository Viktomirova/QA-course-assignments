using NUnit.Framework;
using System;

namespace TestApp.UnitTests;

public class MatchDatesTests
{
    [Test]
    public void Test_Match_ValidDate_ReturnsExpectedResult()
    {
        // Arrange
        string input = "31/Dec/2022";
        string expected = "Day: 31, Month: Dec, Year: 2022";

        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_NoMatch_ReturnsEmptyString()
    {
        // Arrange
        string input = "14/11/1961, 1/Feb/2016";

        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.IsEmpty(result); 
    }

    [Test]
    public void Test_Match_MultipleMatches_ReturnsFirstMatch()
    {
        // Arrange
        string input = "12-Apr-1961, 04/May/2015, 31-May-1956, 19/Jun-1968, 01.Jan.1918";
        string expected = "Day: 12, Month: Apr, Year: 1961";

        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Match_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;

        // Act
        string result = MatchDates.Match(input);

        // Assert
        Assert.IsEmpty(result);
    }

    [Test]
    public void Test_Match_NullInput_ThrowsArgumentException()
    {
        // Arrange
        string input = null;

        // Act + Assert
        Assert.Throws<ArgumentException>(() => MatchDates.Match(input));
    }
}