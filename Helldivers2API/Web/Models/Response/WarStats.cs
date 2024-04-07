using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Helldivers2API.Web
{

    /// <summary>
    /// WarStats model 
    /// </summary>
    internal class WarStats
    {
        [JsonProperty("galaxy_stats")]
        public GalaxyStats GalaxyStats { get; set; } = default!;

        [JsonProperty("planets_stats")]
        public List<PlanetStats> PlanetStats { get; set; } = default!;

    }

}

