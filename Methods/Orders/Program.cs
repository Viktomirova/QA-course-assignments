string product = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());

CalculateTheTotalPrice(product, quantity);

static void CalculateTheTotalPrice(string product, int quantity)
{
    decimal priceOfCoffee = 1.50m;
    decimal priceOfWater = 1.00m;
    decimal priceOfCoke = 1.40m;
    decimal priceOfSnacks = 2.00m;
    decimal result = 1;
    switch (product)
    {
        case "coffee":
            result = quantity * priceOfCoffee;
            break;
        case "water":
            result = quantity * priceOfWater;
            break;
        case "coke":
            result = quantity * priceOfCoke;
            break;
        case "snacks":
            result = quantity * priceOfSnacks;
            break;
    }
    Console.WriteLine($"{result:F2}");
}