using System.Collections.Generic;
using Helldivers2API.Web.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Helldivers2API.Web
{

    /// <summary>
    /// PlanetInfo
    /// </summary>
    internal class PlanetInfo
    {
        [JsonProperty("index")]
        public int Index { get; set; } = default!;

        [JsonProperty("settingsHash")]
        public object SettingsHash { get; set; } = default!;

        [JsonProperty("position")]
        public Position Position { get; set; } = default!;

        [JsonProperty("waypoints")]
        public List<int> Waypoints { get; set; } = default!;

        [JsonProperty("sector")]
        public int Sector { get; set; } = default!;

        [JsonProperty("maxHealth")]
        public int MaxHealth { get; set; } = default!;

        [JsonProperty("disabled")]
        public bool Disabled { get; set; } = default!;

        [JsonProperty("initialOwner")]
        public int InitialOwner { get; set; } = default!;
       
    }
}

