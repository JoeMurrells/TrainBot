using System;


namespace TrainBot
{
    public static class BotResponse
    {
        public static string OutputString(string stationOne, string stationTwo, string time)
        {
            var requestJSON = new RequestJSON(stationOne, stationTwo, time);

            string outputString = "";
            var currentTime = DateTime.Now.ToString("HHmm");

            for (int i = 0; i < requestJSON.ServicesArray.Length; i++)
            {
                var platform = requestJSON.ServicesArray[i]["locationDetail"]["platform"];
                if(platform == null)
                {
                    platform = "UNKNOWN";
                }
                if (int.Parse(requestJSON.ServicesArray[i]["locationDetail"]["realtimeDeparture"].ToString()) >= int.Parse(currentTime))
                {
                    outputString += $"**{requestJSON.ServicesArray[i]["locationDetail"]["realtimeDeparture"].ToString().Insert(2, ":")}** **{TrainStation.Stations[stationOne]}** to **{TrainStation.Stations[stationTwo]}** from platform **{platform}**" + "\n";
                }
                
            }
            return outputString;
        }
    }
}
