string month = Console.ReadLine();
int days = int.Parse(Console.ReadLine());
double studio;
double apartment;
if (month == "May" || month == "October")
{
    apartment = 65;
    studio = 50;
    if (days > 7 && days <= 14)
        studio *= 0.95;
    else if (days > 14)
        studio *= 0.7;
}
else if (month == "June" || month == "September")
{
    apartment = 68.7;
    studio = 75.2;
    if (days > 14)
        studio *= 0.8;
}
else
{
    apartment = 77;
    studio = 76;
}

if (days > 14)
    apartment *= 0.9;

Console.WriteLine($"Apartment: {apartment * days:F2} lv.");
Console.WriteLine($"Studio: {studio * days:F2} lv.");