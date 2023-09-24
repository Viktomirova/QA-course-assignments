int doctors = 7;
int days = int.Parse(Console.ReadLine());
int patients;
int treated = 0;
int untreated = 0;

for (int i = 1; i <= days; i++)
{
    patients = int.Parse(Console.ReadLine());
    if (i % 3 == 0 && untreated > treated)
    {
        doctors++;
    }
    if (patients > doctors)
    {
        treated += doctors;
        untreated += patients - doctors;
    }
    else
    {
        treated += patients;
    }

}
Console.WriteLine($"Treated patients: {treated}.");
Console.WriteLine($"Untreated patients: {untreated}.");