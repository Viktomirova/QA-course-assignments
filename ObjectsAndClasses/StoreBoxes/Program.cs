List<Box> boxes = new List<Box>();

while (true)
{
    string[] input = Console.ReadLine().Split();
    if (input[0] == "end")
    {
        foreach (Box el in boxes.OrderByDescending(b => b.PriceForBox))
        {
            Console.WriteLine(el.SerialNumber);
            Console.WriteLine($"-- {el.BoxItem.Name} - ${el.BoxItem.Price:F2}: {el.Quantity}");
            Console.WriteLine($"-- ${el.PriceForBox:F2}");
        }
        break;
    }

    Box box = new Box();
    box.SerialNumber = int.Parse(input[0]);
    box.BoxItem.Name = input[1];
    box.Quantity = int.Parse(input[2]);
    box.BoxItem.Price = decimal.Parse(input[3]);
    boxes.Add(box);
}



public class Item
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

public class Box
{
    private string name = "";
    private decimal price = 0m;
    private Item boxItem = new Item();

    public Box()
    {
        BoxItem.Name = name;
        BoxItem.Price = price;
    }
    public int SerialNumber { get; set; }
    public int Quantity { get; set; }

    public Item BoxItem
    {
        get => boxItem;
        set => boxItem = value;
    }

    public decimal PriceForBox => this.Quantity * this.BoxItem.Price;
}