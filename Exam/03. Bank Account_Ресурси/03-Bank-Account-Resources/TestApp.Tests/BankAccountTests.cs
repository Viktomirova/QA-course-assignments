using NUnit.Framework;

using System;

namespace TestApp.Tests;

[TestFixture]
public class BankAccountTests
{
    private BankAccount _bankAccount = null!;
    double initialBalance = 2000;

    [SetUp]
    public void SetUp()
    {
        this._bankAccount = new(initialBalance);
    }

    [Test]
    public void Test_Constructor_InitialBalanceIsSet()
    {
        // Arrange
        double expected = 2000;

        // Act
        double result = _bankAccount.Balance;

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Deposit_PositiveAmount_IncreasesBalance()
    {
        // Arrange
        double amount = 1000;
        double expected = 3000;

        // Act
        _bankAccount.Deposit(amount);
        double result = _bankAccount.Balance;

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Deposit_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        double amount = -1000;

        // Act

        // Assert
        Assert.Throws<ArgumentException>(() => _bankAccount.Deposit(amount), "Deposit amount must be greater than zero.");
    }

    [Test]
    public void Test_Withdraw_ValidAmount_DecreasesBalance()
    {
        // Arrange
        double amount = 1000;
        double expected = 1000;

        // Act
        _bankAccount.Withdraw(amount);
        double result = _bankAccount.Balance;

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_Withdraw_NegativeAmount_ThrowsArgumentException()
    {
        // Arrange
        double amount = -1000;

        // Act

        // Assert
        Assert.Throws<ArgumentException>(() => _bankAccount.Withdraw(amount), "Invalid withdrawal amount.");
    }

    [Test]
    public void Test_Withdraw_AmountGreaterThanBalance_ThrowsArgumentException()
    {
        // Arrange
        double amount = 4000;

        // Act

        // Assert
        Assert.Throws<ArgumentException>(() => _bankAccount.Withdraw(amount), "Invalid withdrawal amount.");
    }
}
