double grade = double.Parse(Console.ReadLine());

PrintTheGradeInWords(grade);

static void PrintTheGradeInWords(double grade)
{
    if (grade >= 2.00 && grade < 3.00) Console.WriteLine("Fail");
    if (grade >= 3.00 && grade < 3.50) Console.WriteLine("Average");
    if (grade >= 3.50 && grade < 4.50) Console.WriteLine("Good");
    if (grade >= 4.50 && grade < 5.50) Console.WriteLine("Very good");
    if (grade >= 5.50 && grade <= 6.00) Console.WriteLine("Excellent");
}