
<h1 align="center">
  <p align="center">Helldivers2API-NET</p>
  <a href="#">
    <img
      src="Helldivers2API/hdlogo.png"
      >
  </a>
</h1>

Another *unofficial* open source library for the Helldivers2 API, but in .NET!

### Features
 
 ✅ Spreading democracy

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
