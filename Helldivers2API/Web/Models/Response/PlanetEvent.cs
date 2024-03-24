using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Helldivers2API.Web
{

    internal class PlanetEvent
    {
        [JsonProperty("id")]
        public int Id { get; set; } = default!;

        [JsonProperty("planetIndex")]
        public int PlanetIndex { get; set; } = default!;
        
        [JsonProperty("eventType")]
        public int EventType { get; set; } = default!;

        [JsonProperty("race")]
        public int Race { get; set; } = default!;

        [JsonProperty("health")]
        public int Health { get; set; } = default!;

        [JsonProperty("maxHealth")]
        public int MaxHealth { get; set; } = default!;

        [JsonProperty("startTime")]
        public int StartTime { get; set; } = default!;

        [JsonProperty("expireTime")]
        public int ExpireTime { get; set; } = default!;

        [JsonProperty("campaignId")]
        public int CampaignId { get; set; } = default!;

        [JsonProperty("jointOperationIds")]
        public List<int> JointOperationIds { get; set; } = default!;
    } 

} 

