int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int number3 = int.Parse(Console.ReadLine());

int sum = number1 + number2 + number3;
int hours = 0;
int minutes = 0;

if (sum > 59)
{
    hours = sum / 60;
    minutes = sum % 60;
}
else
{
    minutes = sum;
}

if (minutes < 10)
{
    Console.WriteLine($"{hours}:0{minutes}");
}
else
{
    Console.WriteLine($"{hours}:{minutes}");
}