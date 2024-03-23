using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Helldivers2API.Web
{

    public class JointOperation
    {
        [JsonProperty("id")]
        public int Id { get; set; } = default!;

        [JsonProperty("planetIndex")]
        public int PlanetIndex { get; set; } = default!;

        [JsonProperty("hqNodeIndex")]
        public int HqNodeIndex { get; set; } = default!;
    } 

} 

