using NUnit.Framework;
using System;

using System.Collections.Generic;
using System.Linq;

namespace TestApp.Tests;

public class DrumSetTests
{
    [Test]
    public void Test_Drum_TerminateCommandNotGiven_ThrowsArgumentException()
    {
        // Arrange
        decimal money = 100.00m;
        List<int> quality = new List<int>(){1, 2, 3, 4, 5};
        List<string> command = new List<string>(){};

        // Act & Assert
        Assert.Throws<ArgumentException>(() => DrumSet.Drum(money, quality, command));
    }

    [Test]
    public void Test_Drum_StringGivenAsCommand_ThrowsArgumentException()
    {
        // Arrange
        decimal money = 100.00m;
        List<int> quality = new List<int>(){1, 2, 3, 4, 5};
        List<string> command = new List<string>(){" "};

        // Act & Assert
        Assert.Throws<ArgumentException>(() => DrumSet.Drum(money, quality, command));
    }

    [Test]
    public void Test_Drum_ReturnsCorrectQualityAndAmount()
    {
        // Arrange
        decimal money = 100.00m;
        List<int> quality = new List<int>(){1, 2, 3, 4, 5};
        List<string> command = new List<string>(){"Hit it again, Gabsy!"};
        string expected = "1 2 3 4 5\nGabsy has 100.00lv.";

        // Act
        string result = DrumSet.Drum(money, quality, command);
        
        // Assert
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_Drum_BalanceZero_WithOneDrumLeftOver_ReturnsCorrectQualityAndAmount()
    {
        decimal money = 0.00m;
        List<int> quality = new List<int>(){1};
        List<string> command = new List<string>(){"Hit it again, Gabsy!"};
        string expected = "1\nGabsy has 0.00lv.";

        // Act
        string result = DrumSet.Drum(money, quality, command);
        
        // Assert
        Assert.That(expected, Is.EqualTo(result));
    }

    [Test]
    public void Test_Drum_NotEnoughBalance_RemovesAllDrums_ReturnsCorrectQualityAndAmount()
    {
        decimal money = 0.00m;
        List<int> quality = new List<int>(){};
        List<string> command = new List<string>(){"Hit it again, Gabsy!"};
        string expected = "\nGabsy has 0.00lv.";

        // Act
        string result = DrumSet.Drum(money, quality, command);
        
        // Assert
        Assert.That(expected, Is.EqualTo(result));
    }
}
