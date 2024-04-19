using Helldivers2API;
using Helldivers2API.Data.Models.Extensions;
using System.Collections.Specialized;
using System.Diagnostics;

namespace TestConsole
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //var hdClient = Joel.Instance.SetWarId(801);
            var hdClient = Joel.Instance;

            TestGetAssignmentPlanets(hdClient);
            TestGetAssignments(hdClient);
            TestGetBiomes(hdClient);
            TestGetCampaignPlanets(hdClient);
            TestGetGlobalEventPlanets(hdClient);
            TestGetLatestNews(hdClient);    
            TestGetPlanets(hdClient);
            TestGetWarInfo(hdClient);
            TestGetWarStats(hdClient);
            TestGetWarStatus(hdClient);
            TestGetWebApiCalls(hdClient);
            Console.ReadKey();
        }

        private static void TestGetPlanets(Joel hdClient)
        {
            foreach (var a in hdClient.GetPlanets())
                Console.WriteLine(a.Name);
        }

        private static void TestGetGlobalEventPlanets(Joel hdClient)
        {
            foreach (var a in hdClient.GetGlobalEventPlanets())
                Console.WriteLine(a.SectorName);
        }

        private static void TestGetAssignments(Joel hdClient)
        {
            foreach (var a in hdClient.GetAssignments())
                Console.WriteLine(a.Brief);
        }

        private static void TestGetBiomes(Joel hdClient)
        {
            foreach (var a in hdClient.GetBiomes())
                Console.WriteLine(a.Name);
        }

        private static void TestGetAssignmentPlanets(Joel hdClient)
        {
            foreach (var a in hdClient.GetAssignmentPlanets())
                Console.WriteLine(a.Name);
        }

        private static void TestGetCampaignPlanets(Joel hdClient)
        {
            foreach (var a in hdClient.GetCampaignPlanets())
                Console.WriteLine(a.Name);
        }

        private static void TestGetLatestNews(Joel hdClient)
        {
            foreach (var a in hdClient.GetLatestNews())
                Console.WriteLine(a.Message);
        }

        private static void TestGetWarInfo(Joel hdClient)
        {
            var a = hdClient.GetWarInfo();
            Console.WriteLine(a.WarId);
        }

        private static void TestGetWarStats(Joel hdClient)
        {
            var a = hdClient.GetWarStats();
            Console.WriteLine(a.GalaxyStats.BulletsFired);
        }

        private static void TestGetWarStatus(Joel hdClient)
        {
            var a = hdClient.GetWarStatus();
            Console.WriteLine(a.Time);
        }
        private static void TestGetWebApiCalls(Joel hdClient)
        {
            foreach (var a in hdClient.GetWebApiCalls())
                Console.WriteLine(a.Key);
        }
    }
}