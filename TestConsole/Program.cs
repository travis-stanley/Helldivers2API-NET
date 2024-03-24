using Helldivers2API.Data.Models.Extensions;
using System.Collections.Specialized;
using System.Diagnostics;

namespace TestConsole
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            HDClient();
            

            Debug.Print("");
        }


        static void HDClient()
        {
            // Instantiate using the current war id, aka game season
            // The current war id is 801
            var hdClient = Helldivers2API.Joel.Instance.SetWarId(801);
            
            var planets = hdClient.GetPlanets();
            foreach (var planet in planets)
            {
                Debug.Print($"Planet {planet.Name} resides in the {planet.SectorName} sector");
                Debug.Print($"Initial Owning Faction: {planet.InitialOwner()?.Name}");
                var sl = planet.SupplyLinesTo();
                foreach (var line in sl)
                    Debug.Print($"\t--> {line?.Name}");

                var slf = planet.SupplyLinesFrom();
                foreach (var line in slf)
                    Debug.Print($"\t <-- {line?.Name}");

                var hwf = planet.HomeWorldFor();
                foreach (var line in hwf)
                    Debug.Print($"\tHomeworld for: {line?.Name}");
            }                

            var assignments = hdClient.GetAssignments();
            foreach (var assignment in assignments)
                Debug.Print($"Assignment: {assignment.Brief}");

            var assignments2 = hdClient.GetAssignments();

            var newsfeeds = hdClient.GetNewsFeed();
            foreach (var newsfeed in newsfeeds)
                Debug.Print($"{newsfeed.Message}");


            //var warstatus  = hdClient.GetWarStatus();

            //var warinfo = hdClient.GetWarInfo();


            var lastRef = hdClient.GetLastRefreshed();
            foreach (var lastRefreshed in lastRef)
                Debug.Print($"{lastRefreshed.Key} was last refreshed {lastRefreshed.Value}");
        }
    }
}