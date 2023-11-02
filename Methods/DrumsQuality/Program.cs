using System;
using System.Collections.Generic;
using System.Linq;

decimal money = 100.00m;
List<int> quality = new List<int>(){1, 2, 3, 4, 5};
var command = Console.ReadLine().Split("|").ToList();
string output = Drum(money, quality, command);
Console.WriteLine(output);

static string Drum(decimal money, List<int> initialQuality, List<string> commands)
{
    List<int> usedQuality = initialQuality.ToList();

    foreach (string command in commands)
    {
        if (command == "Hit it again, Gabsy!")
        {
            return $"{string.Join(" ", usedQuality)}\nGabsy has {money:f2}lv.";
        }

        bool isParsed = int.TryParse(command, out int power);
        if (!isParsed)
        {
            throw new ArgumentException("Number did not parse correctly!");
        }

        for (int i = 0; i < usedQuality.Count; i++)
        {
            usedQuality[i] -= power;
            if (usedQuality[i] > 0)
            {
                continue;
            }

            int price = initialQuality[i] * 3;
            if (money - price > 0)
            {
                money -= price;
                usedQuality[i] = initialQuality[i];
            }
            else if (money - price <= 0)
            {
                initialQuality.RemoveAt(i);
                usedQuality.RemoveAt(i);
                i--;
            }
        }
    }

    throw new ArgumentException("Terminate command not given!");
}

