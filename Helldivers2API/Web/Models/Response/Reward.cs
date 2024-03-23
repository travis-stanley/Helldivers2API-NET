using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Helldivers2API.Web
{
    internal class Reward
    {
        // TODO: define enums for type

        [JsonProperty("type")]
        public int Type { get; set; } = default!;

        [JsonProperty("id32")]
        public long Id32 { get; set; } = default!;

        [JsonProperty("amount")]
        public int Amount { get; set; } = default!;      

    }
}

