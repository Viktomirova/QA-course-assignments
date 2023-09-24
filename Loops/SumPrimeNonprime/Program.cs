int sumPrimeNumbers = 0;
int sumNonPrimeNumbers = 0;

string command = Console.ReadLine();
while (command != "stop")
{
    int number = int.Parse(command);
    int divisors = 0;
    if (number < 0)
    {
        Console.WriteLine("Number is negative.");
    }
    else
    {

        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                divisors++;
            }
        }
        if (divisors == 2)
        {
            sumPrimeNumbers += number;
        }
        else
        {
            sumNonPrimeNumbers += number;
        }
    }
    command = Console.ReadLine();
}
Console.WriteLine($"Sum of all prime numbers is: {sumPrimeNumbers}");
Console.WriteLine($"Sum of all non prime numbers is: {sumNonPrimeNumbers}");
