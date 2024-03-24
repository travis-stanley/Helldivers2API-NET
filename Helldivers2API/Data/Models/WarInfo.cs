using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Helldivers2API.Data.Models.Interfaces;
using Helldivers2API.Data.Cache;
using Helldivers2API.Web;
using Newtonsoft.Json;

namespace Helldivers2API.Data.Models
{

    /// <summary>
    /// Contains information about the current war
    /// </summary>
    public class WarInfo
    {
        public int WarId { get; set; } = default!;
        public int StartDate { get; set; } = default!;
        public int EndDate { get; set; } = default!;
        public PlanetInfo[] PlanetInfos { get; set; } = default!;
        public HomeWorld[] HomeWorlds { get; set; } = default!;

        //public string[] CapitalInfos { get; set; } = default!;
        //public int[] PlanetPermanentEffects { get; set; } = default!;
    }

    /// <summary>
    /// Contains information about the planets
    /// </summary>
    public class PlanetInfo
    {
        public int Id { get; set; } = default!;
        public Position Position { get; set; } = default!;
        public int[] Waypoints { get; set; } = default!;
        public int MaxHealth { get; set; } = default!;
        public bool Disabled { get; set; } = default!;
        public int InitialOwner { get; set; } = default!;
    }

    /// <summary>
    /// Galatic coordinate
    /// </summary>
    public class Position
    {
        public double X { get; set; } = default!;
        public double Y { get; set; } = default!;
    }

    /// <summary>
    /// Homeworld planets and owning faction
    /// </summary>
    public class HomeWorld
    {
        public int Faction { get; set; } = default!;
        public int[] PlanetIndices { get; set; } = default!;

    }
}
