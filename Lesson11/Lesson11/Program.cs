using Lesson11;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Введите текст: ");
            string input = Console.ReadLine();

            var holder = new TextHolder(input); 
            Console.WriteLine($"Установлено значение: '{holder.Text}'");
        }
        catch (EmptyStringException ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Неизвестная ошибка: {ex.Message}");
        }
    }
}


