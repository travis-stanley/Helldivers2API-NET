using System;
using System.Collections.Generic;

namespace Helldivers2API.Data.Models
{

    /// <summary>
    /// News from the galactic media
    /// </summary>
    public class NewsFeed
    {
        public long Id { get; set; } = default!;
        public long Published { get; set; } = default!;
        public int Type { get; set; } = default!;   // TODO: define what this is
        public string Message { get; set; } = default!;
        public string[] TagIds { get; set; } = default!;
    }

}
