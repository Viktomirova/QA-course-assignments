using NUnit.Framework;
using System;

namespace TestApp.Tests;

public class ExtractFileTests
{
    [Test]
    public void Test_GetFile_NullPath_ThrowsArgumentNullException()
    {
        // Arrange
        string? path = null;

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => ExtractFile.GetFile(path));
    }

    [Test]
    public void Test_GetFile_EmptyPath_ThrowsArgumentNullException()
    {
        // Arrange
        string path = "";

        // Act & Assert
        Assert.Throws<ArgumentNullException>(() => ExtractFile.GetFile(path));
    }

    [Test]
    public void Test_GetFile_ValidPath_ReturnsFileNameAndExtension()
    {
        // Arrange
        string path = "C:\\Work\\SoftUni\\QA\\Exercise.cs";
        string expected = "File name: Exercise\nFile extension: cs";

        // Act
        string result = ExtractFile.GetFile(path);

        // Assert
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_GetFile_PathWithNoExtension_ReturnsFileNameOnly()
    {
        // Arrange
        string path = "C:\\Work\\SoftUni\\QA\\Exercise";
        string expected = "File name: Exercise";

        // Act
        string result = ExtractFile.GetFile(path);

        // Assert
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_GetFile_PathWithSpecialCharacters_ReturnsFileNameAndExtension()
    {
        // Arrange
        string path = "C:\\Work\\SoftUni\\QA\\@КаквоНово/всичко§нищо.txt";
        string expected = "File name: @КаквоНово/всичко§нищо\nFile extension: txt";

        // Act
        string result = ExtractFile.GetFile(path);

        // Assert
        Assert.That(expected, Is.EqualTo(result));
    }
}
