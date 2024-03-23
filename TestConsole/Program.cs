using Helldivers2API.Web;
using Helldivers2API.Web.Clients;
using System.Diagnostics;

namespace TestConsole
{
    internal class Program
    {
        static async Task Main(string[] args)
        {

            var hdClient = new Helldivers2API.Joel(801);

            var planets = hdClient.GetPlanets();
            var assignments = hdClient.GetAssignments();

            var assignments2 = hdClient.GetAssignments();

            var lastRef = hdClient.GetLastRefreshed();

            Debug.Print("");
        }



    }
}