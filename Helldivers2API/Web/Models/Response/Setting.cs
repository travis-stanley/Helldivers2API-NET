using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Helldivers2API.Web
{

    /// <summary>
    /// Nested property in Assignment
    /// </summary>
    internal class Setting
    {

        [JsonProperty("type")]
        public int Type { get; set; } = default!;

        [JsonProperty("overrideTitle")]
        public string OverrideTitle { get; set; } = default!;

        [JsonProperty("overrideBrief")]
        public string OverrideBrief { get; set; } = default!;

        [JsonProperty("taskDescription")]
        public string TaskDescription { get; set; } = default!;

        [JsonProperty("tasks")]
        public List<AssignmentTask> Tasks { get; set; } = default!;

        [JsonProperty("reward")]
        public Reward Reward { get; set; } = default!;

        [JsonProperty("flags")]
        public int Flags { get; set; } = default!;

    }
}

