string type = Console.ReadLine();
int rows = int.Parse(Console.ReadLine());
int columns = int.Parse(Console.ReadLine());
double totalIncome = 0.0;
switch (type)
{
	case "Premiere":
		totalIncome = rows * columns * 12.00;
		break;
	case "Normal":
		totalIncome = rows * columns * 7.50;
		break;
	case "Discount":
		totalIncome = rows * columns * 5.00;
		break;
}
Console.WriteLine($"{totalIncome:F2} leva");