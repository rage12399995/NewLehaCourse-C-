﻿class Program
{
    static void Main(string[] args)
    {

        int[] Araay = [10, 20, 30, 40, 50];

        Console.WriteLine("перебираем с помощью цикла for:");
        for (int i = 0; i < Araay.Length; i++)
        {
            Console.WriteLine($"Элемент {i}: {Araay[i]}");
        }

        Console.WriteLine("перебираем с помощью цикла foreach:");
        foreach (int number in Araay)
        {
            Console.WriteLine($"Элемент: {number}");
        }

        int[] numbers1 = [15, 20, 35, 45, 55];

        Console.WriteLine("перебираем с помощью цикла while:");
        int index = 0;
        while (index < numbers1.Length)
        {
            Console.WriteLine($"{index}: {numbers1[index]}");
            index++;
        }
      
        int[] numbers2 = [10, 20, 30, 40, 50];
        Console.WriteLine("перебираем с помощью цикла do-while:");
        int j = 0;
        do
        {    
            Console.WriteLine(numbers2[j]); 
            j++; 
        }
        while (j < numbers2.Length);
       
    }
       
}