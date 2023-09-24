string player = Console.ReadLine();
double bestGoals = 0;
string bestPlayer = "";

while (player != "END")
{
    double goals = double.Parse(Console.ReadLine());
    if (goals > bestGoals)
    {
        bestPlayer = player;
        bestGoals = goals;
    }
    if (goals > 626.5)
    {
        break;
    }
    player = Console.ReadLine();
}
if (bestGoals > 626.5)
{
    Console.WriteLine($"{bestPlayer} is the best shooter!");
    Console.WriteLine($"{bestPlayer} improve the national record with {bestGoals} scored points.");
}
else
{
    Console.WriteLine($"{bestPlayer} is the best shooter!");
    Console.WriteLine($"Scored points: {bestGoals}");
}