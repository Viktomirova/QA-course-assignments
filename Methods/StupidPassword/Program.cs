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
        sb.AppendLine("zero");
    }
    else if (a < 0)
    {
        if (b < 0)
        {
            if (c < 0)
            {
                sb.AppendLine("negative");
            }
            else
            {
                sb.AppendLine("positive");
            }
        }
        else
        {
            if (c < 0)
            {
                sb.AppendLine("positive");
            }
            else
            {
                sb.AppendLine("negative");
            }
        }
    }
    else
    {
        if (b < 0)
        {
            if (c < 0)
            {
                sb.AppendLine("positive");
            }
            else
            {
                sb.AppendLine("negative");
            }
        }
        else
        {
            if (c < 0)
            {
                sb.AppendLine("negative");
            }
            else
            {
                sb.AppendLine("positive");
            }
        }
    }
    return sb.ToString();
}