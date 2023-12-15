using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

int count = int.Parse(Console.ReadLine());

StringBuilder text = new StringBuilder();

Stack<string> previosText = new Stack<string>();

for (int i = 0; i < count; i++)
{
    string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

    if (command[0] == "1")
    {
        previosText.Push(text.ToString());
        text.Append(command[1]);
    }
    else if (command[0] == "2")
    {
        int countToRemove = int.Parse(command[1]);
        previosText.Push(text.ToString());
        text.Remove(text.Length - countToRemove, countToRemove);
    }
    else if (command[0] == "3")
    {
        int index = int.Parse(command[1]);
        Console.WriteLine(text[index - 1]);
    }
    else if (command[0] == "4")
    {
        text.Clear();
        text.Append(previosText.Pop());
    }
}