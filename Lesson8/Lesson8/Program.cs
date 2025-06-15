internal class Program
{
    private static int length;

    static void Main()
    {
        var text = Console.ReadLine();

        bool isPalindrome = IsPalindrome(text);

        if (isPalindrome)
        {
            Console.WriteLine("Этот текст является палиндромом");
        }
        else
        {
            Console.WriteLine("Этот текст не является палиндромом");
        }

    }

    static bool IsPalindrome(string text)
    {
        for (int i = 0; i < text.Length / 2; i++)
        {
            if (text[i] != text[text.Length - 1 - i])
            {
                return false;
            }
        }
         return true;
    }



























    static void ExampleCode()
    {
        bool x1 = false;
        bool x2 = x1;
        x2 = true;
        x2 = GetSomeBool();
        x1 = GetSomeBool(x1, x2);
    }

    static bool GetSomeBool()
    {
        return true;
    }

    static bool GetSomeBool(bool x1, bool x2)
    {
        return x1 && x2;
    }
}

