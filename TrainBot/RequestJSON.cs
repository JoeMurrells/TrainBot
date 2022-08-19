using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace TrainBot
{
    public class RequestJSON
    {
        string stationOne { get; set; }
        string stationTwo { get; set; }
        string time { get; set; }
        HttpWebResponse Response { get; set; }
        public JToken[] ServicesArray { get; private set; } 
        public RequestJSON(string stationOne, string stationTwo, string time)
        {
            this.stationOne = stationOne;
            this.stationTwo = stationTwo;
            if(time == "") { this.time = time; } else { this.time = $"/{time}"; } 
            HttpRequest();
            ServicesArray = JSONToArray();
        }
        public void HttpRequest()
        {
           Console.WriteLine($"https://api.rtt.io/api/v1/json/search/{this.stationOne}/to/{this.stationTwo}/{DateTime.Now.Year}/{DateTime.Now.Month.ToString("d2")}/{DateTime.Now.Day}{this.time}");
            WebRequest request = WebRequest.Create(
              $"https://api.rtt.io/api/v1/json/search/{this.stationOne}/to/{this.stationTwo}/{DateTime.Now.Year}/{DateTime.Now.Month.ToString("d2")}/{DateTime.Now.Day}{this.time}");
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

