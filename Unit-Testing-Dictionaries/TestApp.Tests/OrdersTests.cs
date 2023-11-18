using System;

using NUnit.Framework;

namespace TestApp.Tests;

public class OrdersTests
{
    [Test]
    public void Test_Order_WithEmptyInput_ShouldReturnEmptyString()
    {
        // Arrange
        string[] input = new string[0];

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.Empty);
    }

    [Test]
    public void Test_Order_WithMultipleOrders_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[]
                         {
                             "apple 1.00 1", 
                             "apple 1.99 2", 
                             "banana 0.50 2", 
                             "banana 0.75 3", 
                             "orange 0.99 1",
                             "orange 0.99 1"
                         };

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 5.97{Environment.NewLine}banana -> 3.75{Environment.NewLine}orange -> 1.98"));
    }

    [Test]
    public void Test_Order_WithRoundedPrices_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[]
                         {
                             "apple 1.00 1", 
                             "apple 1.9911111 2", 
                             "banana 0.50 2", 
                             "banana 0.7500000001 3", 
                             "orange 0.99 1",
                             "orange 0.989999999 1"
                         };

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 5.97{Environment.NewLine}banana -> 3.75{Environment.NewLine}orange -> 1.98"));
    }

    [Test]
    public void Test_Order_WithDecimalQuantities_ShouldReturnTotalPrice()
    {
        // Arrange
        string[] input = new string[]
                         {
                             "apple 2.00 1.5", 
                             "banana 1.50 2.5", 
                             "orange 1.00 3.5",
                         };

        // Act
        string result = Orders.Order(input);

        // Assert
        Assert.That(result, Is.EqualTo($"apple -> 3.00{Environment.NewLine}banana -> 3.75{Environment.NewLine}orange -> 3.50"));
    }
}
