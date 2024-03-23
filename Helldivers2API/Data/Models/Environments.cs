using System;
using System.Collections.Generic;
using System.Diagnostics;
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

    public class ExtremeCold : IEnvironment
    {
        const string Name = "ExtremeCold";
        const string Description = "Icy temperatures reduce rate of fire and delay heat buildup in weapons";

        string IEnvironment.Name => Name;
        string IEnvironment.Description => Description;

        int IDataCache.Id => throw new NotImplementedException();
        string IDataCache.Name => Name;

    }
    public class ThickFog : IEnvironment
    {
        const string Name = "ThickFog";
        const string Description = "";

        string IEnvironment.Name => Name;
        string IEnvironment.Description => Description;
        int IDataCache.Id => throw new NotImplementedException();
        string IDataCache.Name => Name;
    }
    public class Rainstorms : IEnvironment
    {
        const string Name = "Rainstorms";
        const string Description = "Torrential rainstorms reduce visibility";

        string IEnvironment.Name => Name;
        string IEnvironment.Description => Description;
        int IDataCache.Id => throw new NotImplementedException();
        string IDataCache.Name => Name;
    }
    public class IntenseHeat : IEnvironment
    {
        const string Name = "IntenseHeat";
        const string Description = "High temperatures increase stamina drain and speed up heat buildup in weapons";

        string IEnvironment.Name => Name;
        string IEnvironment.Description => Description;
        int IDataCache.Id => throw new NotImplementedException();
        string IDataCache.Name => Name;
    }
    public class Tremors : IEnvironment
    {
        const string Name = "Tremors";
        const string Description = "Frequent earthquakes stun players and enemies alike";

        string IEnvironment.Name => Name;
        string IEnvironment.Description => Description;
        int IDataCache.Id => throw new NotImplementedException();
        string IDataCache.Name => Name;
    }
    public class Blizzards : IEnvironment
    {
        const string Name = "Blizzards";
        const string Description = "";

        string IEnvironment.Name => Name;
        string IEnvironment.Description => Description;
        int IDataCache.Id => throw new NotImplementedException();
        string IDataCache.Name => Name;
    }
    public class MeteorStorms : IEnvironment
    {
        const string Name = "MeteorStorms";
        const string Description = "Meteors impact the surface causing massive damage";

        string IEnvironment.Name => Name;
        string IEnvironment.Description => Description;
        int IDataCache.Id => throw new NotImplementedException();
        string IDataCache.Name => Name;
    }
    public class Sandstorms : IEnvironment
    {
        const string Name = "Sandstorms";
        const string Description = "";

        string IEnvironment.Name => Name;
        string IEnvironment.Description => Description;
        int IDataCache.Id => throw new NotImplementedException();
        string IDataCache.Name => Name;
    }
    public class IonStorms : IEnvironment
    {
        const string Name = "IonStorms";
        const string Description = "Ion storms intermittently disable Stratagems";

        string IEnvironment.Name => Name;
        string IEnvironment.Description => Description;
        int IDataCache.Id => throw new NotImplementedException();
        string IDataCache.Name => Name;
    }
    public class AcidStorms : IEnvironment
    {
        const string Name = "AcidStorms";
        const string Description = "Violent acid storms reduce visibility";

        string IEnvironment.Name => Name;
        string IEnvironment.Description => Description;
        int IDataCache.Id => throw new NotImplementedException();
        string IDataCache.Name => Name;
    }
    public class VolcanicActivity : IEnvironment
    {
        const string Name = "VolcanicActivity";
        const string Description = "Volcanoes throw burning rocks around this planet";

        string IEnvironment.Name => Name;
        string IEnvironment.Description => Description;
        int IDataCache.Id => throw new NotImplementedException();
        string IDataCache.Name => Name;
    }
    public class FireTornadoes : IEnvironment
    {
        const string Name = "FireTornadoes";
        const string Description = "Planet is ravaged by deadly fire tornadoes";

        string IEnvironment.Name => Name;
        string IEnvironment.Description => Description;
        int IDataCache.Id => throw new NotImplementedException();
        string IDataCache.Name => Name;
    }
}
