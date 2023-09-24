double degrees = double.Parse(Console.ReadLine());
string timeOfDay = Console.ReadLine();
string clothing = "";
string shoes = "";
if (degrees >= 10 && degrees <= 18)
{
    switch (timeOfDay)
    {
        case "Morning":
            clothing = "Sweatshirt";
            shoes = "Sneakers";
            break;
        case "Afternoon":
        case "Evening":
            clothing = "Shirt";
            shoes = "Moccasins";
            break;
    }
}
else if (degrees >= 25)
{
    switch (timeOfDay)
    {
        case "Morning":
            clothing = "T-Shirt";
            shoes = "Sandals";
            break;
        case "Afternoon":
            clothing = "Swim Suit";
            shoes = "Barefoot";
            break;
        case "Evening":
            clothing = "Shirt";
            shoes = "Moccasins";
            break;
    }
}
else
{
    switch (timeOfDay)
    {
        case "Morning":
        case "Evening":
            clothing = "Shirt";
            shoes = "Moccasins";
            break;
        case "Afternoon":
            clothing = "T-Shirt";
            shoes = "Sandals";
            break;
    }
}

Console.WriteLine($"It's {degrees} degrees, get your {clothing} and {shoes}.");