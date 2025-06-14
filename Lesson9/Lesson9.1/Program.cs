class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, decimal> products = new Dictionary<string, decimal>
        {
            { "banana", 77},
            { "bread", 86},
            { "pizza", 34},
            { "juice", 29},
            { "pork", 50},
        };

        Console.WriteLine("Список продуктов:");
        foreach (var product in products)
        {
            Console.WriteLine($"{product.Key} - {product.Value} руб.");
        }

        
        Console.Write("\nВведите название продукта для поиска: ");
        string searchProduct = Console.ReadLine();

        if (products.ContainsKey(searchProduct))
        {
            Console.WriteLine($"Цена {searchProduct}: {products[searchProduct]} руб.");
        }
        else
        {
            Console.WriteLine($"Продукт '{searchProduct}' отсутствует.");
        }

        
        Console.WriteLine("\nЦены увеличены на 10%:");
        foreach (var product in products.Keys.ToList())
        {
            products[product] *= 1.1m;
            Console.WriteLine($"{product} - {products[product]:F2} руб.");
        }
    }
}
    
    

