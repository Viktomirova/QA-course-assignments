double parcelPrice = double.Parse(Console.ReadLine());
double parcelKg = double.Parse(Console.ReadLine());
double daysTrip = double.Parse(Console.ReadLine());
double parcelCount = double.Parse(Console.ReadLine());

if (parcelKg < 5)
{
    parcelPrice *= 0.2;
    if (daysTrip < 3)
    {
        parcelPrice *= 1.1;
    }
    else if (daysTrip >= 3 && daysTrip <= 7)
    {
        parcelPrice *= 1.15;
    }
    else if (daysTrip > 7)
    {
        parcelPrice *= 1.35;
    }
}
else if (parcelKg >= 5 && parcelKg <= 10)
{
    parcelPrice *= 0.5;
    if (daysTrip < 3)
    {
        parcelPrice *= 1.1;
    }
    else if (daysTrip >= 3 && daysTrip <= 7)
    {
        parcelPrice *= 1.15;
    }
    else if (daysTrip > 7)
    {
        parcelPrice *= 1.35;
    }
}
else
{
    if (daysTrip < 3)
    {
        parcelPrice *= 1.1;
    }
    else if (daysTrip >= 3 && daysTrip <= 7)
    {
        parcelPrice *= 1.15;
    }
    else if (daysTrip > 7)
    {
        parcelPrice *= 1.35;
    }
}

double total = parcelPrice * parcelCount * 1.0;
Console.WriteLine($"The total price is: {(total):f2} lv.");