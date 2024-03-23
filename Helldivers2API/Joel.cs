using Helldivers2API.Data.Models.Interfaces;
using Helldivers2API.Web.Clients;
using Helldivers2API.Web.Clients.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Helldivers2API
{
    /// <summary>
    /// Main entry point to retrieve data and use this library.
    /// </summary>
    public class Joel
    {
        private Helldivers2Client _client = default!;      

        /// <summary>
        /// Main entry point to retrieve data and use this library.
        /// </summary>
        /// <param name="warId">
        /// The current season or war Id.  The first season is/was 801.
        /// I have not found an endpoint that exposes this without prior knowledge of the id first.
        /// </param>
        public Joel(int warId)
        {            
            _client = new Helldivers2Client(warId);
        }

        /// <summary>
        /// Get information about all the known planets, their biomes, environmental conditions, sector, etc.
        /// Use extension methods to pull live war data from the Helldivers2 api (player counts, health, trade routes, etc)
        /// </summary>
        /// <returns></returns>
        public IPlanet[] GetPlanets() => Data.Cache.DataCache<IPlanet>.GetAll();

        /// <summary>
        /// Get information about all the known biomes.
        /// </summary>
        /// <returns></returns>
        public IBiome[] GetBiomes() => Data.Cache.DataCache<IBiome>.GetAll();

        /// <summary>
        /// Get information about all the known environmental conditions.
        /// </summary>
        /// <returns></returns>
        public IEnvironment[] GetEnvironment() => Data.Cache.DataCache<IEnvironment>.GetAll();

        /// <summary>
        /// Get information about all the known factions.
        /// </summary>
        /// <returns></returns>
        public IFaction[] GetFactions() => Data.Cache.DataCache<IFaction>.GetAll();


        /// <summary>
        /// Returns a dictionary of when each of the known api endpoints were last refreshed.
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, DateTime?> GetLastRefreshed() => Web.Cache.WebCache.LastRefreshed;


        /// <summary>
        /// Get information about the current assignments.  This is the MAJOR ORDER.
        /// </summary>
        /// <returns></returns>
        public Web.Assignment[] GetAssignments() => Web.Cache.WebCache.GetAssignments(_client).ConfigureAwait(false).GetAwaiter().GetResult();

        /// <summary>
        /// Gets the news feed.
        /// </summary>
        /// <returns></returns>
        public Web.WarFeed[] GetNewsFeed() => Web.Cache.WebCache.GetWarFeeds(_client).ConfigureAwait(false).GetAwaiter().GetResult();
    }

}
