using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class CountRealNumbersTests
{
    [Test]
    public void Test_Count_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        int[] array = Array.Empty<int>();

        // Act
        string result = CountRealNumbers.Count(array);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Count_WithSingleNumber_ShouldReturnCountString()
    {
        // Arrange
        int[] array = { 3 };

        // Act
        string result = CountRealNumbers.Count(array);

        // Assert
        Assert.That(result, Is.EqualTo("3 -> 1"));
    }

    [Test]
    public void Test_Count_WithMultipleNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] array = { 3, 2, 1, 1, 3, 3 };

        // Act
        string result = CountRealNumbers.Count(array);

        // Assert
        Assert.That(result, Is.EqualTo($"1 -> 2{Environment.NewLine}2 -> 1{Environment.NewLine}3 -> 3"));
    }

    [Test]
    public void Test_Count_WithNegativeNumbers_ShouldReturnCountString()
    {
        // Arrange
        int[] array = { -6, -5, -4, -4, -6, 6 };

        // Act
        string result = CountRealNumbers.Count(array);

        // Assert
        Assert.That(result, Is.EqualTo($"-6 -> 2{Environment.NewLine}-5 -> 1{Environment.NewLine}-4 -> 2{Environment.NewLine}6 -> 1"));
    }

    [Test]
    public void Test_Count_WithZero_ShouldReturnCountString()
    {
        // Arrange
        int[] array = { 0 };

        // Act
        string result = CountRealNumbers.Count(array);

        // Assert
        Assert.That(result, Is.EqualTo("0 -> 1"));
    }
}
