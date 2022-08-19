using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;


namespace TrainBot
{
    public class RequestJSON
    {
        string StationOne { get; set; }
        string StationTwo { get; set; }
        string Time { get; set; }
        HttpWebResponse Response { get; set; }
        public JToken[] ServicesArray { get; private set; } 
        public RequestJSON(string stationOne, string stationTwo, string time)
        {
            this.StationOne = stationOne;
            this.StationTwo = stationTwo;
            if(time == "") { Time = time; } else { Time = $"/{time}"; } 
            HttpRequest();
            ServicesArray = JSONToArray();
        }
        public void HttpRequest()
        {
           Console.WriteLine($"https://api.rtt.io/api/v1/json/search/{this.StationOne}/to/{this.StationTwo}/{DateTime.Now.Year}/{DateTime.Now.Month.ToString("d2")}/{DateTime.Now.Day}{this.Time}");
            WebRequest request = WebRequest.Create(
              $"https://api.rtt.io/api/v1/json/search/{this.StationOne}/to/{this.StationTwo}/{DateTime.Now.Year}/{DateTime.Now.Month.ToString("d2")}/{DateTime.Now.Day}{this.Time}");
            request.Method = "GET";
            request.Headers["Authorization"] = "Basic " + Convert.ToBase64String(Encoding.Default.GetBytes(File.ReadAllText("API_KEY.txt")));
            Response =  request.GetResponse() as HttpWebResponse;
        }
        public JToken[] JSONToArray()
        {
            string responseStream;
            using (Stream dataStream = Response.GetResponseStream())
            {
                StreamReader reader = new StreamReader(dataStream);
                responseStream = reader.ReadToEnd();
            }
            var getResult = JObject.Parse(responseStream);
            return getResult["services"].ToArray();
        }
    }
}

