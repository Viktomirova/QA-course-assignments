List<Student> students = new List<Student>();
while (true)
{
    string[] input = Console.ReadLine().Split();
    if (input[0] == "end")
    {
        string command = Console.ReadLine();
        foreach (Student st in students.Where(st => st.HomeTown == command))
        {
            Console.WriteLine($"{st.FirstName} {st.LastName} is {st.Age} years old.");
        }
        break;
    }

    Student student = new Student();
    student.FirstName = input[0];
    student.LastName = input[1];
    student.Age = int.Parse(input[2]);
    student.HomeTown = input[3];
    students.Add(student);
}


class Student
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public string HomeTown { get; set; }
}