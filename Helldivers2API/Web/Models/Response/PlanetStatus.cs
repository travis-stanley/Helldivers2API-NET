using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Helldivers2API.Web
{

    internal class PlanetStatus
    {
        [JsonProperty("index")]
        public int Index { get; set; } = default!;

        [JsonProperty("owner")]
        public int Owner { get; set; } = default!;

        [JsonProperty("health")]
        public int Health { get; set; } = default!;

        [JsonProperty("regenPerSecond")]
        public double RegenPerSecond { get; set; } = default!;

        [JsonProperty("players")]
        public int Players { get; set; } = default!;
    }
}

