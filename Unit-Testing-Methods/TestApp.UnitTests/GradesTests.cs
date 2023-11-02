using System.Xml.Serialization;
using NUnit.Framework;

namespace TestApp.UnitTests;

public class GradesTests
{
    [Test]
    [TestCase(3.49, "Average")]
    [TestCase(3.50, "Good")]
    [TestCase(2.00, "Fail")]
    [TestCase(5.50, "Excellent")]
    public void Test_GradeAsWords_ReturnsCorrectString(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }

    [Test]
    [TestCase(1, "Invalid!")]
    [TestCase(7, "Invalid!")]
    public void Test_GradeAsWords_ReturnsCorrectString_EdgeCases(double grade, string expected)
    {
        // Arrange

        // Act
        string actual = Grades.GradeAsWords(grade);

        // Assert
        Assert.AreEqual(expected, actual);
    }
}
