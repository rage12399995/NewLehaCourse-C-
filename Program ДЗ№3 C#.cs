namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstValue , secondValue ;

            Console.WriteLine("Enter the first number");

            firstValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");

            secondValue = double.Parse(Console.ReadLine());

            Console.WriteLine("Addition operation:  " + (secondValue + firstValue));
            Console.WriteLine("Difference operation:  " + (secondValue - firstValue));
            Console.WriteLine("Multiplication operation:  " + (secondValue * firstValue));
            Console.WriteLine("Division operation:   " + (secondValue / firstValue));












        }    
    }
}
