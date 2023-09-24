double money = int.Parse(Console.ReadLine());
string season = Console.ReadLine();
double people = int.Parse(Console.ReadLine());

double seasonPrice = 0;
double discount = 0;
double moreDiscount = 0;

switch (season)
{
    case "Spring":
        seasonPrice = 3000;
        break;

    case "Summer":
    case "Autumn":
        seasonPrice = 4200;
        break;

    case "Winter":
        seasonPrice = 2600;
        break;

}

if (people <= 6)
{
    discount = 0.1;
}
else if (people >= 7 && people <= 11)
{
    discount = 0.15;
}
else if (people >= 12)
{
    discount = 0.25;
}

if (people % 2 == 0)
{
    if (season == "Autumn")
    {
        moreDiscount = 0;
    }
    else
    {
        moreDiscount = 0.05;
    }
}

double s1 = seasonPrice - seasonPrice * discount;
double sum = s1 - s1 * moreDiscount;

if (sum <= money)
{
    Console.WriteLine($"Yes! You have {money - sum:F02} leva left.");

}
else
{
    Console.WriteLine($"Not enough money! You need {sum - money:F02} leva.");
}
