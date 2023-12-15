using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class DictionaryIntersectionTests
{
    [Test]
    public void Test_Intersect_TwoEmptyDictionaries_ReturnsEmptyDictionary()
    {
        // Arrange
        var dic1 = new Dictionary<string, int>();
        var dic2 = new Dictionary<string, int>();

        // Act
        var result = DictionaryIntersection.Intersect(dic1, dic2);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Intersect_OneEmptyDictionaryAndOneNonEmptyDictionary_ReturnsEmptyDictionary()
    {
        // Arrange
        var dic1 = new Dictionary<string, int>();
        var dic2 = new Dictionary<string, int>(){ {"row", 5 }, { "col", 7 } };

        // Act
        var result = DictionaryIntersection.Intersect(dic1, dic2);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithNoCommonKeys_ReturnsEmptyDictionary()
    {
        // Arrange
        var dic1 = new Dictionary<string, int>(){ {"set", 5 }, { "let", 7 } };
        var dic2 = new Dictionary<string, int>(){ {"row", 5 }, { "col", 7 } };

        // Act
        var result = DictionaryIntersection.Intersect(dic1, dic2);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndValues_ReturnsIntersectionDictionary()
    {
        // Arrange
        var dic1 = new Dictionary<string, int>(){ {"set", 5 }, { "let", 7 } };
        var dic2 = new Dictionary<string, int>(){ {"set", 5 }, { "let", 7 } };

        // Act
        var result = DictionaryIntersection.Intersect(dic1, dic2);

        // Assert
        Assert.That(result, Is.EqualTo(new Dictionary<string, int>(){ {"set", 5 }, { "let", 7 } }));
    }

    [Test]
    public void Test_Intersect_TwoNonEmptyDictionariesWithCommonKeysAndDifferentValues_ReturnsEmptyDictionary()
    {
        // Arrange
        var dic1 = new Dictionary<string, int>(){ {"set", 6 }, { "let", 8 } };
        var dic2 = new Dictionary<string, int>(){ {"set", 5 }, { "let", 7 } };

        // Act
        var result = DictionaryIntersection.Intersect(dic1, dic2);

        // Assert
        Assert.That(result, Is.Empty);
    }
}
