
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
        public PlanetStatus[] PlanetStatuses { get; set; } = default!;
        public PlanetAttack[] PlanetAttacks { get; set; } = default!;
        public Campaign[] Campaigns { get; set; } = default!;
        public JointOperation[] JointOperations { get; set; } = default!;
        public PlanetEvent[] PlanetEvents { get; set; } = default!;
    }


    /// <summary>
    /// War status of a planet
    /// </summary>
    public class PlanetStatus
    {
        public int Id { get; set; } = default!;
        public int Owner { get; set; } = default!;
        public int Health { get; set; } = default!;
        public double RegenPerSecond { get; set; } = default!;
        public int Players { get; set; } = default!;

    }

    /// <summary>
    /// Planet attack data
    /// </summary>
    public class PlanetAttack
    {
        public int source { get; set; }
        public int target { get; set; }
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
    /// Planet event details
    /// </summary>
    public class PlanetEvent
    {
        public int Id { get; set; } = default!;
        public int PlanetId { get; set; } = default!;
        public int EventType { get; set; } = default!;
        public int Race { get; set; } = default!;
        public int Health { get; set; } = default!;
        public int MaxHealth { get; set; } = default!;
        public int StartTime { get; set; } = default!;
        public int ExpireTime { get; set; } = default!;
        public int CampaignId { get; set; } = default!;
        public int[] JointOperationIds { get; set; } = default!;
    }

}
