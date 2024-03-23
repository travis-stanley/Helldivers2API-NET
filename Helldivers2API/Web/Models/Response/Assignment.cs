using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Helldivers2API.Web
{
    // TODO: determine what the progress list is    

    /// <summary>
    /// Assignment model, aka the Major Order
    /// </summary>
    internal class Assignment
    {
        [JsonProperty("id32")]
        public long Id32 { get; set; } = default!;

        [JsonProperty("expiresIn")]
        public long ExpiresIn { get; set; } = default!;

        [JsonProperty("progress")]
        public List<int> Progress { get; set; } = default!;

        [JsonProperty("setting")]
        public Setting Setting { get; set; } = default!;

    }
}

