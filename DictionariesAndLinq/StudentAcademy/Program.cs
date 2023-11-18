Dictionary<string, List<double>> studentsResults = new Dictionary<string, List<double>>();
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string name = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());
    if (!studentsResults.ContainsKey(name))
    {
        studentsResults.Add(name, new List<double> { grade });
    }
    else
    {
        studentsResults[name].Add(grade);
    }
}

foreach (KeyValuePair<string, List<double>> student in studentsResults)
{
    if (student.Value.Average() >= 4.50)
    {
        Console.WriteLine($"{student.Key} -> {student.Value.Average():F2}");
    }
}