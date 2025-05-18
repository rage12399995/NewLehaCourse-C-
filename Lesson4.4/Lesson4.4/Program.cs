internal class Program
{
    static void Main(string[] args)
{
    Console.WriteLine("Enter a symbol from the keyboard: w, s, a, b ");

    var text = Console.ReadKey().KeyChar;
    Console.WriteLine();
        
    switch (text)
    {
        case 'w':
            Console.WriteLine("Фигура перемещена вверх");
            break;
        case 's':
            Console.WriteLine("Фигура перемещена вниз");
            break;
        case 'a':
            Console.WriteLine("Фигура перемещена влево");
            break;
        case 'b':
            Console.WriteLine("Фигура перемещена вправо");
            break;
        default:
            Console.WriteLine("Неизвестная команда. Перемещение не выполнено.");
            break;
    }
    Console.ReadLine();
    }   
}
