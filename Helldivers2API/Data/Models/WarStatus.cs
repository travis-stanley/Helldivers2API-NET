
using Helldivers2API.Web;
using Newtonsoft.Json;

namespace Helldivers2API.Data.Models
{

    /// <summary>
    /// Current status of the war
    /// </summary>
    public class WarStatus
    {
        public int WarId { get; set; } = default!;

        /// <summary>
        /// Current time represented as seconds from an unknown point.
        /// </summary>
        public int Time { get; set; } = default!;

        /// <summary>
        /// The date and time when this data was retrieved. 
        /// </summary>
        public DateTime TimeAsDateTime { get; set; } = default!;

        public double ImpactMultiplier { get; set; } = default!;
        public long StoryBeatId32 { get; set; } = default!;

        /// <summary>
        /// Internal use only.  Get this data through the IPlanet extension methods.
        /// </summary>
        internal PlanetStatus[] PlanetStatuses { get; set; } = default!;

        /// <summary>
        /// Internal use only.  Get this data through the IPlanet extension methods.
        /// </summary>
        internal PlanetAttack[] PlanetAttacks { get; set; } = default!;

        /// <summary>
        /// Internal use only.  Get this data through the IPlanet extension methods.
        /// </summary>
        internal Campaign[] Campaigns { get; set; } = default!;

        /// <summary>
        /// Internal use only.  Get this data through the IPlanet extension methods.
        /// </summary>
        internal JointOperation[] JointOperations { get; set; } = default!;

        /// <summary>
        /// Internal use only.  Get this data through the IPlanet extension methods.
        /// </summary>
        internal PlanetEvent[] PlanetEvents { get; set; } = default!;

        /// <summary>
        /// Internal use only.  Get this data through the IPlanet extension methods.
        /// </summary>
        internal GlobalEvent[] GlobalEvents { get; set; } = default!;
    }


    /// <summary>
    /// War status of a planet
    /// </summary>
    internal class PlanetStatus
    {
        public int Id { get; set; } = default!;
        public int OwnerId { get; set; } = default!;
        public int Health { get; set; } = default!;
        public double RegenPerSecond { get; set; } = default!;
        public int PlayerCount { get; set; } = default!;

    }

    /// <summary>
    /// Planet attack data
    /// </summary>
    internal class PlanetAttack
    {
        public int SourceId { get; set; }
        public int TargetId { get; set; }
    }

    /// <summary>
    /// Campaign data
    /// </summary>
    public class Campaign
    {
        public int Id { get; set; } = default!;
        public int PlanetId { get; set; } = default!;
        public int Type { get; set; } = default!;
        public int Count { get; set; } = default!;
    }


    /// <summary>
    /// Joint operation data
    /// </summary>
    public class JointOperation
    {
        public int Id { get; set; } = default!;
        public int PlanetId { get; set; } = default!;
        public int HqNodeIndex { get; set; } = default!;
    }


    /// <summary>
    /// Planet event details.  
    /// This is the planet on the map with a player focus and countdown timer.
    /// </summary>
    /// <remarks>
    /// </remarks>
    public class PlanetEvent
    {
        public int Id { get; set; } = default!;

        /// <summary>
        /// Planet id
        /// </summary>
        public int PlanetId { get; set; } = default!;

        /// <summary>
        /// Type: 1 is defened, 2 is attack?
        /// </summary>
        public int EventType { get; set; } = default!;

        /// <summary>
        /// The faction that owns this planet.  
        /// Redundant.
        /// </summary>
        internal int FactionId { get; set; } = default!;

        /// <summary>
        /// This overrides the health from PlanetStatus... 
        /// </summary>
        public int Health { get; set; } = default!;

        /// <summary>
        /// This overrides the max health from PlanetStatus...
        /// </summary>
        public int MaxHealth { get; set; } = default!;

        /// <summary>
        /// When it started. Offset seconds from WarStatus.time (current time)
        /// </summary>
        internal int StartTime { get; set; } = default!;

        internal int ExpireTime { get; set; } = default!;
        public int CampaignId { get; set; } = default!;
        public int[] JointOperationIds { get; set; } = default!;

        /// <summary>
        /// When this event started
        /// </summary>
        public DateTime? Started { get; set; } = default!;

        /// <summary>
        /// Total time of this event
        /// </summary>
        public TimeSpan? TotalTime { get; set; } = default!;

        /// <summary>
        /// When this event will expire
        /// </summary>
        public DateTime? Ending { get; set;} = default!;

        /// <summary>
        /// If this event has expired
        /// </summary>
        public bool HasEnded
        {
            get
            {
                if (!Ending.HasValue) return true;
                return DateTime.Now.CompareTo(Ending.Value) >= 0 ? true : false;
            }
        }
    }

    /// <summary>
    /// Global event details.
    /// This is weapon or stratagem authorizations for specific planets.
    /// </summary>
    public class GlobalEvent
    {
        public int Id { get; set; } = default!;

        /// <summary>
        /// Description of the event.
        /// </summary>
        public string Title { get; set; } = default!;

        /// <summary>
        /// Appears to be empty
        /// </summary>
        public string Message { get; set; } = default!;

        /// <summary>
        /// The faction this applies to
        /// </summary>
        public int FactionId { get; set; } = default!;

        /// <summary>
        /// Unknown.
        /// </summary>
        public int[] EffectIds { get; set; } = default!; 

        /// <summary>
        /// List of planet ids this event applies to
        /// </summary>
        public int[] PlanetIds { get; set; } = default!;
    }

}
