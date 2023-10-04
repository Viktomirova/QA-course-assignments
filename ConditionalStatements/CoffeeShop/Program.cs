string order = Console.ReadLine();
double price = 0;
double finalPrice = 0;
switch (order)
{
    case "coffee":
        price = 1.00;
        break;
    case "tea":
        price = 0.60;
        break;
    default:
        Console.WriteLine("Unknown drink");
        return;
}
string extra = Console.ReadLine();
switch (extra)
{
    case "sugar":
        finalPrice = price + 0.4;
        break;
    case "no":
        finalPrice = price;
        break;
    default:
        Console.WriteLine("Unknown extra");
        return;
}
Console.WriteLine($"Final price: ${finalPrice:F2}");