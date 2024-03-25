
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
        public int Time { get; set; } = default!;
        public double ImpactMultiplier { get; set; } = default!;
        public int StoryBeatId32 { get; set; } = default!;

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
        public int Type { get; set; } = default!;   // TODO: define what this is
        public int Count { get; set; } = default!;  // TODO: define what this is
    }


    /// <summary>
    /// Joint operation data
    /// </summary>
    public class JointOperation
    {
        public int Id { get; set; } = default!;
        public int PlanetId { get; set; } = default!;
        public int HqNodeIndex { get; set; } = default!;    // TODO: define what this is
    }


    /// <summary>
    /// Planet event details
    /// </summary>
    /// <remarks>
    /// TODO: redundant data.. research what's needed
    /// </remarks>
    public class PlanetEvent
    {
        public int Id { get; set; } = default!;
        public int PlanetId { get; set; } = default!;
        public int EventType { get; set; } = default!;  // TODO: define what this is
        public int FactionId { get; set; } = default!;
        public int Health { get; set; } = default!;
        public int MaxHealth { get; set; } = default!;
        public int StartTime { get; set; } = default!;
        public int ExpireTime { get; set; } = default!;
        public int CampaignId { get; set; } = default!;
        public int[] JointOperationIds { get; set; } = default!;
    }

    /// <summary>
    /// Global event details
    /// </summary>
    public class GlobalEvent
    {
        public int Id { get; set; } = default!;
        public string Title { get; set; } = default!;
        public string Message { get; set; } = default!;
        public int FactionId { get; set; } = default!;
        public int[] EffectIds { get; set; } = default!;    // TODO: define what this is
        public int[] PlanetIds { get; set; } = default!;
    }

}
