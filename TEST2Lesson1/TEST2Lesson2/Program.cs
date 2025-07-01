public class Program
{
    static void Main()
    {
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());

        string result = number.ToWordString();
        Console.WriteLine($"Результат: {result}");
    }
}

public static class IntExtensions
{
    public static string ToWordString(this int number)
    {
        string[] words = { "ноль", "один", "два", "три", "четыре",
                          "пять", "шесть", "семь", "восемь", "девять" };

        string result = "";
        string numStr = number.ToString();

        foreach (char c in numStr)
        {
            if (char.IsDigit(c))
            {
                int digit = c - '0';
                result += words[digit] + " ";
            }
        }

        return result.Trim();
    }
}


