using System;
using System.Collections.Generic;
using System.Text;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class GradesTests
{
    [Test]
    public void Test_GetBestStudents_ReturnsBestThreeStudents()
    {
        // Arrange
        Dictionary<string, int> grades = new Dictionary<string, int>()
        {
            { "Gosho", 6 },
            { "Pesho", 5 },
            { "Tosho", 2 },
            { "Misho", 4 },
            { "Sasho", 6 }
        };
        StringBuilder sb = new();
        sb.AppendLine($"Gosho with average grade 6.00");
        sb.AppendLine($"Sasho with average grade 6.00");
        sb.AppendLine($"Pesho with average grade 5.00");
        string expected = sb.ToString().Trim();

        // Act
        string result = Grades.GetBestStudents(grades);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_EmptyGrades_ReturnsEmptyString()
    {
        // Arrange
        Dictionary<string, int> grades = new Dictionary<string, int>();
        string expected = String.Empty;

        // Act
        string result = Grades.GetBestStudents(grades);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_LessThanThreeStudents_ReturnsAllStudents()
    {
        Dictionary<string, int> grades = new Dictionary<string, int>()
        {
            { "Gosho", 6 },
            { "Sasho", 6 }
        };
        StringBuilder sb = new();
        sb.AppendLine($"Gosho with average grade 6.00");
        sb.AppendLine($"Sasho with average grade 6.00");
        string expected = sb.ToString().Trim();

        // Act
        string result = Grades.GetBestStudents(grades);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetBestStudents_SameGrade_ReturnsInAlphabeticalOrder()
    {
        Dictionary<string, int> grades = new Dictionary<string, int>()
        {
            { "Sasho", 6 },
            { "Gosho", 6 },
        };
        StringBuilder sb = new();
        sb.AppendLine($"Gosho with average grade 6.00");
        sb.AppendLine($"Sasho with average grade 6.00");
        string expected = sb.ToString().Trim();

        // Act
        string result = Grades.GetBestStudents(grades);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
