
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

        /// <summary>
        /// Internal use only.  Get this data through the IPlanet extension methods.
        /// </summary>
        internal PlanetInfo[] PlanetInfos { get; set; } = default!;

        /// <summary>
        /// Internal use only.  Get this data through the IPlanet extension methods.
        /// </summary>
        internal HomeWorld[] HomeWorlds { get; set; } = default!;

        /// <summary>
        /// Always empty, so far
        /// </summary>
        internal string[] CapitalInfos { get; set; } = default!;

        /// <summary>
        /// Always empty, so far
        /// </summary>
        internal int[] PlanetPermanentEffects { get; set; } = default!;
    }

    /// <summary>
    /// Contains information about the planets
    /// </summary>
    internal class PlanetInfo
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
    internal class HomeWorld
    {
        public int Faction { get; set; } = default!;
        public int[] PlanetIndices { get; set; } = default!;

    }
}
