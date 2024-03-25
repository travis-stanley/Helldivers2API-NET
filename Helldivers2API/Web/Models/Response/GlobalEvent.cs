using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Helldivers2API.Web
{

    internal class GlobalEvent
    {
        [JsonProperty("eventId")]
        public int Id { get; set; } = default!;

        [JsonProperty("title")]
        public string Title { get; set; } = default!;

        [JsonProperty("message")]
        public string Message { get; set; } = default!;

        [JsonProperty("race")]
        public int Race { get; set; } = default!;

        [JsonProperty("effectIds")]
        public List<int> EffectIds { get; set; } = default!;

        [JsonProperty("planetIndices")]
        public List<int> PlanetIndices { get; set; } = default!;
    } 

} 

