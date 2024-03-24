using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Helldivers2API.Web
{
    internal class AssignmentTask
    {
        [JsonProperty("type")]
        public int Type { get; set; } = default!;

        [JsonProperty("values")]
        public List<int> Values { get; set; } = default!;

        [JsonProperty("valueTypes")]
        public List<int> ValueTypes { get; set; } = default!;

    }
}

