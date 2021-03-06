using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp1
{
    internal class WeatherData
    {
    }
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Clouds
    {
        public int all { get; set; }
    }
    public class Coord
    {
        public double lon { get; set; }
        public double lat { get; set; }
    }
    public class Main
    {
        [JsonProperty("Temp")]
        public double Temp { get; set; }

        [JsonProperty("temp_min")]
        public double temp_min { get; set; }

        [JsonProperty("temp_max")]
        public double temp_max { get; set; }

        [JsonProperty("pressure")]
        public int pressure { get; set; }

        [JsonProperty("humidity")]
        public int humidity { get; set; }
    }
    public class Rain
    {
        public double _1h { get; set; }
    }
    public class Root
    {
        public Coord coord { get; set; }
        public List<Weather> weather { get; set; }
        public string @base { get; set; }
        public Main main { get; set; }
        public int visibility { get; set; }
        public Wind wind { get; set; }
        public Rain rain { get; set; }
        public Clouds clouds { get; set; }
        public int dt { get; set; }
        public Sys sys { get; set; }
        public int timezone { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
    }
    public class Sys
    {
        public int type { get; set; }
        public int id { get; set; }
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
    }
    public class Weather
    {
        public int id { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
    }
    public class Wind
    {
        public double speed { get; set; }
        public int deg { get; set; }
    }
}
