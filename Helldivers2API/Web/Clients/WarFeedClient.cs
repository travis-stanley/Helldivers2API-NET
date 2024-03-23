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

        public Task<WarFeedResponse> Item(WarFeedRequest request, CancellationToken cancel = default)
        {
            Ensure.ArgumentNotNull(request, nameof(request));

            return API.Get<WarFeedResponse>(URLs.WarFeed(request.WarId), request.BuildQueryParams(), cancel);
        }

        public Task<List<WarFeed>> Get(int warId, CancellationToken cancel = default)
        {
            Ensure.ArgumentNotNull(warId, nameof(warId));

            return API.Get<List<WarFeed>>(URLs.WarFeed(warId), cancel);
        }

    }
}
