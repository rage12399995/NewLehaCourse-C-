using System.Text;

class Program
{
    static string RemoveSpaces(string input)
    {
        StringBuilder sb = new StringBuilder();

        foreach (char c in input)
        {
            if (c != ' ')
            {
                sb.Append(c);
            }
        }

        return sb.ToString();
    }

    static void Main()
    {
        Console.WriteLine("Введите строку с пробелами:");
        string inputString = Console.ReadLine();

        string result = RemoveSpaces(inputString);
        Console.WriteLine("Результат после удаления пробелов: " + result);
    }
}

