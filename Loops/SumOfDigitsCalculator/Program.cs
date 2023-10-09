string input = Console.ReadLine();
while (true)
{
	if (input == "End")
	{
        Console.WriteLine("Goodbye");
        return;
    }
    int num = int.Parse(input);
    int sum = 0;
    while (num > 0)
    {
        int digit = num % 10;
        sum += digit;
        num /= 10;
    }
    Console.WriteLine($"Sum of digits = {sum}");
    input = Console.ReadLine();
}