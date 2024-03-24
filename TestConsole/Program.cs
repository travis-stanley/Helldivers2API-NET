using System.Diagnostics;

namespace TestConsole
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            var hdClient = new Helldivers2API.Joel(801);

            var planets = hdClient.GetPlanets();
            foreach (var planet in planets)
                Debug.Print($"Planet {planet.Name} resides in the {planet.SectorName} sector");

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
            

            Debug.Print("");
        }
    }
}