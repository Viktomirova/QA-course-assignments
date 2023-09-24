int numberOfPages = int.Parse(Console.ReadLine());
int pagesPerHour = int.Parse(Console.ReadLine());
int numberOfDays = int.Parse(Console.ReadLine());
double requiredHoursPerDay = (numberOfPages / pagesPerHour) / (double)numberOfDays;
Console.WriteLine($"{Math.Floor(requiredHoursPerDay):f0}");

