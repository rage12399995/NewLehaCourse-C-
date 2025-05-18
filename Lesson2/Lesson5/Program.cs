
class Program
{
    static void Main()
    {
        Console.WriteLine("Запрос у пользователя двух булевых значений : ");
        bool dog = Convert.ToBoolean(Console.ReadLine());
        bool cat = Convert.ToBoolean(Console.ReadLine());

        Console.WriteLine("bigdog\tlittle cat\tbigdog&little cat\tbigdog|little cat\tbigdog^little cat\t!bigdog");
        Console.WriteLine($"{dog}\t{cat}\t{dog && cat}\t{dog || cat}\t{dog ^ cat}\t{!dog}");


    }

    
}
