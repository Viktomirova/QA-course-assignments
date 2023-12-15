using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class StringRotatorTests
{
    [Test]
    public void Test_RotateRight_EmptyString_ReturnsEmptyString()
    {
        // Arrange
        string input = string.Empty;

        // Act
        string result = StringRotator.RotateRight(input, 0);

        // Assert
        Assert.That(result, Is.EqualTo(input));
    }

    [Test]
    public void Test_RotateRight_RotateByZeroPositions_ReturnsOriginalString()
    {
        // Arrange
        string input = "abcde";

        // Act
        string result = StringRotator.RotateRight(input, 0);

        // Assert
        Assert.That(result, Is.EqualTo(input));
    }

    [Test]
    public void Test_RotateRight_RotateByPositivePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "abcde";

        // Act
        string result = StringRotator.RotateRight(input, 2);

        // Assert
        Assert.That(result, Is.EqualTo("deabc"));
    }

    [Test]
    public void Test_RotateRight_RotateByNegativePositions_ReturnsRotatedString()
    {
        // Arrange
        string input = "abcde";

        // Act
        string result = StringRotator.RotateRight(input, -1);

        // Assert
        Assert.That(result, Is.EqualTo("eabcd"));
    }

    [Test]
    public void Test_RotateRight_RotateByMorePositionsThanStringLength_ReturnsRotatedString()
    {
        // Arrange
        string input = "abcde";

        // Act
        string result = StringRotator.RotateRight(input, 6);

        // Assert
        Assert.That(result, Is.EqualTo("eabcd"));
    }

    [Test]
    public void Test_RotateRight_CheckStringLength_ReturnsLengthsAreEqual()
    {
        // Arrange
        string input = "abcde";

        // Act
        string result = StringRotator.RotateRight(input, 6);

        // Assert
        Assert.That(result.Length, Is.EqualTo(input.Length));
    }
}
