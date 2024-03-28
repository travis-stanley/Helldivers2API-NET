using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Helldivers2API.Web
{

    /// <summary>
    /// WarStatus model 
    /// </summary>
    internal class WarStatus
    {
        [JsonProperty("warId")]
        public int WarId { get; set; } = default!;

        [JsonProperty("time")]
        public int Time { get; set; } = default!;

        [JsonProperty("impactMultiplier")]
        public double ImpactMultiplier { get; set; } = default!;

        [JsonProperty("storyBeatId32")]
        public long StoryBeatId32 { get; set; } = default!;

        [JsonProperty("planetStatus")]
        public List<PlanetStatus> PlanetStatus { get; set; } = default!;

        [JsonProperty("planetAttacks")]
        public List<PlanetAttack> PlanetAttacks { get; set; } = default!;

        [JsonProperty("campaigns")]
        public List<Campaign> Campaigns { get; set; } = default!;

        [JsonProperty("jointOperations")]
        public List<JointOperation> JointOperations { get; set; } = default!;

        [JsonProperty("planetEvents")]
        public List<PlanetEvent> PlanetEvents { get; set; } = default!;

       // TBD
       //[JsonProperty("communityTargets")]
       // public List<string> CommunityTargets { get; set; } = default!;

       // TBD
       //[JsonProperty("planetActiveEffects")]
       // public List<int> PlanetActiveEffects { get; set; } = default!;

       // TBD
       //[JsonProperty("activeElectionPolicyEffects")]
       // public List<int> ActiveElectionPolicyEffects { get; set; } = default!;

       [JsonProperty("globalEvents")]
        public List<GlobalEvent> GlobalEvents { get; set; } = default!;

        // TBD
       //[JsonProperty("superEarthWarResults")]
       // public List<object> SuperEarthWarResults { get; set; } = default!;
    }

}

