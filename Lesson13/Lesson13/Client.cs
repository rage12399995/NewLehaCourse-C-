using Lesson13;


public class Client
{
    public string Name { get; }

    public Client(string name)
    {
        Name = name;
    }


    public void SubscribeToNews(NewsProvider provider)
    {
        provider.NewsPublished += OnNewsReceived;
    }

    //public void SubscribeToWeather(NewsProvider provider)
    //{
    //    provider.WeatherPublished += OnWeatherReceived;
    //}

    public void SubscribeToSports(NewsProvider provider)
    {
        provider.SportsPublished += OnSportsReceived;
    }

    public void SubscribeToIncidents(NewsProvider provider)
    {
        provider.IncidentsPublished += OnIncidentsReceived;
    }

    public void SubscribeToHumor(NewsProvider provider)
    {
        provider.HumorPublished += OnHumorReceived;
    }


    public void UnsubscribeFromNews(NewsProvider provider)
    {
        provider.NewsPublished += OnNewsReceived;
    }




    private void OnNewsReceived(string news)
    {
        Console.WriteLine($"[{Name}] Получена новость: {news}");
    }

    //private void OnWeatherReceived(string weather)
    //{
    //    Console.WriteLine($"[{Name}] Получена погода: {weather}");
    //}

    private void OnSportsReceived(string sports)
    {
        Console.WriteLine($"[{Name}] Получены спортивные новости: {sports}");
    }

    private void OnIncidentsReceived(string incidents)
    {
        Console.WriteLine($"[{Name}] Получены происшествия: {incidents}");
    }

    private void OnHumorReceived(string humor)
    {
        Console.WriteLine($"[{Name}] Получен юмор: {humor}");
    }
}    
