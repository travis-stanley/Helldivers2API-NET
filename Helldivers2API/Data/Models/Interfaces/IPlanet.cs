using Helldivers2API.Data.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helldivers2API.Data.Models.Interfaces
{
    public interface IPlanet : IDataCache
    {
        /// <summary>
        /// The index of the planet from the api.
        /// </summary>
        public new int Id { get; }

        /// <summary>
        /// The name of the planet, pulled from the game.
        /// </summary>
        /// <remarks>Data is static and could change with a game update.</remarks>
        public new string Name { get; }

        /// <summary>
        /// The biome of the planet, pulled from the game.
        /// </summary>
        /// <remarks>Data is static and could change with a game update.</remarks>
        public IBiome? Biome { get; }

        /// <summary>
        /// The environment conditions of the planet, pulled from the game.
        /// </summary>
        /// <remarks>Data is static and could change with a game update.</remarks>
        public IEnvironment?[] Environments { get; }

        /// <summary>
        /// The sector this planet resides in, pulled from the game.
        /// </summary>
        /// <remarks>Data is static and could change with a game update.</remarks>
        public string SectorName { get; }
    }
}
