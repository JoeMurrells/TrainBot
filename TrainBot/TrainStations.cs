using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainBot
{
    public static class TrainStation
    {
      
        public static bool Valid(string stationOne, string stationTwo)
        {
            if(Stations.ContainsKey(stationOne) && Stations.ContainsKey(stationTwo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private static readonly Dictionary<string, string> Stations = new Dictionary<string, string>() {

            {"BTN", "Brighton" },
            {"VIC", "London Victoria" }

        };
    }
}
