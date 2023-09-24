int lenght = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int pieces = lenght * width;
while (pieces >= 0)
{
    string command = Console.ReadLine();
    if (command == "STOP")
    {
        Console.WriteLine($"{pieces} pieces are left.");
        break;
    }
    int takenPieces = int.Parse(command);
    pieces -= takenPieces;
}
if  (pieces < 0)
{
    Console.WriteLine($"No more cake left! You need {Math.Abs(pieces)} pieces more.");
}