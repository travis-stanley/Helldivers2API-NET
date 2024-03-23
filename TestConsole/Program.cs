using Helldivers2API.Web;
using Helldivers2API.Web.Clients;
using System.Diagnostics;

namespace TestConsole
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var hdClient = new Helldivers2Client();

            var currentWarId = 801;

            //Helldivers2API.Web.Data.PlanetParser.ParseMetadata();
            //Helldivers2API.Web.Data.SectorParser.ParseFromPlanets();

        }

        private static async Task TestGetWarStatus(Helldivers2Client hdClient, int warId)
        {
            var warStatus = await hdClient.WarStatus.Get(warId);
            Console.WriteLine($"{warStatus.WarId}");

            foreach (var pi in warStatus.PlanetAttacks.OrderBy(o => o.target))
            {
                Console.WriteLine($"{pi.source}");
            }

        }
        private static async Task TestGetWarInfo(Helldivers2Client hdClient, int warId)
        {
            var warInfo = await hdClient.WarInfo.Get(warId);
            Console.WriteLine($"{warInfo.WarId}");

            foreach (var pi in warInfo.PlanetInfos.OrderBy(o => o.Index))
            {
                Console.WriteLine($"{pi.Index}");
            }
        }

        private static async Task TestGetWarFeeds(Helldivers2Client hdClient, int warId)
        {
            var warFeeds = await hdClient.WarFeeds.Get(warId);

            foreach (WarFeed wf in warFeeds.OrderByDescending(o => o.Id))
            {
                Console.WriteLine($"{wf.Message}");
            }
        }

        private static async Task TestGetAssignments(Helldivers2Client hdClient, int warId)
        {
            var assignments = await hdClient.Assignments.Get(warId);

            if (assignments.Count > 0)
            {
                var firstAssignment = assignments.First();
                Console.WriteLine(firstAssignment.ExpiresIn);
                Console.WriteLine(firstAssignment.Setting.OverrideBrief);
            }
            else
            {
                Console.WriteLine("Awaiting Major Order...");
            }
        }

        private static async Task TestEndpoint(string url)
        {
            using HttpClient client = new();
            var result = await client.GetStringAsync(url);
            Debug.Print(result);
        }

    }
}