using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Helldivers2API.Web
{

    /// <summary>
    /// WarId model 
    /// </summary>
    internal class WarId
    {
        [JsonProperty("id")]
        public int Id { get; set; } = default!;

    }

}

