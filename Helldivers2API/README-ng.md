Another open source library for the undocumented Helldivers2 API.
This project reads directly from game's api and does not use an intermediary-hosted api.

### Features
 
* `.NET 7`
* Easy to use
* Built-in cache system
* Consolidates various planet data under a single source
* Leverages the game's api directly, e.g. does not use an intermediary api that may stop working
* Helps spread managed democracy

### Planets, Planets, Planets
The majority of data from the Helldivers2 API is associated to one or more planets.  Because of this, we have made most data retrievable directly from the IPlanet object.  There's no need to jump through multiple requests and pair the data together, this project has done this internally.  

### Overview

All information is retrievable through the convenient `Joel` class.

* Initializes itself to the current war id (added in version 1.1.4)
* Get statistics (added in version 1.1.3)
* Get current assignments, e.g. the `Major Order`
* Get news from the galaxy
* Get status of the on-going war efforts
* Get information of the on-going war
* Get all the known planets in the galaxy, including their
  * Sector
  * Biome
  * Envrionmental conditions (fire storms, etc)  
  * Supply lines to other planets
  * Player count
  * Health / MaxHealth
  * Planets attacking it
  * Planets it is attacking
  * Original owning faction
  * Current owning faction
  * Factions that claim it as a home world
  * Regen rates
  * Active campaigns
  * Associated planet events
  * Associated global events
  * Associated joint operations
  * etc

### Installation

Install the NuGet package via...

the package manager
```NuGet\Install-Package Helldivers2API```

or .NET CLI
```dotnet add package Helldivers2API```

### Getting Started

Get the client by setting the current war id, via `Joel`
```csharp
// Sets the current war id, as of 1.1.4
var hdClient = Helldivers2API.Joel.Instance;

// No longer needed, unless you want to override war id
// var hdClient = Helldivers2API.Joel.Instance.SetWarId(801);
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
> The information from the WarStatus and WarInfo that relates to a Planet is retrievable from the Planet object directly.  These properties have been marked with internal to hide their visibility and prevent accidental use.

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

The default cache expiration is about `5 minutes`, although this may change in the future.

> [!TIP]
> The web api is never hit until the first request for data is made, at which point only the necessary endpoints are requested.
```csharp
static void HDClient()
{
    // Sets the current war id, as of 1.1.4
    var hdClient = Helldivers2API.Joel.Instance;

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

See technical documentation at, https://travis-stanley.github.io/Helldivers2API-NET/api/Helldivers2API.html

### Community

Thanks to all the various communities and sources out there that have documented and shared information about the Helldivers2 API.
