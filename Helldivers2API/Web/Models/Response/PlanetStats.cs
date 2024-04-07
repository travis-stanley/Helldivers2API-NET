using System.Collections.Generic;
using Helldivers2API.Web.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Helldivers2API.Web
{

    /// <summary>
    /// Planet Stats
    /// </summary>
    internal class PlanetStats
    {
        [JsonProperty("planetIndex")]
        public int PlanetIndex { get; set; }

        [JsonProperty("missionsWon")]
        public long MissionsWon { get; set; }

        [JsonProperty("missionsLost")]
        public long MissionsLost { get; set; }

        [JsonProperty("missionTime")]
        public long MissionTime { get; set; }

        [JsonProperty("bugKills")]
        public long BugKills { get; set; }

        [JsonProperty("automatonKills")]
        public long AutomatonKills { get; set; }

        [JsonProperty("illuminateKills")]
        public long IlluminateKills { get; set; }

        [JsonProperty("bulletsFired")]
        public long BulletsFired { get; set; }

        [JsonProperty("bulletsHit")]
        public long BulletsHit { get; set; }

        [JsonProperty("timePlayed")]
        public long TimePlayed { get; set; }

        [JsonProperty("deaths")]
        public long Deaths { get; set; }

        [JsonProperty("revives")]
        public long Revives { get; set; }

        [JsonProperty("friendlies")]
        public long Friendlies { get; set; }

        [JsonProperty("missionSuccessRate")]
        public int MissionSuccessRate { get; set; }

        [JsonProperty("accurracy")]
        public int Accurracy { get; set; }
    }
 }

