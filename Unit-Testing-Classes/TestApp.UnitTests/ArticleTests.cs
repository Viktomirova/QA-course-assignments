using NUnit.Framework;

using System;
using System.Collections.Generic;

namespace TestApp.UnitTests;

public class ArticleTests
{
    private Article article;

    [SetUp]
    public void Setup()
    {
        this.article = new Article();
    }

    [Test]
    public void Test_AddArticles_ReturnsArticleWithCorrectData()
    {
        // Arrange
        string[] articleData = new string[]
        {
            "Article Content Author",
            "Article2 Content2 Author2",
            "Article3 Content3 Author3"
        };

        // Act
        Article result = this.article.AddArticles(articleData);

        // Assert
        Assert.That(result.ArticleList, Has.Count.EqualTo(3));
        Assert.That(result.ArticleList[0].Title, Is.EqualTo("Article"));
        Assert.That(result.ArticleList[1].Content, Is.EqualTo("Content2"));
        Assert.That(result.ArticleList[2].Author, Is.EqualTo("Author3"));
    }

    [Test]
    public void Test_GetArticleList_SortsArticlesByTitle()
    {
        // Arrange
        Article articleData = new Article()
        {
            ArticleList = new()
            {
            new Article() { Title = "Nightfall", Content = "science fiction", Author = "Isaac Asimov" },
            new Article() { Title ="Fight Club", Content = "love story", Author = "Martin Scorsese" }
            }
        };
        string expected = $"Fight Club - love story: Martin Scorsese{Environment.NewLine}" +
            $"Nightfall - science fiction: Isaac Asimov";

        // Act
        string result = this.article.GetArticleList(articleData, "title");

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_GetArticleList_ReturnsEmptyString_WhenInvalidPrintCriteria()
    {
        // Arrange
        Article articleData = new Article()
        {
            ArticleList = new()
            {
            new Article() { Title = "Nightfall", Content = "science fiction", Author = "Isaac Asimov" },
            new Article() { Title ="Fight Club", Content = "love story", Author = "Martin Scorsese" }
            }
        };

        // Act
        string result = this.article.GetArticleList(articleData, "Title");

        // Assert
        Assert.That(result, Is.Empty);
    }
}
