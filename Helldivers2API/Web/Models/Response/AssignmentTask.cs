using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Helldivers2API.Web
{
  public class AssignmentTask
    {
        // TODO: define enums for type
        // TODO: define enums for values
        // TODO: define enums for value types

        [JsonProperty("type")]
        public int Type { get; set; } = default!;

        [JsonProperty("values")]
        public List<int> Values { get; set; } = default!;

        [JsonProperty("valueTypes")]
        public List<int> ValueTypes { get; set; } = default!;

    }
}

