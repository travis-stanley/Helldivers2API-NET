using System;
using System.Collections.Generic;
#if !NETSTANDARD2_0
using System.Runtime.CompilerServices;
#endif
using System.Threading;
using System.Threading.Tasks;
using Helldivers2API.Web.Clients.Interfaces;
using Helldivers2API.Web.Http;

namespace Helldivers2API.Web.Clients
{
    internal class Helldivers2Client : IHelldivers2Client
    {
        public readonly int warId;
        private readonly IAPIConnector _apiConnector;

        public Helldivers2Client(int warId) : this(warId, Helldivers2ClientConfig.CreateCustomHeaders()) { }

        public Helldivers2Client(int warId, Helldivers2ClientConfig config)
        {
            Ensure.ArgumentNotNull(warId, nameof(warId));
            Ensure.ArgumentNotNull(config, nameof(config));

            this.warId = warId;
            _apiConnector = config.BuildAPIConnector();
            _apiConnector.ResponseReceived += (sender, response) =>
            {
                LastResponse = response;
            };

            Assignments = new AssignmentClient(_apiConnector);
            WarFeeds = new WarFeedClient(_apiConnector);
            WarInfo = new WarInfoClient(_apiConnector);
            WarStatus = new WarStatusClient(_apiConnector);
            WarStats = new WarStatsClient(_apiConnector);
        }

        public IAssignmentClient Assignments { get; }
        public IWarFeedClient WarFeeds { get; }
        public IWarInfoClient WarInfo { get; }
        public IWarStatusClient WarStatus { get; }
        public IWarStatsClient WarStats { get; }

        public IResponse? LastResponse { get; private set; }

    }
}
