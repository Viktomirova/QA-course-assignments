int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());
if (num1 > num2 && num2 > num3)
{
    Console.WriteLine("Descending");
}
else if (num3 > num2 && num2 > num1)
{
    Console.WriteLine("Ascending");
}
else
{
    Console.WriteLine("Not sorted");
}