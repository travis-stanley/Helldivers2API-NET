using System.Threading;
using System.Threading.Tasks;
using Helldivers2API.Web.Clients.Interfaces;
using Helldivers2API.Web;
using Helldivers2API.Web.Http;
using URLs = Helldivers2API.Web.Helldivers2Urls;

namespace Helldivers2API.Web.Clients
{
    internal class WarStatsClient : APIClient, IWarStatsClient
    {
        public WarStatsClient(IAPIConnector apiConnector) : base(apiConnector) { }

        public Task<WarStatsResponse> Item(WarStatsRequest request, CancellationToken cancel = default)
        {
            Ensure.ArgumentNotNull(request, nameof(request));

            return API.Get<WarStatsResponse>(URLs.WarStats(request.WarId), request.BuildQueryParams(), cancel);
        }

        public Task<WarStats> Get(int warId, CancellationToken cancel = default)
        {
            Ensure.ArgumentNotNull(warId, nameof(warId));

            return API.Get<WarStats>(URLs.WarStats(warId), cancel);
        }

    }
}
