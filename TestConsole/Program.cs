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
        }
    }
}