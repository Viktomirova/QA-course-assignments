using System;
using NUnit.Framework;

using System.Collections.Generic;
using System.Linq;

namespace TestApp.UnitTests;

public class MaxNumberTests
{
    [Test]
    public void Test_FindMax_InputIsNull_ShouldThrowArgumentException()
    {
        // Arrange
        List<int>? nullList = null;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => MaxNumber.FindMax(nullList));
    }

    [Test]
    public void Test_FindMax_InputIsEmptyList_ShouldThrowArgumentException()
    {
        // Arrange
        List<int> emptyList = new();

        // Act & Assert
        Assert.Throws<ArgumentException>(() => MaxNumber.FindMax(emptyList));
    }

    [Test]
    public void Test_FindMax_InputHasOneElement_ShouldReturnTheElement()
    {
        // Arrange
        List<int> list = new List<int>(){ 10 };

        // Act
        int maxNumber = MaxNumber.FindMax(list);

        // Assert
        Assert.That(maxNumber, Is.EqualTo(10));
    }

    [Test]
    public void Test_FindMax_InputHasPositiveIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new List<int>(){ 10, 20, 30, 100 };

        // Act
        int maxNumber = MaxNumber.FindMax(list);

        // Assert
        Assert.That(maxNumber, Is.EqualTo(100));
    }

    [Test]
    public void Test_FindMax_InputHasNegativeIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new List<int>(){ -10, -20, -30, -100 };

        // Act
        int maxNumber = MaxNumber.FindMax(list);

        // Assert
        Assert.That(maxNumber, Is.EqualTo(-10));
    }

    [Test]
    public void Test_FindMax_InputHasMixedIntegers_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new List<int>(){ -10, 20, -30, 100 };

        // Act
        int maxNumber = MaxNumber.FindMax(list);

        // Assert
        Assert.That(maxNumber, Is.EqualTo(100));
    }

    [Test]
    public void Test_FindMax_InputHasDuplicateMaxValue_ShouldReturnMaximum()
    {
        // Arrange
        List<int> list = new List<int>(){ 1, 2, 3, 10, 4, 5, 10 };

        // Act
        int maxNumber = MaxNumber.FindMax(list);

        // Assert
        Assert.That(maxNumber, Is.EqualTo(10));
    }
}
