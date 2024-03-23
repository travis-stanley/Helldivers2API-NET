using System.Threading;
using System.Threading.Tasks;
using Helldivers2API.Web.Clients.Interfaces;
using Helldivers2API.Web;
using Helldivers2API.Web.Http;
using URLs = Helldivers2API.Web.Helldivers2Urls;

namespace Helldivers2API.Web.Clients
{
    internal class WarStatusClient : APIClient, IWarStatusClient
    {
        public WarStatusClient(IAPIConnector apiConnector) : base(apiConnector) { }

        public Task<WarStatusResponse> Item(WarStatusRequest request, CancellationToken cancel = default)
        {
            Ensure.ArgumentNotNull(request, nameof(request));

            return API.Get<WarStatusResponse>(URLs.WarStatus(request.WarId), request.BuildQueryParams(), cancel);
        }

        public Task<WarStatus> Get(int warId, CancellationToken cancel = default)
        {
            Ensure.ArgumentNotNull(warId, nameof(warId));

            return API.Get<WarStatus>(URLs.WarStatus(warId), cancel);
        }

    }
}
