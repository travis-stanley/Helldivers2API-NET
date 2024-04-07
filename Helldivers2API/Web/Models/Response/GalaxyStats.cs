using System.Collections.Generic;
using Helldivers2API.Web.Data;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Helldivers2API.Web
{

    /// <summary>
    /// Galaxy Stats
    /// </summary>
    internal class GalaxyStats
    {
        [JsonProperty("missionsWon")]
        public long MissionsWon { get; set;  } = default!;

        [JsonProperty("missionsLost")]
        public long MissionsLost { get; set;  } = default!;

        [JsonProperty("missionTime")]
        public long MissionTime { get; set;  } = default!;

        [JsonProperty("bugKills")]
        public long BugKills { get; set;  } = default!;

        [JsonProperty("automatonKills")]
        public long AutomatonKills { get; set;  } = default!;

        [JsonProperty("illuminateKills")]
        public long IlluminateKills { get; set;  } = default!;

        [JsonProperty("bulletsFired")]
        public long BulletsFired { get; set;  } = default!;

        [JsonProperty("bulletsHit")]
        public long BulletsHit { get; set;  } = default!;

        [JsonProperty("timePlayed")]
        public long TimePlayed { get; set;  } = default!;

        [JsonProperty("deaths")]
        public long Deaths { get; set;  } = default!;

        [JsonProperty("revives")]
        public long Revives { get; set;  } = default!;

        [JsonProperty("friendlies")]
        public long Friendlies { get; set;  } = default!;

        [JsonProperty("missionSuccessRate")]
        public int MissionSuccessRate { get; set;  } = default!;

        [JsonProperty("accurracy")]
        public int Accurracy { get; set;  } = default!;
     }
 }

