int bottles = int.Parse(Console.ReadLine());
string input = Console.ReadLine();
int detergent = bottles * 750;
int count = 0;
int usedDetergent = 0;
int dishesCount = 0;
int potsCount = 0;

while (true)
{
    if (input == "End")
    {
        Console.WriteLine("Detergent was enough!");
        Console.WriteLine($"{dishesCount} dishes and {potsCount} pots were washed.");
        Console.WriteLine($"Leftover detergent {detergent - usedDetergent} ml.");
        return;
    }

    int dishes = int.Parse(input);
    count++;
    if (count % 3 == 0)
    {
        usedDetergent += 15 * dishes;
        potsCount += dishes;
    }
    else
    {
        usedDetergent += 5 * dishes;
        dishesCount += dishes;
    }

    if (usedDetergent > detergent)
    {
        Console.WriteLine($"Not enough detergent, {usedDetergent - detergent} ml. more necessary!");
        return;
    }

    input = Console.ReadLine();
}

