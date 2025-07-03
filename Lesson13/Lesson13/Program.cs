namespace Lesson13
{
    internal class Program
    {
        static void Main()
        {
            var provider = new NewsProvider();
            var client1 = new Client("Алексей");
            var client2 = new Client("Алёна");
            

            
            client1.SubscribeToNews(provider);
            client1.SubscribeToSports(provider);
            //client2.SubscribeToWeather(provider);
            client2.SubscribeToHumor(provider);
            client1.SubscribeToIncidents(provider);


            provider.PublishNews("Налогах на дождь вступил в силу!");
            //provider.PublishWeather("Завтра ожидается дождь.");
            provider.PublishSports("Хэмилтон приехал в Сильверстоун в ярком наряде на первом кроссовере «Феррари»!");
            provider.PublishHumor("Скороговорко: У боярина-бобра нет богатства, нет добра. Два бобрёнка у бобра – лучше всякого добра");
            provider.PublishNews("Налогах на воду вступил в силу!");


            client1.UnsubscribeFromNews(provider);
            provider.PublishNews("Эта новость не дойдет до Алексея.");
        }
    }
}
