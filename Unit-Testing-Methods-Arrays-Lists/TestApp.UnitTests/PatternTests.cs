using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class PatternTests
{
    [Test]
    public void Test_SortInPattern_NullInput_ThrowsException()
    {
        // Arrange
        int[]? inputArray = null;

        // Act + Assert
        Assert.That(() => Pattern.SortInPattern(inputArray), Throws.ArgumentException);
    }

    [Test]
    public void Test_SortInPattern_SortsIntArrayInPattern_SortsCorrectly()
    {
        // Arrange
        int[] input = {1, 2, 3, 4};

        // Act
        int[] output = Pattern.SortInPattern(input);

        // Assert
        Assert.That(output, Is.EqualTo(new int[] {1, 4, 2, 3}));
    }

    [Test]
    public void Test_SortInPattern_EmptyArray_ReturnsEmptyArray()
    {
        // Arrange
        int[] input = Array.Empty<int>();

        // Act
        int[] output = Pattern.SortInPattern(input);

        // Assert
        Assert.That(output, Is.Empty);
    }

    [Test]
    public void Test_SortInPattern_SingleElementArray_ReturnsSameArray()
    {
        // Arrange
        int[] input = {1};

        // Act
        int[] output = Pattern.SortInPattern(input);

        // Assert
        Assert.That(output, Is.EqualTo(input));
    }
}
