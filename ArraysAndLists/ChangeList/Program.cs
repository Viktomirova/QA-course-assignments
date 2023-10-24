List<int> numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();
string[] input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

string command = input[0];

while (command != "end")
{
    int element = int.Parse(input[1]);
    if (command == "Delete")
    {
        numbers.Remove(element);
    }
    else if (command == "Insert")
    {
        int position = int.Parse(input[2]);
        numbers.Insert(position, element);
    }
    input = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
    command = input[0];
}
Console.WriteLine(String.Join(" ", numbers));