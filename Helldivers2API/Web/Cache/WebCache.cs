using Helldivers2API.Data.Models;
using Helldivers2API.Web.Clients;
using Helldivers2API.Web.Models.Response.Extensions;

namespace Helldivers2API.Web.Cache
{

    /// <summary>
    /// web cache
    /// </summary>
    /// <typeparam name="T"></typeparam>
    internal class WebCache
    {
        public static Dictionary<string, DateTime?> LastRefreshed { get => GetLastRefreshed(); }

        private static Dictionary<long, Assignment[]> _assignments = default!;
        private static Dictionary<long, WarFeed[]> _warFeeds = default!;
        private static Dictionary<long, WarInfo> _warInfos = default!;
        private static Dictionary<long, WarStatus> _warStatuses = default!;
        private static long tickInterval = 60 * 10000000;

        private static Dictionary<string, long> _lastRefreshed = new Dictionary<string, long>();

        // assignments
        public static async Task<Helldivers2API.Data.Models.Assignment[]> GetAssignments(Helldivers2Client hdClient)
        {
            if (_assignments == default) _assignments = new Dictionary<long, Assignment[]>();

            if (_assignments.Count == 0)
                await RefreshAssignments(hdClient).ConfigureAwait(false);
            else if (DateTime.Now.Ticks - _assignments.OrderBy(o => o.Key).Last().Key >= tickInterval)
                await RefreshAssignments(hdClient).ConfigureAwait(false);

            return _assignments.OrderBy(o => o.Key).Last().Value.Select(s => s.GetDataModel()).ToArray();
        }
        private static async Task RefreshAssignments(Helldivers2Client hdClient)
        {
            var assignments = await hdClient.Assignments.Get(hdClient.warId).ConfigureAwait(false);
            if (assignments != null)
            {
                _assignments.Add(DateTime.Now.Ticks, assignments);
                if (!_lastRefreshed.ContainsKey("Assignments"))
                    _lastRefreshed.Add("Assignments", 0);
                _lastRefreshed["Assignments"] = DateTime.Now.Ticks;
            }
                
        }

        // war status
        public static async Task<Helldivers2API.Data.Models.WarStatus> GetWarStatus(Helldivers2Client hdClient)
        {
            if (_warStatuses == default) _warStatuses = new Dictionary<long, WarStatus>();

            if (_warStatuses.Count == 0)
                await RefreshWarStatuses(hdClient).ConfigureAwait(false);
            else if (DateTime.Now.Ticks - _warStatuses.OrderBy(o => o.Key).Last().Key >= tickInterval)
                await RefreshWarStatuses(hdClient).ConfigureAwait(false);
            return _warStatuses.OrderBy(o => o.Key).Last().Value.GetDataModel();
        }
        private static async Task RefreshWarStatuses(Helldivers2Client hdClient)
        {
            var warStatus = await hdClient.WarStatus.Get(hdClient.warId).ConfigureAwait(false);
            if (warStatus != null)
            {
                _warStatuses.Add(DateTime.Now.Ticks, warStatus);
                if (!_lastRefreshed.ContainsKey("WarStatus"))
                    _lastRefreshed.Add("WarStatus", 0);
                _lastRefreshed["WarStatus"] = DateTime.Now.Ticks;
            }
                
        }

        // news feed
        public static async Task<NewsFeed[]> GetWarFeeds(Helldivers2Client hdClient)
        {
            if (_warFeeds == default) _warFeeds = new Dictionary<long, WarFeed[]>();

            if (_warFeeds.Count == 0)
                await RefreshWarFeeds(hdClient).ConfigureAwait(false);
            else if (DateTime.Now.Ticks - _warFeeds.OrderBy(o => o.Key).Last().Key >= tickInterval)
                await RefreshWarFeeds(hdClient).ConfigureAwait(false);
            return _warFeeds.OrderBy(o => o.Key).Last().Value.Select(s => s.GetDataModel()).ToArray();
        }
        private static async Task RefreshWarFeeds(Helldivers2Client hdClient)
        {
            var warFeeds = await hdClient.WarFeeds.Get(hdClient.warId).ConfigureAwait(false);
            if (warFeeds != null)
            {
                _warFeeds.Add(DateTime.Now.Ticks, warFeeds);
                if (!_lastRefreshed.ContainsKey("WarFeed"))
                    _lastRefreshed.Add("WarFeed", 0);
                _lastRefreshed["WarFeed"] = DateTime.Now.Ticks;
            }                
        }

        // war info
        public static async Task<Helldivers2API.Data.Models.WarInfo> GetWarInfo(Helldivers2Client hdClient)
        {
            if (_warInfos == default) _warInfos = new Dictionary<long, WarInfo>();

            if (_warInfos.Count == 0)
                await RefreshWarInfos(hdClient).ConfigureAwait(false);
            else if (DateTime.Now.Ticks - _warInfos.OrderBy(o => o.Key).Last().Key >= tickInterval)
                await RefreshWarInfos(hdClient).ConfigureAwait(false);
            return _warInfos.OrderBy(o => o.Key).Last().Value.GetDataModel();
        }
        private static async Task RefreshWarInfos(Helldivers2Client hdClient)
        {
            var warInfo = await hdClient.WarInfo.Get(hdClient.warId).ConfigureAwait(false);
            if (warInfo != null)
            {
                _warInfos.Add(DateTime.Now.Ticks, warInfo);
                if (!_lastRefreshed.ContainsKey("WarInfo"))
                    _lastRefreshed.Add("WarInfo", 0);
                _lastRefreshed["WarInfo"] = DateTime.Now.Ticks;
            }                
        }

        private static Dictionary<string, DateTime?> GetLastRefreshed()
        {
            var lastRefreshed = new Dictionary<string, DateTime?>();

            if (_lastRefreshed.ContainsKey("Assignment"))
                lastRefreshed.Add("Assignment", new DateTime(_lastRefreshed["Assignment"]));
            if (_lastRefreshed.ContainsKey("WarStatus"))
                lastRefreshed.Add("WarStatus", new DateTime(_lastRefreshed["WarStatus"]));
            if (_lastRefreshed.ContainsKey("WarFeed"))
                lastRefreshed.Add("WarFeed", new DateTime(_lastRefreshed["WarFeed"]));
            if (_lastRefreshed.ContainsKey("WarInfo"))
                lastRefreshed.Add("WarInfo", new DateTime(_lastRefreshed["WarInfo"]));

            return lastRefreshed;
        }
    }

}
