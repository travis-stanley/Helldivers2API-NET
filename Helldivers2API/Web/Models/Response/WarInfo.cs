using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Helldivers2API.Web
{

    /// <summary>
    /// WarInfo model 
    /// </summary>
    internal class WarInfo
    {
        [JsonProperty("warId")]
        public int WarId { get; set; } = default!;

        [JsonProperty("startDate")]
        public int StartDate { get; set; } = default!;

        [JsonProperty("endDate")]
        public int EndDate { get; set; } = default!;

        [JsonProperty("minimumClientVersion")]
        public string MinimumClientVersion { get; set; } = default!;

        [JsonProperty("planetInfos")]
        public List<PlanetInfo> PlanetInfos { get; set; } = default!;

        [JsonProperty("homeWorlds")]
        public List<HomeWorld> HomeWorlds { get; set; } = default!;

        [JsonProperty("capitalInfos")]
        public List<string> CapitalInfos { get; set; } = default!;

        [JsonProperty("planetPermanentEffects")]
        public List<int> PlanetPermanentEffects { get; set; } = default!;
    }   
}

