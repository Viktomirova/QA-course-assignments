using System;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;

using NUnit.Framework;

using TestApp.Todo;

namespace TestApp.Tests;

[TestFixture]
public class ToDoListTests
{
    private ToDoList _toDoList = null!;

    [SetUp]
    public void SetUp()
    {
        this._toDoList = new();
    }

    [Test]
    public void Test_AddTask_TaskAddedToToDoList() // XX
    {
        // Arrange 
        _toDoList.AddTask("meeting", new DateTime(2023, 12, 15));
        string expected = $"To-Do List:{Environment.NewLine}[ ] meeting - Due: 12/15/2023";

        // Act
        string result = _toDoList.DisplayTasks();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_CompleteTask_TaskMarkedAsCompleted() // XX
    {
        // Arrange 
        TaskItem task = new("meeting", new DateTime(2023, 12, 15));
        _toDoList.AddTask(task.Title, task.DueDate);
        string expected = $"To-Do List:{Environment.NewLine}[✓] meeting - Due: 12/15/2023";

        // Act
        _toDoList.CompleteTask(task.Title);

        // Assert
        Assert.That(_toDoList.DisplayTasks, Is.EqualTo(expected));
        //Assert.That(task.IsCompleted, Is.False);
    }

    [Test]
    public void Test_CompleteTask_TaskNotFound_ThrowsArgumentException()
    {
        // Arrange 
        _toDoList.AddTask("meeting", new DateTime(2023, 12, 15));

        // Act

        // Assert
        //Assert.That(() => _toDoList.CompleteTask("conference"), Throws.InstanceOf<ArgumentException>());
        Assert.Throws<ArgumentException>(() => _toDoList.CompleteTask("conference"), "Task with given title does not exist.");
    }

    [Test]
    public void Test_DisplayTasks_NoTasks_ReturnsEmptyString()
    {
        // Arrange 
        string expected = $"To-Do List:";

        // Act
        string result = _toDoList.DisplayTasks();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void Test_DisplayTasks_WithTasks_ReturnsFormattedToDoList() // XX
    {
        // Arrange 
        _toDoList.AddTask("meeting", new DateTime(2023, 12, 15));
        _toDoList.AddTask("conference", new DateTime(2023, 12, 20));
        _toDoList.CompleteTask("meeting");

        StringBuilder sb = new();        
        sb.AppendLine("To-Do List:");
        sb.AppendLine($"[✓] meeting - Due: 12/15/2023");
        sb.AppendLine($"[ ] conference - Due: 12/20/2023");
        
        string expected = sb.ToString().Trim();

        // Act
        string result = _toDoList.DisplayTasks();

        // Assert
        Assert.That(result, Is.EqualTo(expected));
    }
}
