internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("выводим на экран в одну строку все двузначные числа, кратные 5:");

        for (int i = 10; i < 100; i += 5)
        {
            Console.Write(i + " ");
        }
    }   
}

