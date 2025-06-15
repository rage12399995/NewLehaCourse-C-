using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введите строку для преобразования:");
        string input = Console.ReadLine();

        string lowerCase = input.ToLower();
        Console.WriteLine("\n Все строчные буквы: " + lowerCase);

        string upperCase = input.ToUpper();
        Console.WriteLine("Все заглавные буквы: " + upperCase);

        string titleCase = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(input.ToLower());
        Console.WriteLine("Первую букву каждого слова в заглавную: " + titleCase);
    }
}

