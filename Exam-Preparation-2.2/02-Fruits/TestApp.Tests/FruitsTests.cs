using System.Collections.Generic;

using NUnit.Framework;

namespace TestApp.Tests;

[TestFixture]
public class FruitsTests
{
    [Test]
    public void Test_GetFruitQuantity_FruitExists_ReturnsQuantity()
    {
        // Arrange
        Dictionary<string, int>? fruitDictionary = new () { {"banana", 5 } };
        int expected = 5;

        // Act
        int result = Fruits.GetFruitQuantity(fruitDictionary, "banana");

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_FruitDoesNotExist_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int>? fruitDictionary = new () { {"banana", 5 } };
        int expected = 0;

        // Act
        int result = Fruits.GetFruitQuantity(fruitDictionary, "lemon");

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_EmptyDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int>? fruitDictionary = new () {  };
        int expected = 0;

        // Act
        int result = Fruits.GetFruitQuantity(fruitDictionary, "banana");

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_NullDictionary_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int>? fruitDictionary = null;
        int expected = 0;

        // Act
        int result = Fruits.GetFruitQuantity(fruitDictionary, "banana");

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetFruitQuantity_NullFruitName_ReturnsZero()
    {
        // Arrange
        Dictionary<string, int>? fruitDictionary = new () { { "banana", 0 } };
        int expected = 0;

        // Act
        int result = Fruits.GetFruitQuantity(fruitDictionary, null);

        //Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
