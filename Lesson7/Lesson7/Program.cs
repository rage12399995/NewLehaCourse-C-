class Program
{
static void Main(string[] args)
{
Console.WriteLine("Введите количество элементов массива:\t");

int elementsCount = int.Parse(Console.ReadLine());

int[] myArray = new int[elementsCount];

for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine($"\nВведите  элементов массива под индексом {i}:\t ");
    myArray[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine("\nВывод массива:");

for (int i = 0; i < myArray.Length; i++)
{
    Console.WriteLine(myArray[i]);
}


}
}
