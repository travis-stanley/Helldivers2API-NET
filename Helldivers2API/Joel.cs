using Helldivers2API.Data.Models;
using Helldivers2API.Data.Models.Extensions;
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
    /// <remarks>
    /// Singleton, there can only be one Joel.
    /// </remarks>
    public sealed class Joel
    {
        private static readonly Lazy<Joel> lazy = new Lazy<Joel>(() => new Joel());
        public static Joel Instance { get { return lazy.Value; } }
        private Joel() {}
        
        public int WarId { get; internal set; } = default!;
        internal Helldivers2Client Client { get; set; } = default!;


        /// <summary>
        /// Set the current war id
        /// </summary>
        /// <param name="warId">The current war id</param>
        /// <returns></returns>
        public Joel SetWarId(int warId) 
        { 
            WarId = warId;
            Client = new Helldivers2Client(warId); 
            return this; 
        }

        /// <summary>
        /// Get information about all the known planets, their biomes, environmental conditions, sector, etc.
        /// Use extension methods to pull live war data from the Helldivers2 api (player counts, health, trade routes, etc)
        /// </summary>
        /// <returns></returns>
        public IPlanet[] GetPlanets() => Data.Cache.DataCache<IPlanet>.GetAll();

        /// <summary>
        /// Get planets which are homeworlds for a faction.
        /// </summary>
        /// <returns></returns>
        public IPlanet[] GetHomeWorlds() => GetPlanets().Where(w => w.HomeWorldFor().Length > 0).ToArray();

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
        /// Get information about the current assignments.  This is the MAJOR ORDER.
        /// </summary>
        /// <returns></returns>
        public Assignment[] GetAssignments()
        {
            if (Client == null) { throw new Exception("Must set the WarId before calling this method.  See SetWarId()."); }
            return Web.Cache.WebCache.GetAssignments().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the news feed.
        /// </summary>
        /// <returns></returns>
        public NewsFeed[] GetNewsFeed() 
        {
            if (Client == null) { throw new Exception("Must set the WarId before calling this method.  See SetWarId()."); }
            return Web.Cache.WebCache.GetWarFeeds().ConfigureAwait(false).GetAwaiter().GetResult(); 
        }

        /// <summary>
        /// Gets the status of the war
        /// </summary>
        /// <returns></returns>
        public WarStatus GetWarStatus() 
        {
            if (Client == null) { throw new Exception("Must set the WarId before calling this method.  See SetWarId()."); }
            return Web.Cache.WebCache.GetWarStatus().ConfigureAwait(false).GetAwaiter().GetResult();
        }
        

        /// <summary>
        /// Gets info on the war
        /// </summary>
        /// <returns></returns>
        public WarInfo GetWarInfo()
        {
            if (Client == null) { throw new Exception("Must set the WarId before calling this method.  See SetWarId()."); }
            return Web.Cache.WebCache.GetWarInfo().ConfigureAwait(false).GetAwaiter().GetResult();
        }


        /// <summary>
        /// Returns a dictionary of when each of the known api endpoints were last refreshed.
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, DateTime?> GetLastRefreshed() => Web.Cache.WebCache.LastRefreshed;
    }

}
