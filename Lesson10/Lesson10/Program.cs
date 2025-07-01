using Lesson10;
using System;

internal class Program
{
    static void Main(string[] args)
    {
        var p1 = new Person { Name = "Leha", Age = 30 };
        var p2 = new Person { Name = "Alex", Age = 33 };
        var p3 = new Person { Name = "Alena", Age = 30 };

        Console.WriteLine(p1);

        Console.WriteLine(p1.Equals(p2));

        Console.WriteLine(p3.Equals(p1));

        Console.WriteLine(p3 == p1);
    }
}
