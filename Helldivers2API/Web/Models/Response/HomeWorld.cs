using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Helldivers2API.Web
{

    /// <summary>
    /// HomeWorld model 
    /// </summary>
    public class HomeWorld
    {
        [JsonProperty("race")]
        public int Race { get; set; } = default!;

        [JsonProperty("planetIndices")]
        public List<int> PlanetIndices { get; set; } = default!;
    }
}

