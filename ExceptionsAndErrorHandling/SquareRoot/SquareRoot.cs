int number = int.Parse(Console.ReadLine());

try
{
    if (number < 0)
    {
        throw new ArithmeticException();
    }

    Console.WriteLine(Math.Sqrt(number));
}
catch (ArithmeticException)
{
    Console.WriteLine($"Invalid number.");
}
finally
{
    Console.WriteLine("Goodbye.");
}