decimal neededMoney = decimal.Parse(Console.ReadLine());
decimal availableMoney = decimal.Parse(Console.ReadLine());
int dayCounter = 0;
int spendCounter = 0;
while (true)
{
    string command = Console.ReadLine();
    decimal money = decimal.Parse(Console.ReadLine());
    dayCounter++;
    switch (command)
    {
        case "spend":
            availableMoney -= money;
            if (availableMoney < 0)
            {
                availableMoney = 0;
            }
            spendCounter++;
            if (spendCounter == 5)
            {
                Console.WriteLine("You can't save the money.");
                Console.WriteLine(dayCounter);
                return;
            }
            break;
        case "save":
            availableMoney += money;
            spendCounter = 0;
            break;
    }
    if (availableMoney >= neededMoney)
    {
        Console.WriteLine($"You saved the money for {dayCounter} days.");
        return;
    }
}
