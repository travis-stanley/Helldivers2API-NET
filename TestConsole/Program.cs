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

            var hdClient = Joel.Instance.SetWarId(801);

            var campaignPlanets = hdClient.GetCampaignPlanets();
            foreach (var p in campaignPlanets)
                Debug.Print($"Campaign on {p.Name}: Players {p.PlayerCount()} | {p.Health()} / {p.MaxHealth()}\nState: {p.PlanetState().State} | {p.PlanetState().Progress}");

            var eventPlanets = hdClient.GetPlanetEventPlanets();
            foreach (var p in eventPlanets)
                Debug.Print($"Planet Event on {p.Name}: {p.PlanetEvents().First()!.EventType} | Ending {p.PlanetEvents().First()!.Ending!.Value} | Progress {p.PlanetState().Progress}");

            var globalPlanets = hdClient.GetGlobalEventPlanets();
            foreach (var p in globalPlanets)
                Debug.Print($"Global Event on {p.Name}: {p.GlobalEvents().First()!.Title}");

            var assignmentPlanets = hdClient.GetAssignmentPlanets();
            foreach (var p in assignmentPlanets)
                Debug.Print($"Assignment on {p.Name}: {p.GetAssignments().First()!.Description}");

        }
    }
}