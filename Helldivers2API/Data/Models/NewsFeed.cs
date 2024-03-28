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

        /// <summary>
        /// When it was published. Offset seconds from WarStatus.time (current time)
        /// </summary>
        public long Published { get; set; } = default!;

        /// <summary>
        /// Always 0, so far
        /// </summary>
        public int Type { get; set; } = default!;

        /// <summary>
        /// Message
        /// </summary>
        public string Message { get; set; } = default!;

        /// <summary>
        /// Unknown
        /// </summary>
        public string[] TagIds { get; set; } = default!;
    }

}
