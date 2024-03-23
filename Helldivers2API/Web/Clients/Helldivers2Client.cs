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
        private readonly IAPIConnector _apiConnector;

        public Helldivers2Client() : this(Helldivers2ClientConfig.CreateCustomHeaders()) { }

        public Helldivers2Client(Helldivers2ClientConfig config)
        {
            Ensure.ArgumentNotNull(config, nameof(config));

            _apiConnector = config.BuildAPIConnector();
            _apiConnector.ResponseReceived += (sender, response) =>
            {
                LastResponse = response;
            };

            Assignments = new AssignmentClient(_apiConnector);
            WarFeeds = new WarFeedClient(_apiConnector);
            WarInfo = new WarInfoClient(_apiConnector);
            WarStatus = new WarStatusClient(_apiConnector);
        }

        public IAssignmentClient Assignments { get; }
        public IWarFeedClient WarFeeds { get; }
        public IWarInfoClient WarInfo { get; }
        public IWarStatusClient WarStatus { get; }


        public IResponse? LastResponse { get; private set; }

    }
}
