using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Helldivers2API.Web.Http;

namespace Helldivers2API.Web.Clients.Interfaces
{
    public interface IHelldivers2Client
    {

        /// <summary>
        /// Assignments, aka Major Order
        /// </summary>
        /// <value></value>
        IAssignmentClient Assignments { get; }


        /// <summary>
        /// WarFeeds, aka News Feed
        /// </summary>
        /// <value></value>
        IWarFeedClient WarFeeds { get; }

        /// <summary>
        /// WarInfo
        /// </summary>
        /// <value></value>
        IWarInfoClient WarInfo { get; }

        /// <summary>
        /// WarStatus
        /// </summary>
        /// <value></value>
        IWarStatusClient WarStatus { get; }


        /// <summary>
        /// Returns the last response received by an API call.
        /// </summary>
        /// <value></value>
        IResponse? LastResponse { get; }

    }
}
