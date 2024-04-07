
using Helldivers2API.Web;
using Newtonsoft.Json;

namespace Helldivers2API.Data.Models
{

    /// <summary>
    /// Current stats from the war
    /// </summary>
    public class WarStats
    {
        /// <summary>
        /// Combined stats for all the planets in the galaxy
        /// </summary>
        public GalaxyStats GalaxyStats { get; set; } = default!;

        /// <summary>
        /// Stats for each planet
        /// </summary>
        public PlanetStats[] PlanetStats { get; set; } = default!;
    }


    /// <summary>
    /// War stats of the galaxy
    /// </summary>
    public class GalaxyStats
    {
        /// <summary>
        /// Total missions won
        /// </summary>
        public long MissionsWon { get; set; } = default!;

        /// <summary>
        /// Total missions lost
        /// </summary>
        public long MissionsLost { get; set; } = default!;

        /// <summary>
        /// Total time in seconds spent in missions
        /// </summary>
        public long MissionTime { get; set; } = default!;

        /// <summary>
        /// Total bug kills
        /// </summary>
        public long BugKills { get; set; } = default!;

        /// <summary>
        /// Total automaton kills
        /// </summary>
        public long AutomatonKills { get; set; } = default!;

        /// <summary>
        /// Total illuminate kills
        /// </summary>
        public long IlluminateKills { get; set; } = default!;

        /// <summary>
        /// Total bullets fired
        /// </summary>
        public long BulletsFired { get; set; } = default!;

        /// <summary>
        /// Total bullets hit
        /// </summary>
        public long BulletsHit { get; set; } = default!;

        /// <summary>
        /// Total time played
        /// </summary>
        public long TimePlayed { get; set; } = default!;

        /// <summary>
        /// Total deaths
        /// </summary>
        public long Deaths { get; set; } = default!;

        /// <summary>
        /// Total revives
        /// </summary>
        /// <remarks>
        /// Does not appear to be accurate/maintained
        /// </remarks>
        public long Revives { get; set; } = default!;

        /// <summary>
        /// Total friendly kills
        /// </summary>
        public long Friendlies { get; set; } = default!;

        /// <summary>
        /// Misson success rate
        /// </summary>
        public int MissionSuccessRate { get; set; } = default!;

        /// <summary>
        /// Total accuracy
        /// </summary>
        /// <remarks>
        /// Does not appear to be accurate/maintained
        /// </remarks>
        public int Accurracy { get; set; } = default!;
    }


    /// <summary>
    /// War stats of a planet
    /// </summary>
    public class PlanetStats
    {
        /// <summary>
        /// Planet id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Total missions won
        /// </summary>
        public long MissionsWon { get; set; } = default!;

        /// <summary>
        /// Total missions lost
        /// </summary>
        public long MissionsLost { get; set; } = default!;

        /// <summary>
        /// Total time in seconds spent in missions
        /// </summary>
        public long MissionTime { get; set; } = default!;

        /// <summary>
        /// Total bug kills
        /// </summary>
        public long BugKills { get; set; } = default!;

        /// <summary>
        /// Total automaton kills
        /// </summary>
        public long AutomatonKills { get; set; } = default!;

        /// <summary>
        /// Total illuminate kills
        /// </summary>
        public long IlluminateKills { get; set; } = default!;

        /// <summary>
        /// Total bullets fired
        /// </summary>
        public long BulletsFired { get; set; } = default!;

        /// <summary>
        /// Total bullets hit
        /// </summary>
        public long BulletsHit { get; set; } = default!;

        /// <summary>
        /// Total time played
        /// </summary>
        public long TimePlayed { get; set; } = default!;

        /// <summary>
        /// Total deaths
        /// </summary>
        public long Deaths { get; set; } = default!;

        /// <summary>
        /// Total revives
        /// </summary>
        /// <remarks>
        /// Does not appear to be accurate/maintained
        /// </remarks>
        public long Revives { get; set; } = default!;

        /// <summary>
        /// Total friendly kills
        /// </summary>
        public long Friendlies { get; set; } = default!;

        /// <summary>
        /// Misson success rate
        /// </summary>
        public int MissionSuccessRate { get; set; } = default!;

        /// <summary>
        /// Total accuracy
        /// </summary>
        /// <remarks>
        /// Does not appear to be accurate/maintained
        /// </remarks>
        public int Accurracy { get; set; } = default!;
    }

}
