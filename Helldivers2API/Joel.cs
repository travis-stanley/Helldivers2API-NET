using Helldivers2API.Data.Models;
using Helldivers2API.Data.Models.Extensions;
using Helldivers2API.Data.Models.Interfaces;
using Helldivers2API.Web.Clients;
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
        private static readonly Lazy<Joel> lazy = new(() => new Joel());

        /// <summary>
        /// Singleton instance
        /// </summary>
        public static Joel Instance { get { return lazy.Value; } }
        private Joel() { }

        /// <summary>
        /// The target war id
        /// </summary>
        public int WarId { get; internal set; } = default!;
        internal Helldivers2Client Client { get; set; } = default!;

        /// <summary>
        /// True if the client has been set to a war id
        /// </summary>
        public bool IsClientReady { get => Client != default; }


        /// <summary>
        /// Set the current war id.
        /// As of 1.1.4, the war id will automatically be set to the current season id.
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
        /// Get all the known biomes.
        /// </summary>
        /// <returns></returns>
        public IBiome[] GetBiomes() => Data.Cache.DataCache<IBiome>.GetAll();

        /// <summary>
        /// Get all the known environmental conditions.
        /// </summary>
        /// <returns></returns>
        public IEnvironment[] GetEnvironments() => Data.Cache.DataCache<IEnvironment>.GetAll();

        /// <summary>
        /// Get all the known factions.
        /// </summary>
        /// <returns></returns>
        public IFaction[] GetFactions() => Data.Cache.DataCache<IFaction>.GetAll();

        /// <summary>
        /// Get planets which are homeworlds for a faction.
        /// </summary>
        /// <returns></returns>
        public IPlanet[] GetHomeWorlds() => GetPlanets().Where(w => w.HomeWorldFor().Length > 0).ToArray();


        /// <summary>
        /// Get information about all the known planets, their biomes, environmental conditions, sector, etc.
        /// Use the extension methods to pull live war data from the Helldivers2 api (player counts, health, trade routes, etc)
        /// </summary>
        /// <returns></returns>
        public IPlanet[] GetPlanets() => Data.Cache.DataCache<IPlanet>.GetAll();

        /// <summary>
        /// Get planets in the current campaign.
        /// These are the playable planets, unless they've been 100% liberated.
        /// </summary>
        /// <returns></returns>
        public IPlanet[] GetCampaignPlanets() => Data.Cache.DataCache<IPlanet>.GetAll().Where(w => w.Campaigns().Length > 0).ToArray();

        /// <summary>
        /// Get planets with planet events (focuses player efforts).
        /// These are the planets with a focus on the galactic map. 
        /// E.g. "DEFEND with a countdown"
        /// </summary>
        /// <returns></returns>
        public IPlanet[] GetPlanetEventPlanets() => Data.Cache.DataCache<IPlanet>.GetAll().Where(w => w.PlanetEvents().Length > 0).ToArray();

        /// <summary>
        /// Get planets with global events (open access to weapons, stratagem, etc).
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// effectIds might be a weapon id, not sure but see title to know what it is
        /// </remarks>
        public IPlanet[] GetGlobalEventPlanets() => Data.Cache.DataCache<IPlanet>.GetAll().Where(w => w.GlobalEvents().Length > 0).ToArray();

        /// <summary>
        /// Get planets associated with an assignment.
        /// This is where the MAJOR ORDER appears.
        /// </summary>
        /// <returns></returns>
        /// <remarks>
        /// Returns all planets with any assignments.  
        /// If more than the major order begin to appear in assignments, 
        /// the type may need to be used to filter result specific to major orders.
        /// Assignment.IsMajorOrder will return true if the type == 4.
        /// </remarks>
        public IPlanet[] GetAssignmentPlanets() => Data.Cache.DataCache<IPlanet>.GetAll().Where(w => w.GetAssignments().Length > 0).ToArray();




        /// <summary>
        /// Gets the latest news.
        /// </summary>
        /// <returns></returns>
        public NewsFeed[] GetLatestNews()
        {
            return Web.Cache.WebCache.GetWarFeeds().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Get all the assignments.  
        /// To get associated planets, use GetAssignmentPlanets().
        /// </summary>
        /// <returns></returns>
        public Assignment[] GetAssignments()
        {
            return Web.Cache.WebCache.GetAssignments().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets the status of the war.  
        /// Use Planet extension methods to get planet associated data.
        /// </summary>
        /// <returns></returns>
        public WarStatus GetWarStatus()
        {
            return Web.Cache.WebCache.GetWarStatus().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets info on the war
        /// Use Planet extension methods to get planet associated data.
        /// </summary>
        /// <returns></returns>
        public WarInfo GetWarInfo()
        {
            return Web.Cache.WebCache.GetWarInfo().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Gets stats on the war
        /// Use Planet extension methods to get planet associated data.
        /// </summary>
        /// <returns></returns>
        public WarStats GetWarStats()
        {
            return Web.Cache.WebCache.GetWarStats().ConfigureAwait(false).GetAwaiter().GetResult();
        }

        /// <summary>
        /// Returns a dictionary of when each of the known api endpoints were last refreshed.
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, DateTime?> GetLastRefreshed() => Web.Cache.WebCache.LastRefreshed;

        /// <summary>
        /// Returns a list of calls to the api endpoints and when.
        /// </summary>
        /// <returns></returns>
        public List<KeyValuePair<string, long>> GetWebApiCalls() => Web.Cache.WebCache.WebApiCalls;


        internal void CheckClient() 
        {
            if (!IsClientReady)
            {
                var lastKnownWarId = 801;
                SetWarId(lastKnownWarId);                

                // check for newer warid
                var currentWarId = Web.Cache.WebCache.GetCurrentWarId().ConfigureAwait(false).GetAwaiter().GetResult();
                if (currentWarId != null)
                    SetWarId(currentWarId.Value);
            }
        }
    }
}
