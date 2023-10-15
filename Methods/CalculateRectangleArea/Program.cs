int width = int.Parse(Console.ReadLine());
int length = int.Parse(Console.ReadLine());

int rectangleArea = CalculateRectangleArea(width, length);
Console.WriteLine(rectangleArea);

static int CalculateRectangleArea(int a, int b)
{
    int area = a * b;
    return area;
}