using System.Collections;

public static class EmployeeRegistry
{
    private static ArrayList employees = new ArrayList();

    public static void AddEmployee(EmployeeBase employee)
    {
        employees.Add(employee);
        Console.WriteLine($"Сотрудник {employee.Name} добавлен в реестр.");
    }

    public static void ListAllEmployees()
    {
        Console.WriteLine("\n=== ВСЕ СОТРУДНИКИ ===");
        foreach (EmployeeBase emp in employees)
        {
            Console.WriteLine(emp.GetDetails());
            Console.WriteLine("----------------------");
        }
    }

    public static EmployeeBase FindEmployee(string name)
    {
        foreach (EmployeeBase emp in employees)
        {
            if (emp.Name.Equals(name, StringComparison.OrdinalIgnoreCase))
            {
                return emp;
            }
        }
        return null;
    }
}
