int boardCount = int.Parse(Console.ReadLine());
string boardType = Console.ReadLine();
string delivery = Console.ReadLine();

double price = 0.00;

if (boardCount < 10)
{
    Console.WriteLine("Boards can not be less than 10.");
    return;
}

switch (boardType)
{
    case "9mm":
        price = 100;
        if (boardCount > 50)
        {
            price -= price * 0.09;
        }
        else if (boardCount > 30)
        {
            price -= price * 0.05;
        }

        break;

    case "11mm":
        price = 125;
        if (boardCount > 70)
        {
            price -= price * 0.10;
        }
        else if (boardCount > 35)
        {
            price -= price * 0.07;
        }

        break;

    case "15mm":
        price = 185;
        if (boardCount > 60)
        {
            price -= price * 0.15;
        }
        else if (boardCount > 25)
        {
            price -= price * 0.08;
        }

        break;

    case "18mm":
        price = 210;
        if (boardCount > 55)
        {
            price -= price * 0.15;
        }
        else if (boardCount > 35)
        {
            price -= price * 0.10;
        }

        break;
}

double totalPrice = price * boardCount;

if (delivery == "Delivery")
{
    totalPrice += 50.00;
}

if (boardCount > 100)
{
    totalPrice -= totalPrice * 0.05;
}

Console.WriteLine($"{totalPrice:f2} BGN");