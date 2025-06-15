class Student
{
    public string _name;
    public int _age;
    public double _averageGrade;
    internal int age;

    private string Name
    {
        get { return _name; }
        set { _name = value; }
    }
    private int Age
    {
        get { return _age; }
        set { _age = value; }

    }
    private double AverageGrade 
    {
        get { return _averageGrade; }
        set { _averageGrade = value; }
    }
    public Student(string name, int age, double averageGrade)
    {
        _name = name;
        _age = age;
        _averageGrade = averageGrade;
    }

    public void PrintInformation()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}, Avarage grade: {AverageGrade}");
    }


}