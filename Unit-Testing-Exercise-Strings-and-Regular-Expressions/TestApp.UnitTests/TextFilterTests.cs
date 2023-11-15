using NUnit.Framework;

using System;

namespace TestApp.UnitTests;

public class TextFilterTests
{
    [Test]
    public void Test_Filter_WhenNoBannedWords_ShouldReturnOriginalText()
    {
        // Arrange
        string text = "In a world obsessed with AI-generated design, it's good to see some good old human creativity.";
        string[] words = new[] {"mirror"};

        // Act
        string result = TextFilter.Filter(words, text);

        // Assert
        Assert.That(result, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordExists_ShouldReplaceBannedWordWithAsterisks()
    {
        // Arrange
        string text = "In a world obsessed with AI-generated design, it's good to see some good old human creativity.";
        string[] words = new[] {"old"};
        string expected =
            "In a world obsessed with AI-generated design, it's good to see some good *** human creativity.";

        // Act
        string result = TextFilter.Filter(words, text);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsAreEmpty_ShouldReturnOriginalText()
    {
        // Arrange
        string text = "In a world obsessed with AI-generated design, it's good to see some good old human creativity.";
        string[] words = Array.Empty<string>();

        // Act
        string result = TextFilter.Filter(words, text);

        // Assert
        Assert.That(result, Is.EqualTo(text));
    }

    [Test]
    public void Test_Filter_WhenBannedWordsContainWhitespace_ShouldReplaceBannedWord()
    {
        // Arrange
        string text = "In a world obsessed with AI-generated design, it's good to see some good old human creativity.";
        string[] words = new[] {"good old", "with"};
        string expected =
            "In a world obsessed **** AI-generated design, it's good to see some ******** human creativity.";

        // Act
        string result = TextFilter.Filter(words, text);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
