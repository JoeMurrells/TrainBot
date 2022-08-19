using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

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
                if(int.Parse(requestJSON.ServicesArray[i]["locationDetail"]["realtimeDeparture"].ToString()) >= int.Parse(currentTime))
                {
                    outputString += $"{stationOne} to {stationTwo} train will depart at {requestJSON.ServicesArray[i]["locationDetail"]["realtimeDeparture"]} from platform {requestJSON.ServicesArray[i]["locationDetail"]["platform"]}" + "\n";
                }
                
            }
            return outputString;
        }
    }
}
