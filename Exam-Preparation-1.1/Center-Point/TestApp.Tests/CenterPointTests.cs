using System;
using NUnit.Framework;

namespace TestApp.Tests;

public class CenterPointTests
{
    [Test]
    public void Test_GetClosest_WhenFirstPointIsCloser_ShouldReturnFirstPoint()
    {
        // Arrange
        double x1 = 1;
        double y1 = 1;
        double x2 = 2;
        double y2 = 1;
        double firstPoint = Math.Abs(x1) + Math.Abs(y1);
        string firstPointReport = $"({string.Join(", ", x1, y1)})";

        // Act
        string result = CenterPoint.GetClosest(x1, y1, x2, y2);

        // Assert
        Assert.That(result, Is.EqualTo(firstPointReport));
    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsCloser_ShouldReturnSecondPoint()
    {
        // Arrange
        double x1 = 3;
        double y1 = 1;
        double x2 = 2;
        double y2 = 1;
        double secondPoint = Math.Abs(x2) + Math.Abs(y2);
        string secondPointReport = $"({string.Join(", ", x2, y2)})";

        // Act
        string result = CenterPoint.GetClosest(x1, y1, x2, y2);

        // Assert
        Assert.That(result, Is.EqualTo(secondPointReport));
    }

    [Test]
    public void Test_GetClosest_WhenBothPointsHaveEqualDistance_ShouldReturnFirstPoint()
    {
        // Arrange
        double x1 = 1;
        double y1 = 2;
        double x2 = 1;
        double y2 = 2;
        double firstPoint = Math.Abs(x1) + Math.Abs(y1);
        string firstPointReport = $"({string.Join(", ", x1, y1)})";

        // Act
        string result = CenterPoint.GetClosest(x1, y1, x2, y2);

        // Assert
        Assert.That(result, Is.EqualTo(firstPointReport));
    }

    [Test]
    public void Test_GetClosest_WhenFirstPointIsNegative_ShouldReturnFirstPoint()
    {
        // Arrange
        double x1 = -1;
        double y1 = -1;
        double x2 = 1;
        double y2 = 1;
        double firstPoint = Math.Abs(x1) + Math.Abs(y1);
        string firstPointReport = $"({string.Join(", ", x1, y1)})";

        // Act
        string result = CenterPoint.GetClosest(x1, y1, x2, y2);

        // Assert
        Assert.That(result, Is.EqualTo(firstPointReport));

    }

    [Test]
    public void Test_GetClosest_WhenSecondPointIsNegative_ShouldReturnSecondPoint()
    {
        // Arrange
        double x1 = 1;
        double y1 = 1;
        double x2 = -1;
        double y2 = -1;
        double secondPoint = Math.Abs(x2) + Math.Abs(y2);
        string secondPointReport = $"({string.Join(", ", x2, y2)})";

        // Act
        string result = CenterPoint.GetClosest(x1, y1, x2, y2);

        // Assert
        Assert.That(result, Is.EqualTo(secondPointReport));
    }
}
