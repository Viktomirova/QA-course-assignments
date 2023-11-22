using System.Text;
List<Catalog> carCatalog = new List<Catalog>();
List<Catalog> truckCatalog = new List<Catalog>();

while (true)
{
    string[] input = Console.ReadLine().Split("/");
    if (input[0] == "end")
    {
        break;
    }
    switch (input[0])
    {
        case "Car":
        Car car = new Car();
        Catalog catalogCars = new Catalog();
        catalogCars.CarCatalog.Brand = input[1];
        catalogCars.CarCatalog.Model = input[2];
        catalogCars.CarCatalog.HorsePower = int.Parse(input[3]);
        carCatalog.Add(catalogCars);
        break;
        case "Truck":
        Truck truck = new Truck();
        Catalog catalog = new Catalog();
        catalog.TruckCatalog.Brand = input[1];
        catalog.TruckCatalog.Model = input[2];
        catalog.TruckCatalog.Weight = int.Parse(input[3]);
        truckCatalog.Add(catalog);
        break;
    }
}

StringBuilder sb = new StringBuilder();
sb.AppendLine("Cars:");
foreach (Catalog cars in carCatalog.OrderBy(c => c.CarCatalog.Brand))
{
    sb.AppendLine($"{cars.CarCatalog.Brand}: {cars.CarCatalog.Model} - {cars.CarCatalog.HorsePower}hp");
}

sb.AppendLine("Trucks:");
foreach (Catalog trucks in truckCatalog.OrderBy(t => t.TruckCatalog.Brand))
{
    sb.AppendLine($"{trucks.TruckCatalog.Brand}: {trucks.TruckCatalog.Model} - {trucks.TruckCatalog.Weight}kg");
}

Console.WriteLine(sb.ToString());


public class Truck
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int Weight { get; set; }

}

public class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public int HorsePower { get; set; }

}

public class Catalog
{
    private string truckBrand = "";
    private string truckModel = "";
    private int truckWeight = 0;
    private Truck truck = new Truck();
    private string carBrand = "";
    private string carModel = "";
    private int carHorses = 0;
    private Car car = new Car();

    public Catalog()
    {
        TruckCatalog.Brand = truckBrand;
        TruckCatalog.Model = truckModel;
        TruckCatalog.Weight = truckWeight;
        CarCatalog.Brand = carBrand;
        CarCatalog.Model = carModel;
        CarCatalog.HorsePower = carHorses;
    }
    public Truck TruckCatalog { get => truck; set => truck = value; }
    public Car CarCatalog { get => car; set => car = value; }
}