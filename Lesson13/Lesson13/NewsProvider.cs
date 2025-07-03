namespace Lesson13
{
    public class NewsProvider
    {
        public int WeatherPublished { get; internal set; }

        public event Action<string> NewsPublished;
        public event Action<string> WetherPublished;
        public event Action<string> SportsPublished;
        public event Action<string> IncidentsPublished;
        public event Action<string> HumorPublished;
        public void PublishNews(string news)
        {
            NewsPublished?.Invoke(news);
        }
        public void PublishWether(string news)
        {
            NewsPublished?.Invoke(news);
        }
        public void PublishSports(string news)
        {
            NewsPublished?.Invoke(news);
        }
        public void PublishIncidents(string news)
        {
            NewsPublished?.Invoke(news);
        }
        public void PublishHumor(string news)
        {
            NewsPublished?.Invoke(news);
        }


        //internal void PublishWeather(string v)
        //{
        //    throw new NotImplementedException();
        //}
    }

}
