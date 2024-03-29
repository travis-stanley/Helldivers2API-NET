using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helldivers2API.Data.Models.Interfaces;
using Helldivers2API.Web;

namespace Helldivers2API.Data.Models.Extensions
{

    /// <summary>
    /// Extensions for pulling data from the web api
    /// </summary>
    public static class PlanetExtensions
    {
        #region WarInfoApi

        /// <summary>
        /// The location this planet exists on the galatic map.
        /// </summary>
        /// <param name="planet"></param>
        /// <returns></returns>
        public static Position? Position(this IPlanet planet)
        {
            var warInfo = Web.Cache.WebCache.GetWarInfo().ConfigureAwait(false).GetAwaiter().GetResult();
            var planetInfo = warInfo.PlanetInfos.Where(w => w.Id == planet.Id).FirstOrDefault();
            return planetInfo?.Position;
        }

        /// <summary>
        /// Max health of the planet.
        /// </summary>
        /// <param name="planet"></param>
        /// <returns></returns>
        public static int? MaxHealth(this IPlanet planet)
        {
            // if the planet is the target of a PlanetEvent, return those stats..
            // the api doesn't appear to update PlanetInfo with MaxHealth when the planet is target of an event
            var warStatus = Web.Cache.WebCache.GetWarStatus().ConfigureAwait(false).GetAwaiter().GetResult();
            var planetEvent = warStatus.PlanetEvents.Where(w => w.PlanetId == planet.Id).FirstOrDefault();
            if (planetEvent != null)
                return planetEvent.MaxHealth;

            var warInfo = Web.Cache.WebCache.GetWarInfo().ConfigureAwait(false).GetAwaiter().GetResult();
            var planetInfo = warInfo.PlanetInfos.Where(w => w.Id == planet.Id).FirstOrDefault();
            return planetInfo?.MaxHealth;
        }

        /// <summary>
        /// The faction that origionally controlled this planet.
        /// </summary>
        /// <param name="planet"></param>
        /// <returns></returns>
        public static IFaction? InitialOwner(this IPlanet planet)
        {
            var warInfo = Web.Cache.WebCache.GetWarInfo().ConfigureAwait(false).GetAwaiter().GetResult();
            var planetInfo = warInfo.PlanetInfos.Where(w => w.Id == planet.Id).FirstOrDefault();
            if (planetInfo != null) return Data.Cache.DataCache<IFaction>.Get(planetInfo.InitialOwner);
            return null;
        }

        /// <summary>
        /// List of planets with supply lines from this planet.
        /// </summary>
        /// <param name="planet"></param>
        /// <returns></returns>
        public static IPlanet?[] SupplyLinesTo(this IPlanet planet)
        {
            var warInfo = Web.Cache.WebCache.GetWarInfo().ConfigureAwait(false).GetAwaiter().GetResult();
            var planetInfo = warInfo.PlanetInfos.Where(w => w.Id == planet.Id).FirstOrDefault();
            if (planetInfo != null)
                if (planetInfo.Waypoints.Length > 0)
                    return Data.Cache.DataCache<IPlanet>.GetAll().Where(w => planetInfo.Waypoints.Contains(w.Id)).ToArray();
            return Array.Empty<IPlanet>();
        }

        /// <summary>
        /// List of planets with supply lines to this planet.
        /// </summary>
        /// <param name="planet"></param>
        /// <returns></returns>
        public static IPlanet?[] SupplyLinesFrom(this IPlanet planet)
        {
            var warInfo = Web.Cache.WebCache.GetWarInfo().ConfigureAwait(false).GetAwaiter().GetResult();
            var suppliers = warInfo.PlanetInfos.Where(w => w.Waypoints.Contains(planet.Id)).Select(s => s.Id);
            if (suppliers.Count() > 0)
                return Data.Cache.DataCache<IPlanet>.GetAll().Where(w => suppliers.Contains(w.Id)).ToArray();
            return Array.Empty<IPlanet>();
        }

        /// <summary>
        /// List of factions associated to this planet as their homeworld.
        /// </summary>
        /// <param name="planet"></param>
        /// <returns></returns>
        public static IFaction?[] HomeWorldFor(this IPlanet planet)
        {
            var warInfo = Web.Cache.WebCache.GetWarInfo().ConfigureAwait(false).GetAwaiter().GetResult();
            var homeworldFactions = warInfo.HomeWorlds.Where(w => w.PlanetIndices.Contains(planet.Id)).Select(s => s.Faction);
            if (homeworldFactions.Count() > 0)
                return Data.Cache.DataCache<IFaction>.GetAll().Where(w => homeworldFactions.Contains(w.Id)).ToArray();
            return Array.Empty<IFaction>();
        }

        #endregion


        #region WarStatusApi

        /// <summary>
        /// The faction that currently owns this planet.
        /// </summary>
        /// <param name="planet"></param>
        /// <returns></returns>
        public static IFaction? Owner(this IPlanet planet)
        {
            var warStatus = Web.Cache.WebCache.GetWarStatus().ConfigureAwait(false).GetAwaiter().GetResult();
            var owner = warStatus.PlanetStatuses.Where(w => w.Id == planet.Id).Select(s => s.OwnerId).FirstOrDefault();
            return Data.Cache.DataCache<IFaction>.Get(owner);
        }

        /// <summary>
        /// The current health of this planet.
        /// </summary>
        /// <param name="planet"></param>
        /// <returns></returns>
        public static int? Health(this IPlanet planet)
        {
            var warStatus = Web.Cache.WebCache.GetWarStatus().ConfigureAwait(false).GetAwaiter().GetResult();

            // if the planet is the target of a PlanetEvent, return those stats..
            // the api doesn't appear to update PlanetStatus when the planet is target of an event
            var planetEvent = warStatus.PlanetEvents.Where(w => w.PlanetId == planet.Id).FirstOrDefault();
            if (planetEvent != null)
                return planetEvent.Health;

            return warStatus.PlanetStatuses.Where(w => w.Id == planet.Id).Select(s => s.Health).FirstOrDefault();
        }

        /// <summary>
        /// The current regen per second of this planet.
        /// </summary>
        /// <param name="planet"></param>
        /// <returns></returns>
        public static double? RegenPerSecond(this IPlanet planet)
        {
            var warStatus = Web.Cache.WebCache.GetWarStatus().ConfigureAwait(false).GetAwaiter().GetResult();
            return warStatus.PlanetStatuses.Where(w => w.Id == planet.Id).Select(s => s.RegenPerSecond).FirstOrDefault();
        }

        /// <summary>
        /// The count of players on this planet.
        /// </summary>
        /// <param name="planet"></param>
        /// <returns></returns>
        public static int? PlayerCount(this IPlanet planet)
        {
            var warStatus = Web.Cache.WebCache.GetWarStatus().ConfigureAwait(false).GetAwaiter().GetResult();
            return warStatus.PlanetStatuses.Where(w => w.Id == planet.Id).Select(s => s.PlayerCount).FirstOrDefault();
        }


        ///// <summary>
        ///// List of planets being attacked by this planet.
        ///// </summary>
        ///// <param name="planet"></param>
        ///// <returns></returns>
        //public static IPlanet?[] Attacking(this IPlanet planet)
        //{
        //    var warStatus = Web.Cache.WebCache.GetWarStatus().ConfigureAwait(false).GetAwaiter().GetResult();
        //    var targetPlanets = warStatus.PlanetAttacks.Where(w => w.SourceId == planet.Id).Select(s => s.TargetId);
        //    if (targetPlanets.Count() > 0)
        //        return Data.Cache.DataCache<IPlanet>.GetAll().Where(w => targetPlanets.Contains(w.Id)).ToArray();
        //    return Array.Empty<IPlanet?>();
        //}

        ///// <summary>
        ///// List of planets attacking this planet.
        ///// </summary>
        ///// <param name="planet"></param>
        ///// <returns></returns>
        //public static IPlanet?[] DefendingAgainst(this IPlanet planet)
        //{
        //    var warStatus = Web.Cache.WebCache.GetWarStatus().ConfigureAwait(false).GetAwaiter().GetResult();
        //    var sourcePlanets = warStatus.PlanetAttacks.Where(w => w.TargetId == planet.Id).Select(s => s.SourceId);
        //    if (sourcePlanets.Count() > 0)
        //        return Data.Cache.DataCache<IPlanet>.GetAll().Where(w => sourcePlanets.Contains(w.Id)).ToArray();
        //    return Array.Empty<IPlanet?>();
        //}

        /// <summary>
        /// List of conflicts this planet participates in.
        /// </summary>
        /// <param name="planet"></param>
        /// <returns></returns>
        /// <remarks>
        /// Previously thought the source/target in the raw data implied which were attacking vs defending.
        /// This is not the case.  The source always appears to be friendly planets.
        /// </remarks>
        public static IPlanet?[] Conflicts(this IPlanet planet)
        {
            var warStatus = Web.Cache.WebCache.GetWarStatus().ConfigureAwait(false).GetAwaiter().GetResult();
            var targetPlanets = warStatus.PlanetAttacks.Where(w => w.SourceId == planet.Id || w.TargetId == planet.Id).SelectMany(s => new List<int> { s.TargetId, s.SourceId }).Distinct().ToArray();
            if (targetPlanets.Count() > 0)
                return Data.Cache.DataCache<IPlanet>.GetAll().Where(w => targetPlanets.Contains(w.Id) && w.Id != planet.Id).ToArray();
            return Array.Empty<IPlanet?>();
        }

        /// <summary>
        /// List of active campaigns on this planet.
        /// </summary>
        /// <param name="planet"></param>
        /// <returns></returns>
        public static Campaign?[] Campaigns(this IPlanet planet)
        {
            var warStatus = Web.Cache.WebCache.GetWarStatus().ConfigureAwait(false).GetAwaiter().GetResult();
            return warStatus.Campaigns.Where(w => w.PlanetId == planet.Id).ToArray();
        }

        public static PlanetState PlanetState(this IPlanet planet)
        {
            return new PlanetState(planet);
        }

        /// <summary>
        /// List of joint operations associated with this planet.
        /// </summary>
        /// <param name="planet"></param>
        /// <returns></returns>
        public static JointOperation?[] JointOperations(this IPlanet planet)
        {
            var warStatus = Web.Cache.WebCache.GetWarStatus().ConfigureAwait(false).GetAwaiter().GetResult();
            return warStatus.JointOperations.Where(w => w.PlanetId == planet.Id).ToArray();
        }

        /// <summary>
        /// List of active events associated with this planet.
        /// </summary>
        /// <param name="planet"></param>
        /// <returns></returns>
        public static PlanetEvent?[] PlanetEvents(this IPlanet planet)
        {
            var warStatus = Web.Cache.WebCache.GetWarStatus().ConfigureAwait(false).GetAwaiter().GetResult();
            return warStatus.PlanetEvents.Where(w => w.PlanetId == planet.Id).ToArray();
        }

        /// <summary>
        /// List of active global events associated with this planet.
        /// </summary>
        /// <param name="planet"></param>
        /// <returns></returns>
        public static GlobalEvent?[] GlobalEvents(this IPlanet planet)
        {
            var warStatus = Web.Cache.WebCache.GetWarStatus().ConfigureAwait(false).GetAwaiter().GetResult();
            return warStatus.GlobalEvents.Where(w => w.PlanetIds.Contains(planet.Id)).ToArray();
        }

        #endregion


        #region AssignmentApi

        /// <summary>
        /// Gets associated assignments.
        /// The assignment is usually the MAJOR ORDER but check IsMajorOrder on the Assignment.
        /// The Assignment Tasks always appear to include 1 in the list.. will only use last id for now.
        /// </summary>
        /// <param name="planet"></param>
        public static Assignment?[] GetAssignments(this IPlanet planet)
        {
            var assignments = Web.Cache.WebCache.GetAssignments().ConfigureAwait(false).GetAwaiter().GetResult();
            return assignments.Where(w => w.Tasks.Any(aa => aa.Values.Last() == planet.Id)).ToArray();
        }

        #endregion


    }

}
