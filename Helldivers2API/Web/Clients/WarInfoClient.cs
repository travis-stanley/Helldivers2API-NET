using System.Threading;
using System.Threading.Tasks;
using Helldivers2API.Web.Clients.Interfaces;
using Helldivers2API.Web;
using Helldivers2API.Web.Http;
using URLs = Helldivers2API.Web.Helldivers2Urls;

namespace Helldivers2API.Web.Clients
{
    internal class WarInfoClient : APIClient, IWarInfoClient
    {
        public WarInfoClient(IAPIConnector apiConnector) : base(apiConnector) { }

        public Task<WarInfoResponse> Item(WarInfoRequest request, CancellationToken cancel = default)
        {
            Ensure.ArgumentNotNull(request, nameof(request));

            return API.Get<WarInfoResponse>(URLs.WarInfo(request.WarId), request.BuildQueryParams(), cancel);
        }

        public Task<WarInfo> Get(int warId, CancellationToken cancel = default)
        {
            Ensure.ArgumentNotNull(warId, nameof(warId));

            return API.Get<WarInfo>(URLs.WarInfo(warId), cancel);
        }

    }
}
