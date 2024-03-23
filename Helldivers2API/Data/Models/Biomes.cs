using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;
using Helldivers2API.Data.Cache;
using Helldivers2API.Data.Models.Interfaces;

namespace Helldivers2API.Data.Models
{

    internal class RainForest : IBiome
    {
        const string Name = "RainForest";
        const string Description = "The strange subversion of photosynthesis that sustains the oddly-hued flora that flourishes on this planet remains an intriguing mystery to Super Earth's greatest exo-biologists.";

        string IBiome.Name => Name;        
        string IBiome.Description => Description;
        int IDataCache.Id => throw new NotImplementedException();
        string IDataCache.Name => Name;
    }
    internal class Ethereal : IBiome
    {
        const string Name = "Ethereal";
        const string Description = "This world teems with ethereal, boundless, and peculiar plant life that spreads silent and uninterrupted across its entire surface.";

        string IBiome.Name => Name;
        string IBiome.Description => Description;
        int IDataCache.Id => throw new NotImplementedException();
        string IDataCache.Name => Name;
    }
    internal class Jungle : IBiome
    {
        const string Name = "Jungle";
        const string Description = "Abundant with life, this wet planet is covered in deep oceans, thick forests, and tall grasses.";

        string IBiome.Name => Name;
        string IBiome.Description => Description;
        int IDataCache.Id => throw new NotImplementedException();
        string IDataCache.Name => Name;
    }
    internal class Moon : IBiome
    {
        const string Name = "Moon";
        const string Description = "A rocky, lonely moon with extremely valuable mineral deposits underneath the surface.";

        string IBiome.Name => Name;
        string IBiome.Description => Description;
        int IDataCache.Id => throw new NotImplementedException();
        string IDataCache.Name => Name;
    }
    internal class Desert : IBiome
    {
        const string Name = "Desert";
        const string Description = "A desert planet prone to unpredictable and dangerous,sand twisters.";

        string IBiome.Name => Name;
        string IBiome.Description => Description;
        int IDataCache.Id => throw new NotImplementedException();
        string IDataCache.Name => Name;
    }
    internal class Winter : IBiome
    {
        const string Name = "Winter";
        const string Description = "Submerged in eternal winter, this world's frosty peaks glimmer in the light of its too-distant star.";

        string IBiome.Name => Name;
        string IBiome.Description => Description;
        int IDataCache.Id => throw new NotImplementedException();
        string IDataCache.Name => Name;
    }
    internal class Highlands : IBiome
    {
        const string Name = "Highlands";
        const string Description = "Rocky outcroppings punctuate fields of tall grass in a planet dominated by misty highland terrain.";

        string IBiome.Name => Name;
        string IBiome.Description => Description;
        int IDataCache.Id => throw new NotImplementedException();
        string IDataCache.Name => Name;
    }
    internal class IceMoss : IBiome
    {
        const string Name = "IceMoss";
        const string Description = "Ice and moss-covered rock can be found across most of the surface of this planet.";

        string IBiome.Name => Name;
        string IBiome.Description => Description;
        int IDataCache.Id => throw new NotImplementedException();
        string IDataCache.Name => Name;
    }
    internal class IceMossSpecial : IBiome
    {
        const string Name = "IceMossSpecial";
        const string Description = "Ice and moss-covered rock can be found across most of the surface of this planet.";

        string IBiome.Name => Name;
        string IBiome.Description => Description;
        int IDataCache.Id => throw new NotImplementedException();
        string IDataCache.Name => Name;
    }
    internal class Tundra : IBiome
    {
        const string Name = "Tundra";
        const string Description = "A perenially chilly climate has allowed short, colourful shrubs to flourish across this planet's surface.";

        string IBiome.Name => Name;
        string IBiome.Description => Description;
        int IDataCache.Id => throw new NotImplementedException();
        string IDataCache.Name => Name;
    }
    internal class Swamp : IBiome
    {
        const string Name = "Swamp";
        const string Description = "The lifeless grey of this planet is interrupted only by the violet flowers that grow from strange, parasitic outcroppings.";

        string IBiome.Name => Name;
        string IBiome.Description => Description;
        int IDataCache.Id => throw new NotImplementedException();
        string IDataCache.Name => Name;
    }
    internal class Desolate : IBiome
    {
        const string Name = "Desolate";
        const string Description = "Scorching temperatures, high winds, and low precipitation cause a near-constant cycle of fires to sweep this planet, punctuated by short bursts of lush rebirth between infernos.";

        string IBiome.Name => Name;
        string IBiome.Description => Description;
        int IDataCache.Id => throw new NotImplementedException();
        string IDataCache.Name => Name;
    }
    internal class CrimsonMoor : IBiome
    {
        const string Name = "CrimsonMoor";
        const string Description = "A crimson algae has propagated wildly across this entire planet, coating its rocky hills with a constant red that masks the spilt blood of the heroes who defend it from tyranny.";

        string IBiome.Name => Name;
        string IBiome.Description => Description;
        int IDataCache.Id => throw new NotImplementedException();
        string IDataCache.Name => Name;
    }
    internal class Canyon : IBiome
    {
        const string Name = "Canyon";
        const string Description = "This arid, rocky biome covering this world has driven the evolution of exceptionally efficient water usage in its various organisms.";

        string IBiome.Name => Name;
        string IBiome.Description => Description;
        int IDataCache.Id => throw new NotImplementedException();
        string IDataCache.Name => Name;
    }

}
