using NUnit.Framework;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

using TestApp.Product;

namespace TestApp.Tests;

[TestFixture]
public class ProductInventoryTests
{
    private ProductInventory _inventory = null!;

    [SetUp]
    public void SetUp()
    {
        this._inventory = new();
    }

    [Test]
    public void Test_AddProduct_ProductAddedToInventory()
    {
        // Arrange
        _inventory.AddProduct("tea", 2.00, 2);
        string expected = $"Product Inventory:{Environment.NewLine}tea - Price: $2.00 - Quantity: 2";

        // Act
        string result = _inventory.DisplayInventory();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayInventory_NoProducts_ReturnsEmptyString()
    {
        // Arrange
        string expected = "Product Inventory:";

        // Act
        string result = _inventory.DisplayInventory();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayInventory_WithProducts_ReturnsFormattedInventory()
    {
        // Arrange
        _inventory.AddProduct("tea", 2.00, 2);
        string expected = $"Product Inventory:{Environment.NewLine}tea - Price: $2.00 - Quantity: 2";

        // Act
        string result = _inventory.DisplayInventory();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateTotalValue_NoProducts_ReturnsZero()
    {
        // Arrange
        double expected = 0.0;

        // Act
        double result = _inventory.CalculateTotalValue();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CalculateTotalValue_WithProducts_ReturnsTotalValue()
    {
        // Arrange
        _inventory.AddProduct("tea", 2.00, 2);
        _inventory.AddProduct("coffee", 3.50, 1);
        double expected = 7.50;

        // Act
        double result = _inventory.CalculateTotalValue();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
