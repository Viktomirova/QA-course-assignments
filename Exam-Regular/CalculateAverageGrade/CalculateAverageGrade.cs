int students = int.Parse(Console.ReadLine());
//double sumOfGrades = 0;
//for (int i = 1; i <= students; i++)
//{
//    double grade = double.Parse(Console.ReadLine());
//    sumOfGrades += grade;
//}

//Console.WriteLine($"{sumOfGrades / students:F2}");

Console.WriteLine($"{GetAverage(students):F2}");
static double GetAverage(int students)
{
    double[] sumOfGrades = new double[students];
    for (int i = 0; i < students; i++)
    {
        double grade = double.Parse(Console.ReadLine());
        sumOfGrades[i] = grade;
    }

    return sumOfGrades.Average();
}