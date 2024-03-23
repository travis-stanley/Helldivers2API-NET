using System.Threading;
using System.Threading.Tasks;
using Helldivers2API.Web.Clients.Interfaces;
using Helldivers2API.Web.Http;
using URLs = Helldivers2API.Web.Helldivers2Urls;

namespace Helldivers2API.Web.Clients
{
    public class AssignmentClient : APIClient, IAssignmentClient
    {
        public AssignmentClient(IAPIConnector apiConnector) : base(apiConnector) { }

        public Task<AssignmentResponse> Item(AssignmentRequest request, CancellationToken cancel = default)
        {
            Ensure.ArgumentNotNull(request, nameof(request));

            return API.Get<AssignmentResponse>(URLs.Assignment(request.WarId), request.BuildQueryParams(), cancel);
        }

        public Task<List<Assignment>> Get(int warId, CancellationToken cancel = default)
        {
            Ensure.ArgumentNotNull(warId, nameof(warId));

            return API.Get<List<Assignment>>(URLs.Assignment(warId), cancel);
        }

    }
}
