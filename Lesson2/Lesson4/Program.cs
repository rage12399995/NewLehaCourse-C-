namespace Lesson4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Напиши возраст пользователе: ");

            int AgeCharacters;

            while (!int.TryParse(Console.ReadLine(), out AgeCharacters) || AgeCharacters < 0)
            {
                Console.WriteLine("Напиши возраст пользователя от 0 и 99 лет");
            }
        

            if (AgeCharacters % 2 == 0)
            {
                Console.WriteLine("Число чётное!");
            }
            else
            {
                Console.WriteLine("Число нечётное!");
            }

            string group;

            if (AgeCharacters <= 2)
                group = "Можешь считать себя Младенецем";
            else if (AgeCharacters <= 12)
                group = "Можешь считать себя Ребёном";
            else if (AgeCharacters <= 17)
                group = "Можешь считать себя Подростокм";
            else if (AgeCharacters <= 59)
                group = "Можешь считать себя Взрослым";
            else 
                group = "Можешь считать себя Пожилым :(( ";



            Console.WriteLine($"Твой возраст: {AgeCharacters}");
            Console.WriteLine($"Ты: {group}.");
        }
    }
}
