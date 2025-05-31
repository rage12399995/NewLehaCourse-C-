using System;
class Program
{
    static void Main()
    {
        int[,] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}          
        };

        int dog = matrix.GetLength(0);
        int cat = matrix.GetLength(1);


        for (int i = 0; i < dog; i++)
        {
            int max = matrix[i, 0];

            for (int j = 1; j < cat; j++)
            {
                if (matrix[i, j] > max)
                {
                    max = matrix[i, j];
                }
                
            }
            Console.WriteLine($"значения максимального элемента {i + 1}: {max}");
        }
        
    }
}
