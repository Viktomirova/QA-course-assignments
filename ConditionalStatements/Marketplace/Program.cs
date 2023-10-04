string product = Console.ReadLine();
string dayOfWeek  = Console.ReadLine();
double price = 0.0;

if (dayOfWeek == "Weekday")
{
	switch (product)
	{
		case "Banana":
			price = 2.50;
			break;
		case "Apple":
			price = 1.30;
			break;
		case "Kiwi":
			price = 2.20;
			break;
	}
}
else if (dayOfWeek == "Weekend")
{
		switch (product)
	{
		case "Banana":
			price = 2.70;
			break;
		case "Apple":
			price = 1.60;
			break;
		case "Kiwi":
			price = 3.00;
			break;
	}
}
Console.WriteLine($"{price:F2}");