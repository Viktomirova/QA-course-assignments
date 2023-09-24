int goal = 10000;
int stepsCounter = 0;
string command = Console.ReadLine();
int diff = 0;
int steps = 0;
while (true)
{
    if (command == "Going home")
    {
        steps = int.Parse(Console.ReadLine());
        stepsCounter += steps;
        break;
    }
    else
    {
        steps = int.Parse(command);
        stepsCounter += steps;
        if (stepsCounter >= goal)
        {
            break;
        }
    }
    command = Console.ReadLine();
}
diff = Math.Abs(stepsCounter - goal);
if (stepsCounter >= goal)
{
    Console.WriteLine("Goal reached! Good job!");
    Console.WriteLine($"{diff} steps over the goal!");
    return;
}
else
{
    Console.WriteLine($"{diff} more steps to reach goal.");
}
