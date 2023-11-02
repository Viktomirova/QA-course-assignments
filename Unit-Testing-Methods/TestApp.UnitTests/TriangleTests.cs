using NUnit.Framework;

namespace TestApp.UnitTests;

public class TriangleTests
{
    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size0()
    {
        // Arrange
        int size = 0;

        // Act
        string triangle = Triangle.PrintTriangle(size);

        // Assert
        Assert.That(triangle.Length.Equals(0));
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size3()
    {
        // Arrange
        int size = 3;
        string expected = "1\r\n1 2\r\n1 2 3\r\n1 2\r\n1";

        // Act
        string actual = Triangle.PrintTriangle(size);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    public void Test_Triangle_OutputMatchesExpected_Size5()
    {
        // Arrange
        int size = 5;
        string expected = "1\r\n1 2\r\n1 2 3\r\n1 2 3 4\r\n1 2 3 4 5\r\n1 2 3 4\r\n1 2 3\r\n1 2\r\n1";

        // Act
        string actual = Triangle.PrintTriangle(size);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
