double budget = double.Parse(Console.ReadLine());
string season = Console.ReadLine();
string destination = "";
string type = "";
double price = 0.0;

if (budget <= 100)
{
    destination = "Bulgaria";

    switch (season)
    {
        case "summer":
            type = "Camp";
            price = budget * 0.3;
            break;
        case "winter":
            type = "Hotel";
            price = budget * 0.7;
            break;
    }
}
else if (budget <= 1000)
{
    destination = "Balkans";
    switch (season)
    {
        case "summer":
            type = "Camp";
            price = budget * 0.4;
            break;
        case "winter":
            type = "Hotel";
            price = budget * 0.8;
            break;
    }
}
else
{
    destination = "Europe";
    type = "Hotel";
    price = budget * 0.9;
}

Console.WriteLine($"Somewhere in {destination}");
Console.WriteLine($"{type} - {price:F2}");