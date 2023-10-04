int hour = int.Parse(Console.ReadLine());
string day = Console.ReadLine();
if (hour >= 10 && hour <= 18)
{
    if (day == "Sunday") Console.WriteLine("closed");
    else Console.WriteLine("open");
}
else Console.WriteLine("closed");
