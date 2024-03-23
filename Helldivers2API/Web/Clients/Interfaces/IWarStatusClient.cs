using System.Threading;
using System.Threading.Tasks;
using Helldivers2API.Web;

namespace Helldivers2API.Web.Clients.Interfaces
{
    /// <summary>
    /// Get war info 
    /// </summary>
    public interface IWarStatusClient
    {
        /// <summary>
        /// Get assignments
        /// </summary>
        /// <param name="request">The request-model which contains required and optional parameters.</param>
        /// <param name="cancel">The cancellation-token to allow to cancel the request.</param>
        /// <returns></returns>
        Task<WarStatusResponse> Item(WarStatusRequest request, CancellationToken cancel = default);

        /// <summary>
        /// Get assignments
        /// </summary>
        /// <param name="warId">The season to get assignments from</param>
        /// <param name="cancel"></param>
        /// <returns></returns>
        Task<WarStatus> Get(int warId, CancellationToken cancel = default);

    }
}
