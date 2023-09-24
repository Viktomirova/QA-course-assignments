int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
float percentage = float.Parse(Console.ReadLine());
double volume = length * width * height * 0.001;
double required = volume - (volume * percentage /100);
Console.WriteLine($"{required:f2}");