using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class FoldSumTests
{
    [Test]
    [TestCase(new int[]{1, 2, 3, 4, 5, 6, 7, 8}, "5 5 13 13")]
    [TestCase(new int[]{1, 1, 1, 1, 1, 1, 1, 1}, "2 2 2 2")]
    [TestCase(new int[]{1, 2, 3, 4}, "3 7")]
    [TestCase(new int[]{0, 0, 0, 0,}, "0 0")]
    [TestCase(new int[]{}, "")]
    public void Test_FoldArray_ReturnsCorrectString(int[] arr, string expected)
    {
        // Arrange

        // Act
        string result = FoldSum.FoldArray(arr);

        // Assert
        Assert.That(expected, Is.EqualTo(result));

    }
}
