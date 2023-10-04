string figure = Console.ReadLine();
double area = 0;
bool isValid = true;
switch (figure)
{
	case "square":
		double side = double.Parse(Console.ReadLine());
		area = side * side;
		break; 
	case "rectangle":
		double side1 = double.Parse(Console.ReadLine());
		double side2 = double.Parse(Console.ReadLine());
		area = side1 * side2;
		break;
	case "circle":
		double radius = double.Parse(Console.ReadLine());
		area = Math.Pow(radius, 2) * Math.PI;
		break;
	default:
		Console.WriteLine("Invalid figure.");
		isValid = false;
		break;
}
if (isValid)
Console.WriteLine($"{area:f2}");
