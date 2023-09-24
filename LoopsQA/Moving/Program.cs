int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
int volume = width * height * length;
string command = Console.ReadLine();
while (true)
{
    if (command == "Done")
    {
        Console.WriteLine($"{volume} Cubic meters left.");
        break;
    }
    int numberOfBoxes = int.Parse(command);
    if (numberOfBoxes > volume)
    {
        Console.WriteLine($"No more free space! You need {numberOfBoxes - volume} Cubic meters more.");
        break;
    }
    volume -= numberOfBoxes;
    command = Console.ReadLine();
}