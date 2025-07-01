internal class Program
{
static void Main(string[] args)
{
        int[,] matrix = new int[4, 4]

        {
            {1,20,30,45},
            {10,1,15,40},
            {45,33,5,12},
            {22,33,50,1}
        };

        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();           
        }
         
}
}

