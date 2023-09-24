int days = int.Parse(Console.ReadLine());
string roomType = Console.ReadLine();
string grade = Console.ReadLine();

double pricePerNight = 0.0;

switch (roomType)
{
    case "room for one person":
        pricePerNight = 118;
        break;
    case "apartment":
        pricePerNight = 155;
        if (days < 10)
            pricePerNight *= 0.7;
        else if (days >= 10 && days <= 15)
            pricePerNight *= 0.65;
        else
            pricePerNight *= 0.5;
        break;
    case "president apartment":
        pricePerNight = 235;
        if (days < 10)
            pricePerNight *= 0.9;
        else if (days >= 10 && days <= 15)
            pricePerNight *= 0.85;
        else
            pricePerNight *= 0.8;
        break;
}

double totalPrice = pricePerNight * (days - 1);

var output = grade == "positive" ? totalPrice *= 1.25 : totalPrice *= 0.9;

Console.WriteLine($"{output:F2}");

