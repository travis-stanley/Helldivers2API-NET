using Helldivers2API.Data.Models;
using Helldivers2API.Web.Clients;
using Helldivers2API.Web.Models.Response.Extensions;
using System.Diagnostics;

namespace Helldivers2API.Web.Cache
{

    /// <summary>
    /// web cache
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class WebCache
    {
        public static Dictionary<string, DateTime?> LastRefreshed { get => GetLastRefreshed(); }
        public static List<KeyValuePair<string, long>> WebApiCalls { get; internal set; } = new();

        private static Dictionary<long, Assignment[]> _assignments = default!;
        private static Dictionary<long, WarFeed[]> _warFeeds = default!;
        private static Dictionary<long, WarInfo> _warInfos = default!;
        private static Dictionary<long, WarStatus> _warStatuses = default!;
        private static Dictionary<long, WarStats> _warStats = default!;
        private static long tickInterval = 60 * 5 * 10000000L;

       
        // assignments
        public static async Task<Helldivers2API.Data.Models.Assignment[]> GetAssignments()
        {
            Joel.Instance.CheckClient();
            if (_assignments == default) _assignments = new Dictionary<long, Assignment[]>();

            if (_assignments.Count == 0)
                await RefreshAssignments().ConfigureAwait(false);
            else if (DateTime.Now.Ticks - _assignments.OrderBy(o => o.Key).Last().Key >= tickInterval)
                await RefreshAssignments().ConfigureAwait(false);

            return _assignments.OrderBy(o => o.Key).Last().Value.Select(s => s.GetDataModel()).ToArray();
        }
        private static async Task RefreshAssignments()
        {
            WebApiCalls.Add(new KeyValuePair<string, long>("Assignments", DateTime.Now.Ticks ));
            var assignments = await Joel.Instance.Client.Assignments.Get(Joel.Instance.WarId).ConfigureAwait(false);
            if (assignments != null)
                _assignments.Add(DateTime.Now.Ticks, assignments);

        }

        // war status
        public static async Task<Helldivers2API.Data.Models.WarStatus> GetWarStatus()
        {
            Joel.Instance.CheckClient();
            if (_warStatuses == default) _warStatuses = new Dictionary<long, WarStatus>();

            if (_warStatuses.Count == 0)
                await RefreshWarStatuses().ConfigureAwait(false);
            else if (DateTime.Now.Ticks - _warStatuses.OrderBy(o => o.Key).Last().Key >= tickInterval)
                await RefreshWarStatuses().ConfigureAwait(false);

            var last = _warStatuses.OrderBy(o => o.Key).Last();
            return last.Value.GetDataModel(last.Key);
        }
        private static async Task RefreshWarStatuses()
        {
            WebApiCalls.Add(new KeyValuePair<string, long>("WarStatus", DateTime.Now.Ticks));
            var warStatus = await Joel.Instance.Client.WarStatus.Get(Joel.Instance.WarId).ConfigureAwait(false);
            if (warStatus != null)
                _warStatuses.Add(DateTime.Now.Ticks, warStatus);

        }

        // news feed
        public static async Task<NewsFeed[]> GetWarFeeds()
        {
            Joel.Instance.CheckClient();
            if (_warFeeds == default) _warFeeds = new Dictionary<long, WarFeed[]>();
            
            // Only the first 10 results from the fromTimestamp are returned (oldest to new).
            // Using too early of a timestamp will result is not seeing the latest news.    
            // get warstatus time as a starting point, subtract a few days
            int fromTimestamp = 0;
            var warStatus = await GetWarStatus();
            if (warStatus != null)
                fromTimestamp = warStatus.Time - (int)new TimeSpan(3, 0, 0, 0).TotalSeconds;

            if (_warFeeds.Count == 0)
                await RefreshWarFeeds(fromTimestamp).ConfigureAwait(false);
            else if (DateTime.Now.Ticks - _warFeeds.OrderBy(o => o.Key).Last().Key >= tickInterval)
                await RefreshWarFeeds(fromTimestamp).ConfigureAwait(false);
            return _warFeeds.OrderBy(o => o.Key).Last().Value.Select(s => s.GetDataModel()).OrderByDescending(o => o.Published).ToArray();
        }
        private static async Task RefreshWarFeeds(int fromTimestamp)
        {               
            WebApiCalls.Add(new KeyValuePair<string, long>("NewsFeed", DateTime.Now.Ticks));
            var warFeeds = await Joel.Instance.Client.WarFeeds.Get(Joel.Instance.WarId, fromTimestamp).ConfigureAwait(false);
            if (warFeeds != null)
                _warFeeds.Add(DateTime.Now.Ticks, warFeeds);
        }

        // war info
        public static async Task<Helldivers2API.Data.Models.WarInfo> GetWarInfo()
        {
            Joel.Instance.CheckClient();
            if (_warInfos == default) _warInfos = new Dictionary<long, WarInfo>();

            if (_warInfos.Count == 0)
                await RefreshWarInfos().ConfigureAwait(false);
            else if (DateTime.Now.Ticks - _warInfos.OrderBy(o => o.Key).Last().Key >= tickInterval)
                await RefreshWarInfos().ConfigureAwait(false);
            return _warInfos.OrderBy(o => o.Key).Last().Value.GetDataModel();
        }
        private static async Task RefreshWarInfos()
        {
            WebApiCalls.Add(new KeyValuePair<string, long>("WarInfo", DateTime.Now.Ticks));
            var warInfo = await Joel.Instance.Client.WarInfo.Get(Joel.Instance.WarId).ConfigureAwait(false);
            if (warInfo != null)
                _warInfos.Add(DateTime.Now.Ticks, warInfo);
        }

        // war stats
        public static async Task<Helldivers2API.Data.Models.WarStats> GetWarStats()
        {
            Joel.Instance.CheckClient();
            if (_warStats == default) _warStats = new Dictionary<long, WarStats>();

            if (_warStats.Count == 0)
                await RefreshWarStats().ConfigureAwait(false);
            else if (DateTime.Now.Ticks - _warStats.OrderBy(o => o.Key).Last().Key >= tickInterval)
                await RefreshWarStats().ConfigureAwait(false);
            return _warStats.OrderBy(o => o.Key).Last().Value.GetDataModel();
        }
        private static async Task RefreshWarStats()
        {
            WebApiCalls.Add(new KeyValuePair<string, long>("WarStats", DateTime.Now.Ticks));
            var warStats = await Joel.Instance.Client.WarStats.Get(Joel.Instance.WarId).ConfigureAwait(false);
            if (warStats != null)
                _warStats.Add(DateTime.Now.Ticks, warStats);
        }

        private static Dictionary<string, DateTime?> GetLastRefreshed()
        {
            var lastRefreshed = new Dictionary<string, DateTime?>();

            DateTime? assignmentRef = null;
            if (_assignments != default) assignmentRef = _assignments.Count() == 0 ? null : new DateTime(_assignments.OrderBy(o => o.Key).Last().Key);
            DateTime? warfeedRef = null;
            if (_warFeeds != default) warfeedRef = _warFeeds.Count() == 0 ? null : new DateTime(_warFeeds.OrderBy(o => o.Key).Last().Key);
            DateTime? warinfoRef = null;
            if (_warInfos != default) warinfoRef = _warInfos.Count() == 0 ? null : new DateTime(_warInfos.OrderBy(o => o.Key).Last().Key);
            DateTime? warstatusRef = null;
            if (_warStatuses != default) warstatusRef = _warStatuses.Count() == 0 ? null : new DateTime(_warStatuses.OrderBy(o => o.Key).Last().Key);

            lastRefreshed.Add("Assignments", assignmentRef);
            lastRefreshed.Add("WarInfo", warinfoRef);
            lastRefreshed.Add("WarStatus", warstatusRef);
            lastRefreshed.Add("NewsFeed", warfeedRef);

            return lastRefreshed;
        }
    }

}
