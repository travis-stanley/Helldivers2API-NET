using System;

namespace Helldivers2API.Web
{

    /// <summary>
    /// API endpoints for the game
    /// </summary>
    public static class Helldivers2Urls
    {
        static private readonly URIParameterFormatProvider _provider = new();

        /// <summary>
        /// Base url
        /// </summary>
        public static readonly Uri API = new("https://api.live.prod.thehelldiversgame.com/api/");

        /// <summary>
        /// Assignments api
        /// </summary>
        /// <param name="warId"></param>
        /// <returns></returns>
        public static Uri Assignment(int warId) => EUri($"v2/Assignment/War/{warId}");

        /// <summary>
        /// News feed api
        /// </summary>
        /// <param name="warId"></param>
        /// <param name="fromTimestamp"></param>
        /// <returns></returns>
        public static Uri WarFeed(int warId, int fromTimestamp) => EUri($"NewsFeed/{warId}?fromTimestamp={fromTimestamp}");

        /// <summary>
        /// Info api
        /// </summary>
        /// <param name="warId"></param>
        /// <returns></returns>
        public static Uri WarInfo(int warId) => EUri($"WarSeason/{warId}/WarInfo");

        /// <summary>
        /// Status api
        /// </summary>
        /// <param name="warId"></param>
        /// <returns></returns>
        public static Uri WarStatus(int warId) => EUri($"WarSeason/{warId}/Status");

        /// <summary>
        /// Stats api
        /// </summary>
        /// <param name="warId"></param>
        /// <returns></returns>
        public static Uri WarStats(int warId) => EUri($"Stats/war/{warId}/summary");
           

        private static Uri EUri(FormattableString path) => new(path.ToString(_provider), UriKind.Relative);
    }
}
