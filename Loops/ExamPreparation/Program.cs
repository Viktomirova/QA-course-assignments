int poorGrades = int.Parse(Console.ReadLine());
int countProblems = 0;
int countPoorGrades = 0;
string lastProblem = "";
double sum = 0;
while (true)
{
    string problem = Console.ReadLine();
    if (problem == "Enough")
    {
        double average = sum / countProblems;
        Console.WriteLine($"Average score: {average:F2}");
        Console.WriteLine($"Number of problems: {countProblems}");
        Console.WriteLine($"Last problem: {lastProblem}");
        return;
    }
    countProblems++;
    int grade = int.Parse(Console.ReadLine());
    sum += grade;
    if (grade <= 4)
    {
        countPoorGrades++;
        if (countPoorGrades == poorGrades)
        {
            Console.WriteLine($"You need a break, {countPoorGrades} poor grades.");
            return;
        }
    }
    lastProblem = problem;
}