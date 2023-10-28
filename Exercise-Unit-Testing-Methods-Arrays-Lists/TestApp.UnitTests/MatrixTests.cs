﻿using System;
using NUnit.Framework;

using System.Collections.Generic;

namespace TestApp.UnitTests;

public class MatrixTests
{
    // TODO: finish test
    [Test]
    public void Test_MatrixAddition_ValidInput_ReturnsCorrectResult()
    {
        // Arrange
        List<List<int>> matrixA = new() { new() { 1, 2 }, new() { 3, 4 } };
        List<List<int>> matrixB = new() { new() { 5, 6 }, new() { 7, 8 } };
        List<List<int>> expected = new() { new() { 6, 8 }, new() { 10, 12 } };

        // Act
        List<List<int>> result = Matrix.MatrixAddition(matrixA, matrixB);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_MatrixAddition_EmptyMatrices_ReturnsEmptyMatrix()
    {
        // Arrange
        List<List<int>> matrixA = new();
        List<List<int>> matrixB = new();

        // Act & Assert
        Assert.That(() => Matrix.MatrixAddition(matrixA, matrixB), Is.Empty);
    }

    [Test]
    public void Test_MatrixAddition_DifferentDimensions_ThrowsArgumentException()
    {
        // Arrange
        List<List<int>> matrixA = new() { new() { 1, 2 }, new() { 3, 4 } };
        List<List<int>> matrixB = new() { new() { 1, 2, 0 }, new() { 3, 4 } };

        // Act & Assert
        Assert.Throws<ArgumentException>(() => Matrix.MatrixAddition(matrixA, matrixB));
    }

    [Test]
    public void Test_MatrixAddition_NegativeNumbers_ReturnsCorrectResult()
    {
        // Arrange
        List<List<int>> matrixA = new() { new() { 1, 2 }, new() { 3, 4 } };
        List<List<int>> matrixB = new() { new() { -5, 6 }, new() { -2, 8 } };
        List<List<int>> expected = new() { new() { -4, 8 }, new() { 1, 12 } };

        // Act
        List<List<int>> result = Matrix.MatrixAddition(matrixA, matrixB);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_MatrixAddition_ZeroMatrix_ReturnsOriginalMatrix()
    {
        // Arrange
        List<List<int>> matrixA = new() { new() { 1, 2 }, new() { 3, 4 } };
        List<List<int>> matrix0 = new() { new() { 0, 0 }, new() { 0, 0 } };


        // Act
        List<List<int>> result = Matrix.MatrixAddition(matrixA, matrix0);

        // Assert
        Assert.That(result, Is.EqualTo(matrixA));
    }
}
