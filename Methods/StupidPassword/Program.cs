using System.Text;

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

Console.WriteLine(PrintSignOfProduct(num1, num2, num3));

static string PrintSignOfProduct(int a, int b, int c)
{
    StringBuilder sb = new StringBuilder();

    if (a == 0 || b == 0 || c == 0)
    {
        Console.WriteLine("zero");
    }
    else if (a < 0)
    {
        if (b < 0)
        {
            if (c < 0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }
        }
        else
        {
            if (c < 0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }
    }
    else
    {
        if (b < 0)
        {
            if (c < 0)
            {
                Console.WriteLine("positive");
            }
            else
            {
                Console.WriteLine("negative");
            }
        }
        else
        {
            if (c < 0)
            {
                Console.WriteLine("negative");
            }
            else
            {
                Console.WriteLine("positive");
            }
        }
    }
    return sb.ToString();
}