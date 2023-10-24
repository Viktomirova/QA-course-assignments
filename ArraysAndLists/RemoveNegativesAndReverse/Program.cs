List<int> numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .Reverse()
    .ToList();
numbers.RemoveAll(x => x < 0);
if (numbers.Count == 0) Console.WriteLine("empty");
else Console.WriteLine(String.Join(" ", numbers));