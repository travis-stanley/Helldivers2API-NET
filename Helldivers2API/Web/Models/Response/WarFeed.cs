using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Helldivers2API.Web
{

    /// <summary>
    /// WarFeed model, aka news feed.  
    /// This is said to be the data that is shown under Dispatch but the data in-game does not match the response.
    /// </summary>
    public class WarFeed
    {
        [JsonProperty("id")]
        public long Id { get; set; } = default!;

        [JsonProperty("published")]
        public long Published { get; set; } = default!;

        /// <summary>
        /// TODO: unknown, always is 0 so far
        /// </summary>
        [JsonProperty("type")]
        public int Type { get; set; } = default!;

        /// <summary>
        /// Message in the language defined in the request headers
        /// </summary>
        [JsonProperty("message")]
        public string Message { get; set; } = default!;

        /// <summary>
        /// TODO: unknown, always empty so far
        /// </summary>
        [JsonProperty("tagIds")]
        public List<string> TagIds { get; set; } = default!;

    }
}

