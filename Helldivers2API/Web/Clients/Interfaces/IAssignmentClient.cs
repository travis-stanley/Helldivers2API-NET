using System.Threading;
using System.Threading.Tasks;
using Helldivers2API.Web;

namespace Helldivers2API.Web.Clients.Interfaces
{
    /// <summary>
    /// Get Assignments
    /// </summary>
    internal interface IAssignmentClient
    {
        /// <summary>
        /// Get assignments
        /// </summary>
        /// <param name="request">The request-model which contains required and optional parameters.</param>
        /// <param name="cancel">The cancellation-token to allow to cancel the request.</param>
        /// <returns></returns>
        Task<AssignmentResponse> Item(AssignmentRequest request, CancellationToken cancel = default);

        /// <summary>
        /// Get assignments
        /// </summary>
        /// <param name="warId">The season to get assignments from</param>
        /// <param name="cancel"></param>
        /// <returns></returns>
        Task<Assignment[]> Get(int warId, CancellationToken cancel = default);

    }
}
