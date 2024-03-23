using Helldivers2API.Data.Models.Interfaces;
using Helldivers2API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helldivers2API.Web;
using Helldivers2API.Web.Clients;

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

        public static async Task<Assignment[]> GetAssignments(Helldivers2Client hdClient)
        {
            if (_assignments == default) _assignments = new Dictionary<long, Assignment[]>();

            if (_assignments.Count == 0)
                await RefreshAssignments(hdClient).ConfigureAwait(false);
            else if (DateTime.Now.Ticks - _assignments.OrderBy(o => o.Key).Last().Key >= tickInterval)
                await RefreshAssignments(hdClient).ConfigureAwait(false);
            return _assignments.OrderBy(o => o.Key).Last().Value;
        }
        private static async Task RefreshAssignments(Helldivers2Client hdClient)
        {
            var assignments = await hdClient.Assignments.Get(hdClient.warId).ConfigureAwait(false);
            if (assignments != null)
                _assignments.Add(DateTime.Now.Ticks, assignments);
        }

        public static async Task<WarFeed[]> GetWarFeeds(Helldivers2Client hdClient)
        {
            if (_warFeeds == default) _warFeeds = new Dictionary<long, WarFeed[]>();

            if (_warFeeds.Count == 0)
                await RefreshWarFeeds(hdClient).ConfigureAwait(false);
            else if (DateTime.Now.Ticks - _warFeeds.OrderBy(o => o.Key).Last().Key >= tickInterval)
                await RefreshWarFeeds(hdClient).ConfigureAwait(false);
            return _warFeeds.OrderBy(o => o.Key).Last().Value;
        }
        private static async Task RefreshWarFeeds(Helldivers2Client hdClient)
        {
            var warFeeds = await hdClient.WarFeeds.Get(hdClient.warId).ConfigureAwait(false);
            if (warFeeds != null)
                _warFeeds.Add(DateTime.Now.Ticks, warFeeds);
        }

        public static async Task<WarInfo> GetWarInfo(Helldivers2Client hdClient)
        {
            if (_warInfos == default) _warInfos = new Dictionary<long, WarInfo>();

            if (_warInfos.Count == 0)
                await RefreshWarInfos(hdClient).ConfigureAwait(false);
            else if (DateTime.Now.Ticks - _warInfos.OrderBy(o => o.Key).Last().Key >= tickInterval)
                await RefreshWarInfos(hdClient).ConfigureAwait(false);
            return _warInfos.OrderBy(o => o.Key).Last().Value;
        }
        private static async Task RefreshWarInfos(Helldivers2Client hdClient)
        {
            var warInfo = await hdClient.WarInfo.Get(hdClient.warId).ConfigureAwait(false);
            if (warInfo != null)
                _warInfos.Add(DateTime.Now.Ticks, warInfo);
        }

        public static async Task<WarStatus> GetWarStatus(Helldivers2Client hdClient)
        {
            if (_warStatuses == default) _warStatuses = new Dictionary<long, WarStatus>();

            if (_warStatuses.Count == 0)
                await RefreshWarStatuses(hdClient).ConfigureAwait(false);
            else if (DateTime.Now.Ticks - _warStatuses.OrderBy(o => o.Key).Last().Key >= tickInterval)
                await RefreshWarStatuses(hdClient).ConfigureAwait(false);
            return _warStatuses.OrderBy(o => o.Key).Last().Value;
        }
        private static async Task RefreshWarStatuses(Helldivers2Client hdClient)
        {
            var warStatus = await hdClient.WarStatus.Get(hdClient.warId).ConfigureAwait(false);
            if (warStatus != null)
                _warStatuses.Add(DateTime.Now.Ticks, warStatus);
        }

        private static Dictionary<string, DateTime?> GetLastRefreshed()
        {
            var lastRefreshed = new Dictionary<string, DateTime?>();
            //DateTime? assignmentRef = null;
            //if (_assignments != default) assignmentRef = _assignments.Count() == 0 ? null : new DateTime(_assignments.OrderBy(o => o.Key).Last().Key);
            //DateTime? warfeedRef = null;
            //if (_warFeeds != default) warfeedRef = _warFeeds.Count() == 0 ? null : new DateTime(_warFeeds.OrderBy(o => o.Key).Last().Key);
            //DateTime? warinfoRef = null;
            //if (_warInfos != default) warinfoRef = _warInfos.Count() == 0 ? null : new DateTime(_warInfos.OrderBy(o => o.Key).Last().Key);
            //DateTime? warstatusRef = null;
            //if (_warStatuses != default) warstatusRef = _warStatuses.Count() == 0 ? null : new DateTime(_warStatuses.OrderBy(o => o.Key).Last().Key);

            //LastRefreshed.Add("Assignments", assignmentRef);            
            //LastRefreshed.Add("WarInfo", warinfoRef);
            //LastRefreshed.Add("WarStatus", warstatusRef);
            //LastRefreshed.Add("NewsFeed", warfeedRef);

            return LastRefreshed;
        }
    }

}
