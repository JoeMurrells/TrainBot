# TrainBot

A discord bot which will provide the departure time and platform of trains in the UK. The data is provided by the Realtime Trains API found here https://api.rtt.io/.

## Usage

Enter the command !train followed by the departing station and destination station using the stations CRS code, this will display all trains after the current time.\
\
Example: !train PRE EUS\
\
`17:47 Preston (Lancs) to London Euston from platform 5`\
`18:01 Preston (Lancs) to London Euston from platform 6`\
`18:17 Preston (Lancs) to London Euston from platform 4`


You can also provide a specific time in the format HHMM, this will show trains within a 2 hour window of the given time.\
\
Example: !train PRE EUS 1730

`17:45 Preston (Lancs) to London Euston from platform 5`\
`18:04 Preston (Lancs) to London Euston from platform 6`\
`18:17 Preston (Lancs) to London Euston from platform 4`

Enter the command !search followed by a 3 digit CRS code or station name to retrieve of a list of matching stations.\
\
Example: !search gillingham

`GIL: Gillingham (Dorset)`\
`GLM: Gillingham (Kent)`\
`HAM: Hamworthy`

This information is also available using the !help command.

## Packages
[Discord.net](https://discordnet.dev/index.html)\
[JSON.net](https://www.newtonsoft.com/json)\
[FuzzySharp](https://github.com/JakeBayer/FuzzySharp)
