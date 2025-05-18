internal class Program
{
    static void Main(string[] args)
    {
        
        Book book1 = new Book();
        Console.WriteLine(book1.GetDescription());
        
        Book book2 = new Book("Триумфальная Арка:", "Эрих Мария Ремарк:", 604);
        Console.WriteLine(book2.GetDescription());
                
        book2.Pages = 604;
        Console.WriteLine(book2.GetDescription());
        
    }
}

