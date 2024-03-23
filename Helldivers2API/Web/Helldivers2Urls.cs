using System;

namespace Helldivers2API.Web
{
    public static class Helldivers2Urls
    {
        static private readonly URIParameterFormatProvider _provider = new();

        public static readonly Uri API = new("https://api.live.prod.thehelldiversgame.com/api/");

        public static Uri Assignment(int warId) => EUri($"v2/Assignment/War/{warId}");
        public static Uri WarFeed(int warId) => EUri($"NewsFeed/{warId}?fromTimestamp=0");
        public static Uri WarInfo(int warId) => EUri($"WarSeason/{warId}/WarInfo");
        public static Uri WarStatus(int warId) => EUri($"WarSeason/{warId}/Status");
           

        private static Uri EUri(FormattableString path) => new(path.ToString(_provider), UriKind.Relative);
    }
}
