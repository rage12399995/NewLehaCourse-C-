internal class Program
{
    static void Main(string[] args)
    {
        var students = new List<Student>()
        {
          new ("Olga",50,6.7),
          new ("Kostya",45,5.5),
          new ("Anton",65,4.5),
          new ("Michael",34,8.5),
          new ("Alena",23,7.5),
          new ("Aleksey",44,5.9),
          new ("Kostya",37,6.5),
        };
        var sortedStudents = SortByAverageDescending(students);

        Console.WriteLine("List of sorted students: ");
        foreach (var student in sortedStudents)
        {
            student.PrintInformation();
        }

        var youngest = FindYoungestStudent(students);

        Console.WriteLine("\nYongest student: ");
        youngest.PrintInformation();
    }

    static List<Student> SortByAverageDescending(List<Student> students)
    {
        var sorted = new List<Student>(students);

        for (var i = 0; i < sorted.Count - 1; ++i)
        {
            for (var j = i + 1; j < sorted.Count; ++j)
            {
                if (sorted[j]._averageGrade > sorted[i]._averageGrade)
                {
                    var temp = sorted[i];
                    sorted[i] = sorted[j];
                    sorted[j] = temp;
                }
            }
        }

        return sorted;
    }

    static Student FindYoungestStudent(List<Student> students)
    {
        var youngest = students[0];

        foreach (var student in students)
        {
            if (student.age < youngest.age)
            {
                youngest = student;
            }
        }

        return youngest;


    }
}

