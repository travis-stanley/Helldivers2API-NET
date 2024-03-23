
using Helldivers2API.Web.Http;

namespace Helldivers2API.Web.Clients
{
    public abstract class APIClient
    {
        protected APIClient(IAPIConnector apiConnector)
        {
            Ensure.ArgumentNotNull(apiConnector, nameof(apiConnector));

            API = apiConnector;
        }

        protected IAPIConnector API { get; set; }
    }
}
