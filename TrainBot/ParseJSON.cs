using Newtonsoft.Json.Linq;
using System.IO;
using System.Linq;
using System.Net;


namespace TrainBot
{
    public class ParseJSON
    {
       /* HttpWebResponse Response { get; set; }
        public ParseJSON(string stationOne, string stationTwo, string time)
        {
            var request = new RequestJSON(stationOne, stationTwo, time);
            this.Response = request.HttpRequest();
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
        }*/
    }
}
