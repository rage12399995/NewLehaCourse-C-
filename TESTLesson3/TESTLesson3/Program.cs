using System.Data;
using System.Threading.Channels;

namespace TESTLesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           DateTime now = DateTime.Now;
            DateTime start = now.StartOfDay();
            DateTime end = now.EndOfDay();
            string dayName = now.GetDayName();

            Console.WriteLine("Start day");
            Console.WriteLine("DayOF");
            Console.WriteLine("dayName");
        }

        
    }
}
