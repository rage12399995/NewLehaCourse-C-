class Program
{ 
public static void Main()
{

var project = new Manager.Project(
    "Разработка веб-приложения",
    DateTime.Now.AddDays(180));

var manager = new Manager(
    "Гриб Иван Николаевич:",
    "Рукаводитель.",
    1000,
    4,
    project);

var worker1 = new Worker(
    "Макеев Андрей Сергеевич",
    ".Net разработчик.",
    "Разработка веб-приложений",
    50,
    160);

var worker2 = new Worker(
    "Небольсин Алексей Сергеевич",
    ".Net разработчик.",
    "Разработка веб-приложений",
    50,
    160);

var worker3 = new Worker(
    "Василькова Елизавета Михайловна",
    "Тестировщик",
    "QA",
    35,
    150);

EmployeeRegistry.AddEmployee(manager);
EmployeeRegistry.AddEmployee(worker1);
EmployeeRegistry.AddEmployee(worker2);
EmployeeRegistry.AddEmployee(worker3);

EmployeeRegistry.ListAllEmployees();

Console.WriteLine("\nПоиск сотрудника:");
var found = EmployeeRegistry.FindEmployee("Макеев Андрей Сергеевич");

if (found != null)
{
    Console.WriteLine("Найден сотрудник:");
    Console.WriteLine(found.GetDetails());
}
else
{
    Console.WriteLine("Сотрудник не найден.");
}
 Console.ReadKey();
}
}