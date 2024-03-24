
<h1 align="center">
  <p align="center">Helldivers2API-NET</p>
</h1>

Another open source library for the Helldivers2 API, but in .NET!
### Features

### Example

```csharp
using System;
using Helldivers2API;

class Program
{
    static async Task Main()
    {
      var hdClient = new Helldivers2API.Joel(801);

      var planets = hdClient.GetPlanets();
      var assignments = hdClient.GetAssignments();
      var newsfeeds = hdClient.GetNewsFeed();
      var warstatus  = hdClient.GetWarStatus();
      var warinfo = hdClient.GetWarInfo();  
    }
}
```
