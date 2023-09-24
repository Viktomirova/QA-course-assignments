string typeOfFlowers = Console.ReadLine();
int countOfFlowers = int.Parse(Console.ReadLine());
int budget = int.Parse(Console.ReadLine());
double price = 0.0;
double discount = 100;
switch (typeOfFlowers)
{
    case "Roses":
        price = 5.0;
        if (countOfFlowers > 80)
        {
            discount -= 10;
        }
        break;
    case "Dahlias":
        price = 3.8;
        if (countOfFlowers > 90)
        {
            discount -= 15;
        }

        break;
    case "Tulips":
        price = 2.8;
        if (countOfFlowers > 80)
        {
            discount -= 15;
        }
        break;
    case "Narcissus":
        price = 3;
        if (countOfFlowers < 120)
        {
            discount += 15;
        }
        break;
    case "Gladiolus":
        price = 2.5;
        if (countOfFlowers < 80)
        {
            discount += 20;
        }
        break;
}
price = price * discount / 100;
double totalPrice = price * countOfFlowers;
double difference = budget - totalPrice;
if (totalPrice > budget)
{
    Console.WriteLine($"Not enough money, you need {Math.Abs(difference):f2} leva more.");
}
else
{
    Console.WriteLine($"Hey, you have a great garden with {countOfFlowers} {typeOfFlowers} and {Math.Abs(difference):f2} leva left.");
}