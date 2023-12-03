List<Student> students = new List<Student>();
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split();
    Student student = new Student();
    student.FirstName = input[0];
    student.LastName = input[1];
    student.Grade = double.Parse(input[2]);
    students.Add(student);
}
foreach (Student st in students.OrderByDescending(s => s.Grade))
{
    Console.WriteLine($"{st.FirstName} {st.LastName}: {st.Grade:F2}");
}


class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double Grade { get; set; }
}