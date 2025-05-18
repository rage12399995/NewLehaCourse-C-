internal class Program
{
static void Main(string[] args)
{
    int i = -20; 
    
    do
    {
        Console.WriteLine(i); 
        i -= 20;        
    }
    while (i >= -100);

}
}
