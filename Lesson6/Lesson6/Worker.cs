public  class Worker : EmployeeBase
{
    private string department;
    private decimal hourlyRate;
    private int hoursWorked;

    public string Department
    {
        get { return department; }
        set { department = value; }
    }

    public decimal HourlyRate
    {
        get { return hourlyRate; }
        set { hourlyRate = value; }
    }

    public int HoursWorked
    {
        get { return hoursWorked; }
        set { hoursWorked = value; }
    }

    public Worker(string name, string position, string department,
                decimal hourlyRate, int hoursWorked)
        : base(name, position)
    {
        this.department = department;
        this.hourlyRate = hourlyRate;
        this.hoursWorked = hoursWorked;
    }

    public override string GetDetails()
    {
        decimal salary = hourlyRate * hoursWorked;
        return $"РАБОЧИЙ: {Name}\nДолжность: {Position}\n" +
              $"Отдел: {department}\nСтавка: {hourlyRate.ToString("C")}/час\n" +
              $"Отработано часов: {hoursWorked}\n" +
              $"Зарплата: {salary.ToString("C")}\n";
    }
}