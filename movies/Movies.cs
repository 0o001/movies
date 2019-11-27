using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace movies
{
    class MovieInfo
    {
        public string resim { get; set; }
        public string adi { get; set; }
        public string detay { get; set; }
        public string tarih { get; set; }

    }
    class Movies
    {
        public static List<MovieInfo> getMovies()
        {
            using (var json = new WebClient())
            {
                return JsonConvert.DeserializeObject<List<MovieInfo>>(json.DownloadString("http://api.tavcan.com/json/sinemalar"));
            }
        }
    }
}
