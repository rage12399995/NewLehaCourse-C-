internal class Program
{
static void Main(string[] args)
{
    Console.WriteLine("Enter a symbol from the keyboard: W, S, A, D ");
       
        var text = Console.ReadKey().KeyChar;
        Console.WriteLine();
        
        switch (text)
    {
        case 'W':
                Console.WriteLine("Enter from keyboard W");
            break;
        case 'S':
                Console.WriteLine("Enter from keyboard S");
                break;
        case 'A':
                Console.WriteLine("Enter from keyboard A");
            break;
        case 'D':
                Console.WriteLine("Enter from keyboard D");
                break;
            default:
                Console.WriteLine("This is something else");
                break;
    }
        Console.ReadLine();
    }
}
