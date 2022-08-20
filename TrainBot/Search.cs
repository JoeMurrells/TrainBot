using FuzzySharp;
using System.Collections.Generic;


namespace TrainBot
{
    public static class Search
    {
        public static string SearchStation(string searchStation)
        {
            string outputString = "";

            foreach(KeyValuePair<string, string> station in TrainStation.Stations)
            {
                var textMatch = Fuzz.WeightedRatio(searchStation.ToLower(), station.Key.ToLower());
                var codeMatch = Fuzz.WeightedRatio(searchStation.ToLower(), station.Value.ToLower());

                if (textMatch > 85 || codeMatch > 85)
                {
                    outputString += $"**{station.Key}**: {station.Value}" + "\n";
                }
            }

            if(outputString == "")
            {
                return "No stations found :(";
            }
            else
            {
                return outputString;
            }
        }
    }
}
