string ticket = Console.ReadLine();
switch (ticket)
{
  case "student":
    Console.WriteLine("$1.00");
    break;
  case "regular":
    Console.WriteLine("$1.60");
    break;
  default:
    Console.WriteLine("Invalid ticket type!");
    break;
}