using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helldivers2API.Web
{
    public class Position
    {
        [JsonProperty("x")]
        public double X { get; set; } = default!;

        [JsonProperty("y")]
        public double Y { get; set; } = default!;
    }
}
