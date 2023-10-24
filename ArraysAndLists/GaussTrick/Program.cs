List<int> numbers = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();
List<int> sum = new List<int>();
int first = 0;
int second = 0;

while (numbers.Count > 1)
{
    first = numbers[0];
    second = numbers[numbers.Count - 1];
    sum.Add(first + second);
    numbers.RemoveAt(numbers.Count - 1);
    numbers.RemoveAt(0);
}

if (numbers.Count > 0)
{
    sum.Add(numbers[0]);
}

Console.WriteLine(String.Join(" ", sum));