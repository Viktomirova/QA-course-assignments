using NUnit.Framework;

using System;

namespace TestApp.Tests;

[TestFixture]
public class CsvParserTests
{
    [Test]
    public void Test_ParseCsv_EmptyInput_ReturnsEmptyArray()
    {
        // Arrange
        string input = String.Empty;

        // Act
        string[] output = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(output, Is.EqualTo(Array.Empty<string>()));
    }

    [Test]
    public void Test_ParseCsv_SingleField_ReturnsArrayWithOneElement()
    {
        // Arrange
        string input = "input";

        // Act
        string[] output = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(output.Length, Is.EqualTo(1));
    }

    [Test]
    public void Test_ParseCsv_MultipleFields_ReturnsArrayWithMultipleElements()
    {
        // Arrange
        string input = "input,output,parse,convert";
        string[] expected = { "input", "output", "parse", "convert" };

        // Act
        string[] output = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseCsv_TrimsWhiteSpace_ReturnsCleanArray()
    {
        // Arrange
        string input = "input ,   output   ,parse, convert ";
        string[] expected = { "input", "output", "parse", "convert" };

        // Act
        string[] output = CsvParser.ParseCsv(input);

        // Assert
        Assert.That(output, Is.EqualTo(expected));
    }
}
