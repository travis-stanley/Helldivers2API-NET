using System.Threading;
using System.Threading.Tasks;
using Helldivers2API.Web.Clients.Interfaces;
using Helldivers2API.Web.Http;
using URLs = Helldivers2API.Web.Helldivers2Urls;

namespace Helldivers2API.Web.Clients
{
    internal class WarFeedClient : APIClient, IWarFeedClient
    {
        public WarFeedClient(IAPIConnector apiConnector) : base(apiConnector) { }

        public Task<WarFeedResponse> Item(WarFeedRequest request, int fromTimestamp, CancellationToken cancel = default)
        {
            Ensure.ArgumentNotNull(request, nameof(request));

            return API.Get<WarFeedResponse>(URLs.WarFeed(request.WarId, fromTimestamp), request.BuildQueryParams(), cancel);
        }

        public Task<WarFeed[]> Get(int warId, int fromTimestamp, CancellationToken cancel = default)
        {
            Ensure.ArgumentNotNull(warId, nameof(warId));

            return API.Get<WarFeed[]>(URLs.WarFeed(warId, fromTimestamp), cancel);
        }

    }
}
