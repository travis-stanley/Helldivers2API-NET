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
    public static class APIExtensions
    {
        public static Position? Position(this IPlanet planet)
        {
            var warInfo = Web.Cache.WebCache.GetWarInfo().ConfigureAwait(false).GetAwaiter().GetResult();
            var planetInfo = warInfo.PlanetInfos.Where(w => w.Id == planet.Id).FirstOrDefault();
            return planetInfo?.Position;
        }

        public static int? MaxHealth(this IPlanet planet)
        {
            var warInfo = Web.Cache.WebCache.GetWarInfo().ConfigureAwait(false).GetAwaiter().GetResult();
            var planetInfo = warInfo.PlanetInfos.Where(w => w.Id == planet.Id).FirstOrDefault();
            return planetInfo?.MaxHealth;
        }

        public static IFaction? InitialOwner(this IPlanet planet)
        {
            var warInfo = Web.Cache.WebCache.GetWarInfo().ConfigureAwait(false).GetAwaiter().GetResult();
            var planetInfo = warInfo.PlanetInfos.Where(w => w.Id == planet.Id).FirstOrDefault();
            if (planetInfo != null) return Data.Cache.DataCache<IFaction>.Get(planetInfo.InitialOwner);
            return null;
        }

        public static IPlanet?[] SupplyLinesTo(this IPlanet planet)
        {
            var warInfo = Web.Cache.WebCache.GetWarInfo().ConfigureAwait(false).GetAwaiter().GetResult();
            var planetInfo = warInfo.PlanetInfos.Where(w => w.Id == planet.Id).FirstOrDefault();
            if (planetInfo != null)
                if (planetInfo.Waypoints.Length > 0)
                    return Data.Cache.DataCache<IPlanet>.GetAll().Where(w => planetInfo.Waypoints.Contains(w.Id)).ToArray();
            return Array.Empty<IPlanet>();
        }

        public static IPlanet?[] SupplyLinesFrom(this IPlanet planet)
        {
            var warInfo = Web.Cache.WebCache.GetWarInfo().ConfigureAwait(false).GetAwaiter().GetResult();
            var suppliers = warInfo.PlanetInfos.Where(w => w.Waypoints.Contains(planet.Id)).Select(s => s.Id);
            if (suppliers.Count() > 0)
                return Data.Cache.DataCache<IPlanet>.GetAll().Where(w => suppliers.Contains(w.Id)).ToArray();
            return Array.Empty<IPlanet>();
        }

        public static IFaction?[] HomeWorldFor(this IPlanet planet)
        {
            var warInfo = Web.Cache.WebCache.GetWarInfo().ConfigureAwait(false).GetAwaiter().GetResult();
            var homeworldFactions = warInfo.HomeWorlds.Where(w => w.PlanetIndices.Contains(planet.Id)).Select(s => s.Faction);
            if (homeworldFactions.Count() > 0)
                return Data.Cache.DataCache<IFaction>.GetAll().Where(w => homeworldFactions.Contains(w.Id)).ToArray();
            return Array.Empty<IFaction>();
        }

        //public static Web.PlanetAttack[] PlanetAttacks(this IPlanet planet)
        //{
        //    //return APICache.GetPlanetAttacks(planet.Id);
        //    throw new NotImplementedException();
        //}

        //public static PlanetEvent[] PlanetEvents(this IPlanet planet)
        //{
        //    //return APICache.GetPlanetEvents(planet.Id);
        //    throw new NotImplementedException();
        //}

        //public static Web.PlanetStatus PlanetStatus(this IPlanet planet)
        //{
        //    //return APICache.GetPlanetStatus(planet.Id);
        //    throw new NotImplementedException();
        //}

    }
}
