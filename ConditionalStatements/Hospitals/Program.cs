int period = int.Parse(Console.ReadLine());
int doctors = 7;

int treatedPatients = 0;
int untreatedPatients = 0;

for (int i = 1; i <= period; i++)
{
    int patients = int.Parse(Console.ReadLine());
    if (i % 3 == 0 && untreatedPatients > treatedPatients)
    {
        doctors++;
    }

    if (patients > doctors)
    {
        treatedPatients += doctors;
        untreatedPatients += patients - doctors;
    }
    else
    {
        treatedPatients += patients;
    }

}
Console.WriteLine($"Treated patients: {treatedPatients}.");
Console.WriteLine($"Untreated patients: {untreatedPatients}.");
