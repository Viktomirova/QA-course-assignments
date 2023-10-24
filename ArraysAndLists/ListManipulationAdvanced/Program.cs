List<int> numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();
string[] input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

string command = input[0];

while (command != "end")
{
    if (command == "Contains")
    {
        int element = int.Parse(input[1]);
        if (numbers.Contains(element))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No such number");
        }

    }
    else if (command == "PrintEven")
    {
        Console.WriteLine(String.Join(" ", numbers.Where(x => x % 2 == 0)));
    }
    else if (command == "PrintOdd")
    {
        Console.WriteLine(String.Join(" ", numbers.Where(x => x % 2 != 0)));
    }
    else if (command == "GetSum")
    {
        Console.WriteLine(numbers.Sum());
    }
    else if (command == "Filter")
    {
        string condition = input[1];
        int number = int.Parse(input[2]);
        switch (condition)
        {
            case "<":
                numbers.RemoveAll(x => x >= number);
                break;
            case ">":
                numbers.RemoveAll(x => x <= number);
                break;
            case ">=":
                numbers.RemoveAll(x => x < number);
                break;
            case "<=":
                numbers.RemoveAll(x => x > number);
                break;
        }
    }
    input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    command = input[0];
}
Console.WriteLine(String.Join(" ", numbers));