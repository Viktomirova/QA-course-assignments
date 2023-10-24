string product = Console.ReadLine();
int quantity = int.Parse(Console.ReadLine());

Console.WriteLine($"{CalculateTheTotalPrice(product, quantity):F2}");

static decimal CalculateTheTotalPrice(string product, int quantity)
{
    decimal priceOfCoffee = 1.50m;
    decimal priceOfWater = 1.00m;
    decimal priceOfCoke = 1.40m;
    decimal priceOfSnacks = 2.00m;
    decimal result = 1m;
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
    return result;
}