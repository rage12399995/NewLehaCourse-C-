public class Book
{
    public string title;

    public string author;

    public int pages;

    public string Title
    {
        get { return title; }
        set { title = value; }
    }
    public string Author
    {
        get { return author; }
        set { author = value; }
    }
    public int Pages
    {
        get { return pages; }
        set { pages = value >= 0 ? value : 0; } 
    }
    public Book()
    {
        Title = "Unknown";
        Author = "Unknown";
        Pages = 0;
    }      
    public Book(string title, string author, int pages)
    {
        Title = title;
        Author = author;
        Pages = pages;
    }       
    public string GetDescription()
    {
        return $"Название: {Title}, Автор: {Author}, Страниц: {Pages}";
    }
}
