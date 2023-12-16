using System;
using System.Text;

using NUnit.Framework;

using TestApp.Chat;

namespace TestApp.Tests;

[TestFixture]
public class ChatRoomTests
{
    private ChatRoom _chatRoom = null!;

    [SetUp]
    public void Setup()
    {
        this._chatRoom = new();
    }

    [Test]
    public void Test_SendMessage_MessageSentToChatRoom()
    {
        // Arrange

        // Act
        _chatRoom.SendMessage("Sasho", "Hello");

        // Assert
        Assert.That(_chatRoom.DisplayChat, Does.Contain("Sasho: Hello"));
    }

    [Test]
    public void Test_DisplayChat_NoMessages_ReturnsEmptyString()
    {
        // Arrange
        string expected = string.Empty;

        // Act

        // Assert
        Assert.That(_chatRoom.DisplayChat, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayChat_WithMessages_ReturnsFormattedChat()
    {
        // Arrange

        // Act
        _chatRoom.SendMessage("Sasho", "Hello");
        _chatRoom.SendMessage("Misho", "Hi, there!");

        // Assert
        Assert.That(_chatRoom.DisplayChat, Does.Contain("Chat Room Messages:"));
        Assert.That(_chatRoom.DisplayChat, Does.Contain("Sasho: Hello - Sent"));
        Assert.That(_chatRoom.DisplayChat, Does.Contain("Misho: Hi, there! - Sent"));
    }
}
