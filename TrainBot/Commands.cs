using Discord.Commands;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TrainBot
{
    public class Commands : ModuleBase<SocketCommandContext>
    {
        [Command("train")]
        public async Task Train(string stationOne, string stationTwo, string time = "")
        {
            

            if(TrainStation.Valid(stationOne,stationTwo) == true)
            {
                await ReplyAsync(BotResponse.OutputString(stationOne, stationTwo, time));
            }
            else
            {
                await ReplyAsync("Invalid station entered");
            }

            

        }

        [Command("help")]
        public async Task Help()
        {
            await ReplyAsync("Enter the command !train followed by the departing station and destination station using the stations CRS code" + "\n" + "Example \"!train VIC BTN\"" + "\n" + "" + "\n" + "You can optionally enter a time in HHMM format to show trains departing 2 hours either side of the given time" + "\n" + "Example \"!train VIC BTN 1630\"");
        }

    }
}
