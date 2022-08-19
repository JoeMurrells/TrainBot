# TrainBot

A discord bot which will provide the departure time and platform of a train. The data is provided by the Realtime Trains API found here https://api.rtt.io/.

## Usage

Enter the command !train followed by the departing station and destination station using the stations CRS code, this will display all trains after the current time.\
\
Example: !train VIC BTN\
\
`VIC to BTN train will depart at 1432 from platform 18`

You can also provide a specific time in the format HHMM, this will show trains within a 2 hour window of the given time.\
\
Example: !train VIC BTN 1630

`VIC to BTN train will depart at 1632 from platform 18`\
`VIC to BTN train will depart at 1702 from platform 18`

This information is also available using the !help command.

## Packages
[Discord.net](https://discordnet.dev/index.html)\
[JSON.net](https://www.newtonsoft.com/json)
