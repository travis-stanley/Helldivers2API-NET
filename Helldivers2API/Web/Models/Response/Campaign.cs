using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Helldivers2API.Web
{

    public class Campaign
    {
        [JsonProperty("id")]
        public int Id { get; set; } = default!;

        [JsonProperty("planetIndex")]
        public int PlanetIndex { get; set; } = default!;

        [JsonProperty("type")]
        public int Type { get; set; } = default!;

        [JsonProperty("count")]
        public int Count { get; set; } = default!;
    } 
}

