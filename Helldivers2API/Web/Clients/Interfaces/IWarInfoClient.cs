using System.Threading;
using System.Threading.Tasks;
using Helldivers2API.Web;

namespace Helldivers2API.Web.Clients.Interfaces
{
    /// <summary>
    /// Get war info 
    /// </summary>
    internal interface IWarInfoClient
    {
        /// <summary>
        /// Get info
        /// </summary>
        /// <param name="request">The request-model which contains required and optional parameters.</param>
        /// <param name="cancel">The cancellation-token to allow to cancel the request.</param>
        /// <returns></returns>
        Task<WarInfoResponse> Item(WarInfoRequest request, CancellationToken cancel = default);

        /// <summary>
        /// Get info
        /// </summary>
        /// <param name="warId">The season to get assignments from</param>
        /// <param name="cancel"></param>
        /// <returns></returns>
        Task<WarInfo> Get(int warId, CancellationToken cancel = default);

        /// <summary>
        /// Get current war id
        /// </summary>
        /// <param name="cancel"></param>
        /// <returns></returns>
        Task<WarId> GetCurrentWarId(CancellationToken cancel = default);

    }
}
