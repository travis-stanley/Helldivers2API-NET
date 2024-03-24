
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

Another open source library for the undocumented Helldivers2 API

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

### Cache System

The built-in cache system was designed to avoid sending unnecessary requests to the web api endpoints.  It's entirely internal and you do not need to manage it.  Just request the data and it will handle the rest.

The default cache expiration is about `5 minutes`, although this may change in the future.  If you modify this value, please be considerate to the game servers.

> [!TIP]
> The web api is never hit until the first request for data is made, at which point only the necessary endpoints are requested.
```csharp
static void HDClient()
{
    // Instantiate using the current war id, aka game season
    // The current war id is 801
    var hdClient = new Helldivers2API.Joel(801);

    var planets = hdClient.GetPlanets();
    foreach (var planet in planets)
        Debug.Print($"Planet {planet.Name} resides in the {planet.SectorName} sector");

    var assignments = hdClient.GetAssignments();
    foreach (var assignment in assignments)
        Debug.Print($"Assignment: {assignment.Brief}");

    // this call will return data from the local cache since it was just requested (web api endpoint is not hit again)
    var assignments2 = hdClient.GetAssignments();

    var newsfeeds = hdClient.GetNewsFeed();
    foreach (var newsfeed in newsfeeds)
        Debug.Print($"{newsfeed.Message}");

    // omitted for cache example
    //var warstatus  = hdClient.GetWarStatus();

    // omitted for cache example
    //var warinfo = hdClient.GetWarInfo();

    var lastRef = hdClient.GetLastRefreshed();
    foreach (var lastRefreshed in lastRef)
        Debug.Print($"{lastRefreshed.Key} was last refreshed {lastRefreshed.Value}");
}

// Assignments was last refreshed 3/24/2024 12:25:25 PM
// WarInfo was last refreshed    <-- date is null because it was never called, thus a request was never sent to the web api endpoint
// WarStatus was last refreshed  <-- date is null because it was never called, thus a request was never sent to the web api endpoint
// NewsFeed was last refreshed 3/24/2024 12:25:25 PM
```

### Documentation

Work in progress
