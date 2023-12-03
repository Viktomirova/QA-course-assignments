using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace TestApp.UnitTests;

public class ExceptionTests
{
    private Exceptions exceptions = null!;

    [SetUp]
    public void SetUp()
    {
        this.exceptions = new();
    }

    [Test]
    public void Test_Reverse_ValidString_ReturnsReversedString()
    {
        // Arrange
        string input = "forever";
        string expected = "reverof";

        // Act
        string result = exceptions.ArgumentNullReverse(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Reverse_NullString_ThrowsArgumentNullException()
    {
        // Arrange
        string input = null;

        // Act & Assert
        Assert.That(() => this.exceptions.ArgumentNullReverse(input), Throws.ArgumentNullException);
    }

    [Test]
    public void Test_CalculateDiscount_ValidInput_ReturnsDiscountedPrice()
    {
        // Arrange
        decimal price = 59.99m;
        decimal discount = 20m;
        decimal expected = 47.992m;

        // Act
        decimal result = exceptions.ArgumentCalculateDiscount(price, discount);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateDiscount_NegativeDiscount_ThrowsArgumentException()
    {
        // Arrange
        decimal price = 59.99m;
        decimal discount = -20m;

        // Act & Assert
        Assert.That(() => this.exceptions.ArgumentCalculateDiscount(price, discount), Throws.ArgumentException);
    }

    [Test]
    public void Test_CalculateDiscount_DiscountOver100_ThrowsArgumentException()
    {
        // Arrange
        decimal totalPrice = 100.0m;
        decimal discount = 110.0m;

        // Act & Assert
        Assert.That(() => this.exceptions.ArgumentCalculateDiscount(totalPrice, discount), Throws.ArgumentException);
    }

    [Test]
    public void Test_GetElement_ValidIndex_ReturnsElement()
    {
        // Arrange
        int[] arr = new[] { 22, 33, 44 };
        int index = 2;
        int expected = 44;

        // Act
        int result = exceptions.IndexOutOfRangeGetElement(arr, index);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetElement_IndexLessThanZero_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] arr = new[] { 22, 33, 44 };
        int index = -3;

        // Act & Assert
        Assert.That(() => this.exceptions.IndexOutOfRangeGetElement(arr, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElement_IndexEqualToArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length;

        // Act & Assert
        Assert.That(() => this.exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElement_IndexGreaterThanArrayLength_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] array = { 10, 20, 30, 40, 50 };
        int index = array.Length + 1;

        // Act & Assert
        Assert.That(() => this.exceptions.IndexOutOfRangeGetElement(array, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_PerformSecureOperation_UserLoggedIn_ReturnsUserLoggedInMessage()
    {
        // Arrange
        bool isLogged = true;
        string expected = "User logged in.";

        // Act
        var result = this.exceptions.InvalidOperationPerformSecureOperation(isLogged);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_PerformSecureOperation_UserNotLoggedIn_ThrowsInvalidOperationException()
    {
        // Arrange
        var isLogged = false;

        // Act & Assert
        Assert.That(() => this.exceptions.InvalidOperationPerformSecureOperation(isLogged), Throws.InstanceOf<InvalidOperationException>());
    }

    [Test]
    public void Test_ParseInt_ValidInput_ReturnsParsedInteger()
    {
        // Arrange
        string input = "55";
        int expected = 55;

        // Act
        int result = exceptions.FormatExceptionParseInt(input);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_ParseInt_InvalidInput_ThrowsFormatException()
    {
        // Arrange
        string input = "a";

        // Act & Assert
        Assert.That(() => this.exceptions.FormatExceptionParseInt(input), Throws.InstanceOf<FormatException>());
    }

    [Test]
    public void Test_FindValueByKey_KeyExistsInDictionary_ReturnsValue()
    {
        Dictionary<string, int> input = new Dictionary<string, int>()
        {
            { "roses", 15 },
            { "tulips", 19 },
            { "violets", 13 }
        };
        string key = "roses";
        int expected = 15;

        // Act
        var result = this.exceptions.KeyNotFoundFindValueByKey(input, key);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_FindValueByKey_KeyDoesNotExistInDictionary_ThrowsKeyNotFoundException()
    {
        Dictionary<string, int> input = new Dictionary<string, int>()
        {
            { "roses", 15 },
            { "tulips", 19 },
            { "violets", 13 }
        };
        string key = "orchids";

        // Act && Assert
        Assert.That(() => this.exceptions.KeyNotFoundFindValueByKey(input, key), Throws.InstanceOf<KeyNotFoundException>());
    }

    [Test]
    public void Test_AddNumbers_NoOverflow_ReturnsSum()
    {
        // Arrange
        var a = 22;
        var b = 33;
        var expected = 55;

        // Act
        var result = exceptions.OverflowAddNumbers(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_AddNumbers_PositiveOverflow_ThrowsOverflowException()
    {
        // Arrange
        var a = int.MaxValue;
        var b = int.MaxValue;

        // Act & Assert
        Assert.That(() => exceptions.OverflowAddNumbers(a, b), Throws.InstanceOf<OverflowException>());
    }

    [Test]
    public void Test_AddNumbers_NegativeOverflow_ThrowsOverflowException()
    {
        // Arrange
        var a = int.MinValue;
        var b = int.MinValue;

        // Act & Assert
        Assert.That(() => exceptions.OverflowAddNumbers(a, b), Throws.InstanceOf<OverflowException>());
    }


    [Test]
    public void Test_DivideNumbers_ValidDivision_ReturnsQuotient()
    {
        // Arrange
        var a = 20;
        var b = 2;
        var expected = 10;

        // Act
        var result = exceptions.DivideByZeroDivideNumbers(a, b);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DivideNumbers_DivideByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        var a = 20;
        var b = 0;

        // Act & Assert
        Assert.That(() => exceptions.DivideByZeroDivideNumbers(a, b), Throws.InstanceOf<DivideByZeroException>());
    }


    [Test]
    public void Test_SumCollectionElements_ValidCollectionAndIndex_ReturnsSum()
    {
        // Arrange
        int[] collection = new int[] { 1, 2, 3 };
        int index = 2;
        int expected = 6;

        // Act
        int result = exceptions.SumCollectionElements(collection, index);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_SumCollectionElements_NullCollection_ThrowsArgumentNullException()
    {
        // Arrange
        int[] collection = null;
        int index = 0;

        // Act & Assert
        Assert.That(() => exceptions.SumCollectionElements(collection, index), Throws.InstanceOf<ArgumentNullException>());
    }

    [Test]
    public void Test_SumCollectionElements_IndexOutOfRange_ThrowsIndexOutOfRangeException()
    {
        // Arrange
        int[] collection = new int[] { 1, 2, 3 };
        int index = 4;

        // Act && Assert
        Assert.That(() => exceptions.SumCollectionElements(collection, index), Throws.InstanceOf<IndexOutOfRangeException>());
    }

    [Test]
    public void Test_GetElementAsNumber_ValidKey_ReturnsParsedNumber()
    {
        // Arrange
        Dictionary<string, string> input = new Dictionary<string, string>()
        {
            { "roses", "15" },
            { "tulips", "19" },
            { "violets", "13" }
        };
        string key = "tulips";
        int expected = 19;

        // Act
        int result = exceptions.GetElementAsNumber(input, key);

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetElementAsNumber_KeyNotFound_ThrowsKeyNotFoundException()
    {
        // Arrange
        Dictionary<string, string> input = new Dictionary<string, string>()
        {
            { "roses", "15" },
            { "tulips", "19" },
            { "violets", "13" }
        };
        string key = "mushrooms";

        // Act && Assert
        Assert.That(() => exceptions.GetElementAsNumber(input, key), Throws.InstanceOf<KeyNotFoundException>());
    }

    [Test]
    public void Test_GetElementAsNumber_InvalidFormat_ThrowsFormatException()
    {
        Dictionary<string, string> input = new Dictionary<string, string>()
        {
            { "roses", "null" },
            { "tulips", "19" },
            { "violets", "13" }
        };
        string key = "roses";

        // Act && Assert
        Assert.That(() => exceptions.GetElementAsNumber(input, key), Throws.InstanceOf<FormatException>());
    }
}
