string season = Console.ReadLine();
string accommType = Console.ReadLine();
int days = int.Parse(Console.ReadLine());
double price = 0.0;
double discount = 0.0;
switch (season)
{
    case "Spring":
        if (accommType == "Hotel") price = 30;
        else price = 10;
        discount = 0.8;
        break;
    case "Summer":
        if (accommType == "Hotel") price = 50;
        else price = 30;
        discount = 1;
        break;
    case "Autumn":
        if (accommType == "Hotel") price = 20;
        else price = 15;
        discount = 0.7;
        break;
    case "Winter":
        if (accommType == "Hotel") price = 40;
        else price = 10;
        discount = 0.9;
        break;
}
double totalPrice = price * discount * days;
Console.WriteLine($"{totalPrice:F2}");