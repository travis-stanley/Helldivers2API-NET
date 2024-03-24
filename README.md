
<h1 align="center">
  <p align="center">Helldivers2API-NET</p>
  <a href="#">
    <img
      height="205"
      width="364"
      src="Helldivers2API/hdlogo.png"
      >
  </a>
</h1>

Another open source library for the undocumented Helldivers2 API, and in .NET!

### Features
 
* `.NET 7`
* Easy to use
* Built-in cache system
* Spreading managed democracy

### Getting Started

All information is retrievable through the convenient `Joel` class.
* Get current assignments, aka the `Major Order`
* Get news from the galaxy
* Get status of the on-going war efforts
* Get information of the on-going war
* Get all the known planets in the galaxy, including
  * Sector
  * Biomes
  * Envrionmental conditions (fire storms, etc)  
  * Supply lines to other planets
  * Player count
  * Health
  * etc

> [!TIP]
> The war id parameter is required to send requests to the web endpoints, but it does not appear to be advertised anywhere.

> [!WARNING]
> The war id will likely change when the game transitions to the next season.

Create a client via `Joel`
```csharp
// Instantiate using the current war id, aka game season
// The current war id is 801
var hdClient = new Helldivers2API.Joel(801);  
```

Get all the known planets
```csharp
var planets = hdClient.GetPlanets();
foreach (var planet in planets)
    Debug.Print($"Planet {planet.Name} resides in the {planet.SectorName} sector");
```

Get all the assignments
```csharp
var assignments = hdClient.GetAssignments();
foreach (var assignment in assignments)
    Debug.Print($"Assignment: {assignment.Brief}");
```

Get all the news
```csharp
var newsfeeds = hdClient.GetNewsFeed();
foreach (var newsfeed in newsfeeds)
    Debug.Print($"{newsfeed.Message}");
```

> [!NOTE]
> The information from the WarStatus and WarInfo that relates to a Planet will be retrievable from the Planet object directly.

Get the status of the on-going war efforts
```csharp
var warstatus = hdClient.GetWarStatus();
```

Get information about the war
```csharp
var warinfo = hdClient.GetWarInfo();
```


### Documentation

Work in progress
