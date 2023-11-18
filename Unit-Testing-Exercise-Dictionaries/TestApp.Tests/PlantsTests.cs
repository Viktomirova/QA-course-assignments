using NUnit.Framework;

using System;

namespace TestApp.Tests;

public class PlantsTests
{
    [Test]
    public void Test_GetFastestGrowing_WithEmptyArray_ShouldReturnEmptyString()
    {
        // Arrange
        string[] plants = Array.Empty<string>();

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.Empty);
    }

    // TODO: finish test
    [Test]
    public void Test_GetFastestGrowing_WithSinglePlant_ShouldReturnPlant()
    {
        // Arrange
        string[] plants = new string[] { "rose" };

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo($"Plants with 4 letters:{Environment.NewLine}rose"));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMultiplePlants_ShouldReturnGroupedPlants()
    {
        // Arrange
        string[] plants = new string[] { "rose", "lily", "iris", "daisy" };

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo($"Plants with 4 letters:" +
                                       $"{Environment.NewLine}rose" +
                                       $"{Environment.NewLine}lily" +
                                       $"{Environment.NewLine}iris" +
                                       $"{Environment.NewLine}Plants with 5 letters:" +
                                       $"{Environment.NewLine}daisy"));
    }

    [Test]
    public void Test_GetFastestGrowing_WithMixedCasePlants_ShouldBeCaseInsensitive()
    {
        // Arrange
        string[] plants = new string[] { "daisy", "rose", "lily", "iris" };

        // Act
        string result = Plants.GetFastestGrowing(plants);

        // Assert
        Assert.That(result, Is.EqualTo("Plants with 4 letters:\r\n" +
                                       "rose\r\n" +
                                       "lily\r\n" +
                                       "iris\r\n" +
                                       "Plants with 5 letters:\r\n" +
                                       "daisy"));
    }
}
