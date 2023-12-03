﻿string[] input = Console.ReadLine().Split();
int sum = 0;

foreach (string element in input)
{
    try
    {
        int number = int.Parse(element);
        sum += number;
    }
    catch (FormatException)
    {
        Console.WriteLine($"The element '{element}' is in wrong format!");
    }
    catch (OverflowException)
    {
        Console.WriteLine($"The element '{element}' is out of range!");
    }

    Console.WriteLine($"Element '{element}' processed - current sum: {sum}");
}

Console.WriteLine($"The total sum of all integers is: {sum}");