int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
int number3 = int.Parse(Console.ReadLine());

if (number1 == 0 || number2 == 0 || number3 == 0)
{
    Console.WriteLine("zero");
    return;
}
else if (number1 < 0)
{
    if (number2 < 0)
    {
        if (number3 < 0)
        {
            Console.WriteLine("negative");
            return;
        }
        else
        {
            Console.WriteLine("positive");
            return;
        }
    }
    else
    {
        if (number3 < 0)
        {
            Console.WriteLine("positive");
            return;
        }
        else
        {
            Console.WriteLine("negative");
            return;
        }
    }
}
else
{
    if (number2 < 0)
    {
        if (number3 < 0)
        {
            Console.WriteLine("positive");
            return;
        }
        else
        {
            Console.WriteLine("negative");
            return;
        }
    }
    else
    {
        if (number3 < 0)
        {
            Console.WriteLine("negative");
            return;
        }
        else
        {
            Console.WriteLine("positive");
            return;
        }
    }
}