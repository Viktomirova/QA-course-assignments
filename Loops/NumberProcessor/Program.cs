int number = int.Parse(Console.ReadLine());
string command = Console.ReadLine();
while (command != "End")
{
	switch (command)
	{
		case "Inc":
			number++;
			break;
		case "Dec":
			number--;
			break;
	}
	command = Console.ReadLine();
}
Console.WriteLine(number);