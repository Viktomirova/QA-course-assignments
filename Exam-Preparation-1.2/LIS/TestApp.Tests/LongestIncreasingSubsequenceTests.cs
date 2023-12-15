using NUnit.Framework;
using System;
using System.Xml.Linq;

namespace TestApp.Tests;

public class LongestIncreasingSubsequenceTests
{
    [Test]
    public void Test_GetLis_NullArray_ThrowsArgumentNullException()
    {
        // Arrange
        int[]? array = null;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => LongestIncreasingSubsequence.GetLis(array));
    }

    [Test]
    public void Test_GetLis_EmptyArray_ReturnsEmptyString()
    {
        // Arrange
        int[] array = Array.Empty<int>();

        // Act
        string result = LongestIncreasingSubsequence.GetLis(array);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_GetLis_SingleElementArray_ReturnsElement()
    {
        // Arrange
        int element = 20;
        int[] array = {element};

        // Act
        string result = LongestIncreasingSubsequence.GetLis(array);

        // Assert
        Assert.That(result, Is.EqualTo(element.ToString()));
    }

    [Test]
    public void Test_GetLis_UnsortedArray_ReturnsLongestIncreasingSubsequence()
    {
        // Arrange
        int[] array = new int[]{ 9, 4, 3, 5, 1, 8, 2};
        string expected = "4 5 8";

        // Act
        string result = LongestIncreasingSubsequence.GetLis(array);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetLis_SortedArray_ReturnsItself()
    {
        // Arrange
        int[] array = new int[]{ 1, 2, 3, 4, 5 };
        string expected = "1 2 3 4 5";

        // Act
        string result = LongestIncreasingSubsequence.GetLis(array);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}