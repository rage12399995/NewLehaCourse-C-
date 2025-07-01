using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson13
{
    public class NewsProvider
    {
 
        public string News { get; set; }
        public string Weather { get; set; }
        public string Sport { get; set; }
        public string Incidents { get; set; }
        public string Humor { get; set; }
        public object ProviderNews { get; }
        public List<string> Recipients { get; set; }
        public object? newsProvider { get; private set; }

        public NewsProvider(string providernews)
        {
            ProviderNews = newsProvider;

            Recipients = new List<string>();
        }
    }
}
