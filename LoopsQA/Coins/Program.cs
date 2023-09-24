decimal change = decimal.Parse(Console.ReadLine());
int count = 0;
while (change > 0)
{
    if (change >= 2)
    {
        change -= 2;
    }
    else if (change >= 1)
    {
        change -= 1;
    }
    else if (change >= 0.5m)
    {
        change -= 0.5m;
    }
    else if (change >= 0.2m)
    {
        change -= 0.2m;
    }
    else if (change >= 0.1m)
    {
        change -= 0.1m;
    }
    else if (change >= 0.05m)
    {
        change -= 0.05m;
    }
    else if (change >= 0.02m)
    {
        change -= 0.02m;
    }
    else if (change >= 0.01m)
    {
        change -= 0.01m;
    }
        count++;
}
Console.WriteLine(count);