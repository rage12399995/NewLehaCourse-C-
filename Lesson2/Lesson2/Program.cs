namespace Lesson2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, напиши имя пользователя: ");
            var userName = (Console.ReadLine());
            Console.WriteLine("Привет, напиши возраст пользователе: ");
            var userAge = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Привет, напиши рост пользователя ");
            var userHeight = Convert.ToDouble(Console.ReadLine());

        
            Console.WriteLine($"Имя:{userName}");
            Console.WriteLine($"   Возраст:{userAge} лет");
            Console.WriteLine($"       Рост:{userHeight} см");
        }
    }
}
