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

namespace Helldivers2API.Data.Models
{

    public class SuperEarth : IPlanet, IDataCache
    {
        const int Id = 0;
        const string Name = "Super Earth";
        const string SectorName = "Sol";
        const string BiomeName = "null";
        const string EnvironmentNames = "";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class KlenDahthII : IPlanet, IDataCache
    {
        const int Id = 1;
        const string Name = "Klen Dahth II";
        const string SectorName = "Altus";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat, Sandstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class PathfinderV : IPlanet, IDataCache
    {
        const int Id = 2;
        const string Name = "Pathfinder V";
        const string SectorName = "Altus";
        const string BiomeName = "Highlands";
        const string EnvironmentNames = "ThickFog, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class WidowsHarbor : IPlanet, IDataCache
    {
        const int Id = 3;
        const string Name = "Widow's Harbor";
        const string SectorName = "Altus";
        const string BiomeName = "null";
        const string EnvironmentNames = "ExtremeCold, MeteorStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class NewHaven : IPlanet, IDataCache
    {
        const int Id = 4;
        const string Name = "New Haven";
        const string SectorName = "Altus";
        const string BiomeName = "RainForest";
        const string EnvironmentNames = "IonStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class PilenV : IPlanet, IDataCache
    {
        const int Id = 5;
        const string Name = "Pilen V";
        const string SectorName = "Altus";
        const string BiomeName = "Desert";
        const string EnvironmentNames = "IntenseHeat, Tremors";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class HydrofallPrime : IPlanet, IDataCache
    {
        const int Id = 6;
        const string Name = "Hydrofall Prime";
        const string SectorName = "Barnard";
        const string BiomeName = "Canyon";
        const string EnvironmentNames = "Tremors";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class ZeaRugosia : IPlanet, IDataCache
    {
        const int Id = 7;
        const string Name = "Zea Rugosia";
        const string SectorName = "Ferris";
        const string BiomeName = "Desert";
        const string EnvironmentNames = "IntenseHeat, Tremors";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Darrowsport : IPlanet, IDataCache
    {
        const int Id = 8;
        const string Name = "Darrowsport";
        const string SectorName = "Barnard";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat, AcidStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class FornskogurII : IPlanet, IDataCache
    {
        const int Id = 9;
        const string Name = "Fornskogur II";
        const string SectorName = "Barnard";
        const string BiomeName = "Jungle";
        const string EnvironmentNames = "VolcanicActivity, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Midasburg : IPlanet, IDataCache
    {
        const int Id = 10;
        const string Name = "Midasburg";
        const string SectorName = "Barnard";
        const string BiomeName = "null";
        const string EnvironmentNames = "";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class CerberusIIIc : IPlanet, IDataCache
    {
        const int Id = 11;
        const string Name = "Cerberus IIIc";
        const string SectorName = "Cancri";
        const string BiomeName = "Desert";
        const string EnvironmentNames = "IntenseHeat, Tremors";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class ProsperityFalls : IPlanet, IDataCache
    {
        const int Id = 12;
        const string Name = "Prosperity Falls";
        const string SectorName = "Cancri";
        const string BiomeName = "RainForest";
        const string EnvironmentNames = "IonStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class OkulVI : IPlanet, IDataCache
    {
        const int Id = 13;
        const string Name = "Okul VI";
        const string SectorName = "Gothmar";
        const string BiomeName = "Winter";
        const string EnvironmentNames = "ExtremeCold, Blizzards";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class MartyrsBay : IPlanet, IDataCache
    {
        const int Id = 14;
        const string Name = "Martyr's Bay";
        const string SectorName = "Cantolus";
        const string BiomeName = "IceMoss";
        const string EnvironmentNames = "ExtremeCold";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class FreedomPeak : IPlanet, IDataCache
    {
        const int Id = 15;
        const string Name = "Freedom Peak";
        const string SectorName = "Cantolus";
        const string BiomeName = "CrimsonMoor";
        const string EnvironmentNames = "IonStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class FortUnion : IPlanet, IDataCache
    {
        const int Id = 16;
        const string Name = "Fort Union";
        const string SectorName = "Orion";
        const string BiomeName = "Highlands";
        const string EnvironmentNames = "ThickFog, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Kelvinor : IPlanet, IDataCache
    {
        const int Id = 17;
        const string Name = "Kelvinor";
        const string SectorName = "Cantolus";
        const string BiomeName = "Winter";
        const string EnvironmentNames = "ExtremeCold, Blizzards";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Wraith : IPlanet, IDataCache
    {
        const int Id = 18;
        const string Name = "Wraith";
        const string SectorName = "Idun";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat, AcidStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Igla : IPlanet, IDataCache
    {
        const int Id = 19;
        const string Name = "Igla";
        const string SectorName = "Kelvin";
        const string BiomeName = "IceMoss";
        const string EnvironmentNames = "ExtremeCold";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class NewKiruna : IPlanet, IDataCache
    {
        const int Id = 20;
        const string Name = "New Kiruna";
        const string SectorName = "Kelvin";
        const string BiomeName = "Winter";
        const string EnvironmentNames = "ExtremeCold, Blizzards";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class FortJustice : IPlanet, IDataCache
    {
        const int Id = 21;
        const string Name = "Fort Justice";
        const string SectorName = "Kelvin";
        const string BiomeName = "null";
        const string EnvironmentNames = "";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class ZegemaParadise : IPlanet, IDataCache
    {
        const int Id = 22;
        const string Name = "Zegema Paradise";
        const string SectorName = "Kelvin";
        const string BiomeName = "Jungle";
        const string EnvironmentNames = "VolcanicActivity, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Providence : IPlanet, IDataCache
    {
        const int Id = 23;
        const string Name = "Providence";
        const string SectorName = "Iptus";
        const string BiomeName = "CrimsonMoor";
        const string EnvironmentNames = "IonStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Primordia : IPlanet, IDataCache
    {
        const int Id = 24;
        const string Name = "Primordia";
        const string SectorName = "Iptus";
        const string BiomeName = "Jungle";
        const string EnvironmentNames = "VolcanicActivity, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Sulfura : IPlanet, IDataCache
    {
        const int Id = 25;
        const string Name = "Sulfura";
        const string SectorName = "Celeste";
        const string BiomeName = "Ethereal";
        const string EnvironmentNames = "";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class NublariaI : IPlanet, IDataCache
    {
        const int Id = 26;
        const string Name = "Nublaria I";
        const string SectorName = "Celeste";
        const string BiomeName = "Jungle";
        const string EnvironmentNames = "VolcanicActivity, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Krakatwo : IPlanet, IDataCache
    {
        const int Id = 27;
        const string Name = "Krakatwo";
        const string SectorName = "Celeste";
        const string BiomeName = "IceMoss";
        const string EnvironmentNames = "ExtremeCold";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Volterra : IPlanet, IDataCache
    {
        const int Id = 28;
        const string Name = "Volterra";
        const string SectorName = "Korpus";
        const string BiomeName = "Highlands";
        const string EnvironmentNames = "ThickFog, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Crucible : IPlanet, IDataCache
    {
        const int Id = 29;
        const string Name = "Crucible";
        const string SectorName = "Korpus";
        const string BiomeName = "null";
        const string EnvironmentNames = "";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Veil : IPlanet, IDataCache
    {
        const int Id = 30;
        const string Name = "Veil";
        const string SectorName = "Barnard";
        const string BiomeName = "Swamp";
        const string EnvironmentNames = "ThickFog";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class MarreIV : IPlanet, IDataCache
    {
        const int Id = 31;
        const string Name = "Marre IV";
        const string SectorName = "Barnard";
        const string BiomeName = "Desolate";
        const string EnvironmentNames = "IntenseHeat, FireTornadoes";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class FortSanctuary : IPlanet, IDataCache
    {
        const int Id = 32;
        const string Name = "Fort Sanctuary";
        const string SectorName = "Cancri";
        const string BiomeName = "CrimsonMoor";
        const string EnvironmentNames = "IonStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class SeyshelBeach : IPlanet, IDataCache
    {
        const int Id = 33;
        const string Name = "Seyshel Beach";
        const string SectorName = "Cancri";
        const string BiomeName = "Ethereal";
        const string EnvironmentNames = "";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Hellmire : IPlanet, IDataCache
    {
        const int Id = 34;
        const string Name = "Hellmire";
        const string SectorName = "Mirin";
        const string BiomeName = "Desolate";
        const string EnvironmentNames = "IntenseHeat, FireTornadoes";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Effluvia : IPlanet, IDataCache
    {
        const int Id = 35;
        const string Name = "Effluvia";
        const string SectorName = "Cancri";
        const string BiomeName = "Canyon";
        const string EnvironmentNames = "Tremors";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Solghast : IPlanet, IDataCache
    {
        const int Id = 36;
        const string Name = "Solghast";
        const string SectorName = "Gothmar";
        const string BiomeName = "Swamp";
        const string EnvironmentNames = "ThickFog";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Diluvia : IPlanet, IDataCache
    {
        const int Id = 37;
        const string Name = "Diluvia";
        const string SectorName = "Gothmar";
        const string BiomeName = "null";
        const string EnvironmentNames = "";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class ViridiaPrime : IPlanet, IDataCache
    {
        const int Id = 38;
        const string Name = "Viridia Prime";
        const string SectorName = "Cantolus";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat, Sandstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Obari : IPlanet, IDataCache
    {
        const int Id = 39;
        const string Name = "Obari";
        const string SectorName = "Cantolus";
        const string BiomeName = "Highlands";
        const string EnvironmentNames = "ThickFog, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Myradesh : IPlanet, IDataCache
    {
        const int Id = 40;
        const string Name = "Myradesh";
        const string SectorName = "Idun";
        const string BiomeName = "Desert";
        const string EnvironmentNames = "IntenseHeat, Tremors";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Atrama : IPlanet, IDataCache
    {
        const int Id = 41;
        const string Name = "Atrama";
        const string SectorName = "Idun";
        const string BiomeName = "RainForest";
        const string EnvironmentNames = "IonStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Emeria : IPlanet, IDataCache
    {
        const int Id = 42;
        const string Name = "Emeria";
        const string SectorName = "Kelvin";
        const string BiomeName = "Canyon";
        const string EnvironmentNames = "Tremors";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Barabos : IPlanet, IDataCache
    {
        const int Id = 43;
        const string Name = "Barabos";
        const string SectorName = "Marspira";
        const string BiomeName = "IceMoss";
        const string EnvironmentNames = "ExtremeCold";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Fenmire : IPlanet, IDataCache
    {
        const int Id = 44;
        const string Name = "Fenmire";
        const string SectorName = "Marspira";
        const string BiomeName = "Highlands";
        const string EnvironmentNames = "ThickFog, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Mastia : IPlanet, IDataCache
    {
        const int Id = 45;
        const string Name = "Mastia";
        const string SectorName = "Marspira";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat, Sandstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Shallus : IPlanet, IDataCache
    {
        const int Id = 46;
        const string Name = "Shallus";
        const string SectorName = "Talus";
        const string BiomeName = "Ethereal";
        const string EnvironmentNames = "";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Krakabos : IPlanet, IDataCache
    {
        const int Id = 47;
        const string Name = "Krakabos";
        const string SectorName = "Iptus";
        const string BiomeName = "IceMoss";
        const string EnvironmentNames = "ExtremeCold";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Iridica : IPlanet, IDataCache
    {
        const int Id = 48;
        const string Name = "Iridica";
        const string SectorName = "Iptus";
        const string BiomeName = "Ethereal";
        const string EnvironmentNames = "";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Azterra : IPlanet, IDataCache
    {
        const int Id = 49;
        const string Name = "Azterra";
        const string SectorName = "Orion";
        const string BiomeName = "Canyon";
        const string EnvironmentNames = "Tremors";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class AzurSecundus : IPlanet, IDataCache
    {
        const int Id = 50;
        const string Name = "Azur Secundus";
        const string SectorName = "Sten";
        const string BiomeName = "Desert";
        const string EnvironmentNames = "IntenseHeat, Tremors";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Ivis : IPlanet, IDataCache
    {
        const int Id = 51;
        const string Name = "Ivis";
        const string SectorName = "Celeste";
        const string BiomeName = "Winter";
        const string EnvironmentNames = "ExtremeCold, Blizzards";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Slif : IPlanet, IDataCache
    {
        const int Id = 52;
        const string Name = "Slif";
        const string SectorName = "Celeste";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat, AcidStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Caramoor : IPlanet, IDataCache
    {
        const int Id = 53;
        const string Name = "Caramoor";
        const string SectorName = "Korpus";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat, Sandstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Kharst : IPlanet, IDataCache
    {
        const int Id = 54;
        const string Name = "Kharst";
        const string SectorName = "Gallux";
        const string BiomeName = "CrimsonMoor";
        const string EnvironmentNames = "IonStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Eukoria : IPlanet, IDataCache
    {
        const int Id = 55;
        const string Name = "Eukoria";
        const string SectorName = "Morgon";
        const string BiomeName = "IceMoss";
        const string EnvironmentNames = "ExtremeCold";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Myrium : IPlanet, IDataCache
    {
        const int Id = 56;
        const string Name = "Myrium";
        const string SectorName = "Morgon";
        const string BiomeName = "Canyon";
        const string EnvironmentNames = "Tremors";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class KerthSecundus : IPlanet, IDataCache
    {
        const int Id = 57;
        const string Name = "Kerth Secundus";
        const string SectorName = "Rictus";
        const string BiomeName = "null";
        const string EnvironmentNames = "";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Parsh : IPlanet, IDataCache
    {
        const int Id = 58;
        const string Name = "Parsh";
        const string SectorName = "Rictus";
        const string BiomeName = "Winter";
        const string EnvironmentNames = "ExtremeCold, Blizzards";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Reaf : IPlanet, IDataCache
    {
        const int Id = 59;
        const string Name = "Reaf";
        const string SectorName = "Saleria";
        const string BiomeName = "Highlands";
        const string EnvironmentNames = "ThickFog, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Irulta : IPlanet, IDataCache
    {
        const int Id = 60;
        const string Name = "Irulta";
        const string SectorName = "Saleria";
        const string BiomeName = "Jungle";
        const string EnvironmentNames = "VolcanicActivity, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Emorath : IPlanet, IDataCache
    {
        const int Id = 61;
        const string Name = "Emorath";
        const string SectorName = "Meridian";
        const string BiomeName = "null";
        const string EnvironmentNames = "";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class IldunaPrime : IPlanet, IDataCache
    {
        const int Id = 62;
        const string Name = "Ilduna Prime";
        const string SectorName = "Meridian";
        const string BiomeName = "null";
        const string EnvironmentNames = "";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Maw : IPlanet, IDataCache
    {
        const int Id = 63;
        const string Name = "Maw";
        const string SectorName = "Idun";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Meridia : IPlanet, IDataCache
    {
        const int Id = 64;
        const string Name = "Meridia";
        const string SectorName = "Umlaut";
        const string BiomeName = "Jungle";
        const string EnvironmentNames = "VolcanicActivity, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Borea : IPlanet, IDataCache
    {
        const int Id = 65;
        const string Name = "Borea";
        const string SectorName = "Sagan";
        const string BiomeName = "Winter";
        const string EnvironmentNames = "ExtremeCold, Blizzards";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Curia : IPlanet, IDataCache
    {
        const int Id = 66;
        const string Name = "Curia";
        const string SectorName = "Marspira";
        const string BiomeName = "null";
        const string EnvironmentNames = "ExtremeCold, MeteorStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Tarsh : IPlanet, IDataCache
    {
        const int Id = 67;
        const string Name = "Tarsh";
        const string SectorName = "Marspira";
        const string BiomeName = "Winter";
        const string EnvironmentNames = "ExtremeCold, Blizzards";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Shelt : IPlanet, IDataCache
    {
        const int Id = 68;
        const string Name = "Shelt";
        const string SectorName = "Talus";
        const string BiomeName = "null";
        const string EnvironmentNames = "";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Imber : IPlanet, IDataCache
    {
        const int Id = 69;
        const string Name = "Imber";
        const string SectorName = "Talus";
        const string BiomeName = "Desolate";
        const string EnvironmentNames = "IntenseHeat, FireTornadoes";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Blistica : IPlanet, IDataCache
    {
        const int Id = 70;
        const string Name = "Blistica";
        const string SectorName = "Gellert";
        const string BiomeName = "Desolate";
        const string EnvironmentNames = "IntenseHeat, FireTornadoes";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Ratch : IPlanet, IDataCache
    {
        const int Id = 71;
        const string Name = "Ratch";
        const string SectorName = "Iptus";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat, Sandstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Julheim : IPlanet, IDataCache
    {
        const int Id = 72;
        const string Name = "Julheim";
        const string SectorName = "Nanos";
        const string BiomeName = "Winter";
        const string EnvironmentNames = "ExtremeCold, Blizzards";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Valgaard : IPlanet, IDataCache
    {
        const int Id = 73;
        const string Name = "Valgaard";
        const string SectorName = "Iptus";
        const string BiomeName = "CrimsonMoor";
        const string EnvironmentNames = "IonStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Arkturus : IPlanet, IDataCache
    {
        const int Id = 74;
        const string Name = "Arkturus";
        const string SectorName = "Arturion";
        const string BiomeName = "Winter";
        const string EnvironmentNames = "ExtremeCold, Blizzards";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Esker : IPlanet, IDataCache
    {
        const int Id = 75;
        const string Name = "Esker";
        const string SectorName = "Falstaff";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat, AcidStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Terrek : IPlanet, IDataCache
    {
        const int Id = 76;
        const string Name = "Terrek";
        const string SectorName = "Orion";
        const string BiomeName = "null";
        const string EnvironmentNames = "ExtremeCold, MeteorStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Cirrus : IPlanet, IDataCache
    {
        const int Id = 77;
        const string Name = "Cirrus";
        const string SectorName = "Orion";
        const string BiomeName = "Swamp";
        const string EnvironmentNames = "ThickFog";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Crimsica : IPlanet, IDataCache
    {
        const int Id = 78;
        const string Name = "Crimsica";
        const string SectorName = "Draco";
        const string BiomeName = "CrimsonMoor";
        const string EnvironmentNames = "IonStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Heeth : IPlanet, IDataCache
    {
        const int Id = 79;
        const string Name = "Heeth";
        const string SectorName = "Orion";
        const string BiomeName = "Winter";
        const string EnvironmentNames = "ExtremeCold, Blizzards";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Veld : IPlanet, IDataCache
    {
        const int Id = 80;
        const string Name = "Veld";
        const string SectorName = "Orion";
        const string BiomeName = "RainForest";
        const string EnvironmentNames = "IonStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class AltaV : IPlanet, IDataCache
    {
        const int Id = 81;
        const string Name = "Alta V";
        const string SectorName = "Korpus";
        const string BiomeName = "Jungle";
        const string EnvironmentNames = "VolcanicActivity, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class UrsicaXI : IPlanet, IDataCache
    {
        const int Id = 82;
        const string Name = "Ursica XI";
        const string SectorName = "Borgus";
        const string BiomeName = "null";
        const string EnvironmentNames = "";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Inari : IPlanet, IDataCache
    {
        const int Id = 83;
        const string Name = "Inari";
        const string SectorName = "Korpus";
        const string BiomeName = "IceMoss";
        const string EnvironmentNames = "ExtremeCold";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Skaash : IPlanet, IDataCache
    {
        const int Id = 84;
        const string Name = "Skaash";
        const string SectorName = "Ursa";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat, AcidStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Moradesh : IPlanet, IDataCache
    {
        const int Id = 85;
        const string Name = "Moradesh";
        const string SectorName = "Celeste";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat, Sandstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Rasp : IPlanet, IDataCache
    {
        const int Id = 86;
        const string Name = "Rasp";
        const string SectorName = "Gallux";
        const string BiomeName = "null";
        const string EnvironmentNames = "ExtremeCold, MeteorStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Bashyr : IPlanet, IDataCache
    {
        const int Id = 87;
        const string Name = "Bashyr";
        const string SectorName = "Gallux";
        const string BiomeName = "Swamp";
        const string EnvironmentNames = "ThickFog";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Regnus : IPlanet, IDataCache
    {
        const int Id = 88;
        const string Name = "Regnus";
        const string SectorName = "Morgon";
        const string BiomeName = "Jungle";
        const string EnvironmentNames = "VolcanicActivity, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Mog : IPlanet, IDataCache
    {
        const int Id = 89;
        const string Name = "Mog";
        const string SectorName = "Morgon";
        const string BiomeName = "Winter";
        const string EnvironmentNames = "ExtremeCold, Blizzards";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Valmox : IPlanet, IDataCache
    {
        const int Id = 90;
        const string Name = "Valmox";
        const string SectorName = "Rictus";
        const string BiomeName = "CrimsonMoor";
        const string EnvironmentNames = "IonStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Iro : IPlanet, IDataCache
    {
        const int Id = 91;
        const string Name = "Iro";
        const string SectorName = "Rictus";
        const string BiomeName = "Highlands";
        const string EnvironmentNames = "ThickFog, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Grafmere : IPlanet, IDataCache
    {
        const int Id = 92;
        const string Name = "Grafmere";
        const string SectorName = "Rictus";
        const string BiomeName = "IceMoss";
        const string EnvironmentNames = "ExtremeCold";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class NewStockholm : IPlanet, IDataCache
    {
        const int Id = 93;
        const string Name = "New Stockholm";
        const string SectorName = "Hanzo";
        const string BiomeName = "Winter";
        const string EnvironmentNames = "ExtremeCold, Blizzards";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Oasis : IPlanet, IDataCache
    {
        const int Id = 94;
        const string Name = "Oasis";
        const string SectorName = "Rictus";
        const string BiomeName = "Jungle";
        const string EnvironmentNames = "VolcanicActivity, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class GenesisPrime : IPlanet, IDataCache
    {
        const int Id = 95;
        const string Name = "Genesis Prime";
        const string SectorName = "Rictus";
        const string BiomeName = "CrimsonMoor";
        const string EnvironmentNames = "IonStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Outpost32 : IPlanet, IDataCache
    {
        const int Id = 96;
        const string Name = "Outpost 32";
        const string SectorName = "Saleria";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat, Sandstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Calypso : IPlanet, IDataCache
    {
        const int Id = 97;
        const string Name = "Calypso";
        const string SectorName = "Saleria";
        const string BiomeName = "Canyon";
        const string EnvironmentNames = "Tremors";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class ElysianMeadows : IPlanet, IDataCache
    {
        const int Id = 98;
        const string Name = "Elysian Meadows";
        const string SectorName = "Guang";
        const string BiomeName = "CrimsonMoor";
        const string EnvironmentNames = "IonStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class AlderidgeCove : IPlanet, IDataCache
    {
        const int Id = 99;
        const string Name = "Alderidge Cove";
        const string SectorName = "Guang";
        const string BiomeName = "Swamp";
        const string EnvironmentNames = "ThickFog";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Trandor : IPlanet, IDataCache
    {
        const int Id = 100;
        const string Name = "Trandor";
        const string SectorName = "Sten";
        const string BiomeName = "Tundra";
        const string EnvironmentNames = "";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class EastIridiumTradingBay : IPlanet, IDataCache
    {
        const int Id = 101;
        const string Name = "East Iridium Trading Bay";
        const string SectorName = "Tarragon";
        const string BiomeName = "Jungle";
        const string EnvironmentNames = "VolcanicActivity, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class LibertyRidge : IPlanet, IDataCache
    {
        const int Id = 102;
        const string Name = "Liberty Ridge";
        const string SectorName = "Meridian";
        const string BiomeName = "CrimsonMoor";
        const string EnvironmentNames = "IonStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class BaldrickPrime : IPlanet, IDataCache
    {
        const int Id = 103;
        const string Name = "Baldrick Prime";
        const string SectorName = "Meridian";
        const string BiomeName = "Jungle";
        const string EnvironmentNames = "VolcanicActivity, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class TheWeir : IPlanet, IDataCache
    {
        const int Id = 104;
        const string Name = "The Weir";
        const string SectorName = "Theseus";
        const string BiomeName = "Highlands";
        const string EnvironmentNames = "ThickFog, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Kuper : IPlanet, IDataCache
    {
        const int Id = 105;
        const string Name = "Kuper";
        const string SectorName = "Theseus";
        const string BiomeName = "CrimsonMoor";
        const string EnvironmentNames = "IonStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class OsloStation : IPlanet, IDataCache
    {
        const int Id = 106;
        const string Name = "Oslo Station";
        const string SectorName = "Sagan";
        const string BiomeName = "IceMoss";
        const string EnvironmentNames = "ExtremeCold";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class PöpliIX : IPlanet, IDataCache
    {
        const int Id = 107;
        const string Name = "Pöpli IX";
        const string SectorName = "Xzar";
        const string BiomeName = "Desolate";
        const string EnvironmentNames = "IntenseHeat, FireTornadoes";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Gunvald : IPlanet, IDataCache
    {
        const int Id = 108;
        const string Name = "Gunvald";
        const string SectorName = "Sagan";
        const string BiomeName = "CrimsonMoor";
        const string EnvironmentNames = "IonStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Dolph : IPlanet, IDataCache
    {
        const int Id = 109;
        const string Name = "Dolph";
        const string SectorName = "Nanos";
        const string BiomeName = "null";
        const string EnvironmentNames = "ExtremeCold, MeteorStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class BekvamIII : IPlanet, IDataCache
    {
        const int Id = 110;
        const string Name = "Bekvam III";
        const string SectorName = "Nanos";
        const string BiomeName = "null";
        const string EnvironmentNames = "";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class DumaTyr : IPlanet, IDataCache
    {
        const int Id = 111;
        const string Name = "Duma Tyr";
        const string SectorName = "Nanos";
        const string BiomeName = "null";
        const string EnvironmentNames = "";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class VernenWells : IPlanet, IDataCache
    {
        const int Id = 112;
        const string Name = "Vernen Wells";
        const string SectorName = "Hydra";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat, AcidStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class AesirPass : IPlanet, IDataCache
    {
        const int Id = 113;
        const string Name = "Aesir Pass";
        const string SectorName = "Hydra";
        const string BiomeName = "Swamp";
        const string EnvironmentNames = "ThickFog";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class AuroraBay : IPlanet, IDataCache
    {
        const int Id = 114;
        const string Name = "Aurora Bay";
        const string SectorName = "Valdis";
        const string BiomeName = "Tundra";
        const string EnvironmentNames = "";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Penta : IPlanet, IDataCache
    {
        const int Id = 115;
        const string Name = "Penta";
        const string SectorName = "Lacaille";
        const string BiomeName = "Swamp";
        const string EnvironmentNames = "ThickFog";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Gaellivare : IPlanet, IDataCache
    {
        const int Id = 116;
        const string Name = "Gaellivare";
        const string SectorName = "Talus";
        const string BiomeName = "Jungle";
        const string EnvironmentNames = "VolcanicActivity, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Vogsojoth : IPlanet, IDataCache
    {
        const int Id = 117;
        const string Name = "Vog-sojoth";
        const string SectorName = "Tanis";
        const string BiomeName = "Winter";
        const string EnvironmentNames = "ExtremeCold, Blizzards";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Kirrik : IPlanet, IDataCache
    {
        const int Id = 118;
        const string Name = "Kirrik";
        const string SectorName = "Arturion";
        const string BiomeName = "Jungle";
        const string EnvironmentNames = "VolcanicActivity, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class MortaxPrime : IPlanet, IDataCache
    {
        const int Id = 119;
        const string Name = "Mortax Prime";
        const string SectorName = "Arturion";
        const string BiomeName = "Desert";
        const string EnvironmentNames = "IntenseHeat, Tremors";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class WilfordStation : IPlanet, IDataCache
    {
        const int Id = 120;
        const string Name = "Wilford Station";
        const string SectorName = "Arturion";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat, AcidStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class PioneerII : IPlanet, IDataCache
    {
        const int Id = 121;
        const string Name = "Pioneer II";
        const string SectorName = "Arturion";
        const string BiomeName = "Canyon";
        const string EnvironmentNames = "Tremors";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class ErsonSands : IPlanet, IDataCache
    {
        const int Id = 122;
        const string Name = "Erson Sands";
        const string SectorName = "Falstaff";
        const string BiomeName = "Desert";
        const string EnvironmentNames = "IntenseHeat, Tremors";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class SocorroIII : IPlanet, IDataCache
    {
        const int Id = 123;
        const string Name = "Socorro III";
        const string SectorName = "Falstaff";
        const string BiomeName = "null";
        const string EnvironmentNames = "";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class BoreRock : IPlanet, IDataCache
    {
        const int Id = 124;
        const string Name = "Bore Rock";
        const string SectorName = "Falstaff";
        const string BiomeName = "Desolate";
        const string EnvironmentNames = "IntenseHeat, FireTornadoes";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class FenrirIII : IPlanet, IDataCache
    {
        const int Id = 125;
        const string Name = "Fenrir III";
        const string SectorName = "Umlaut";
        const string BiomeName = "Moon";
        const string EnvironmentNames = "ExtremeCold, MeteorStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Turing : IPlanet, IDataCache
    {
        const int Id = 126;
        const string Name = "Turing";
        const string SectorName = "Umlaut";
        const string BiomeName = "Ethereal";
        const string EnvironmentNames = "";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class AngelsVenture : IPlanet, IDataCache
    {
        const int Id = 127;
        const string Name = "Angel's Venture";
        const string SectorName = "Orion";
        const string BiomeName = "Tundra";
        const string EnvironmentNames = "";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class DariusII : IPlanet, IDataCache
    {
        const int Id = 128;
        const string Name = "Darius II";
        const string SectorName = "Borgus";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat, AcidStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class AcamarIV : IPlanet, IDataCache
    {
        const int Id = 129;
        const string Name = "Acamar IV";
        const string SectorName = "JinXi";
        const string BiomeName = "Highlands";
        const string EnvironmentNames = "ThickFog, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class AchernarSecundus : IPlanet, IDataCache
    {
        const int Id = 130;
        const string Name = "Achernar Secundus";
        const string SectorName = "Borgus";
        const string BiomeName = "Highlands";
        const string EnvironmentNames = "ThickFog, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class AchirdIII : IPlanet, IDataCache
    {
        const int Id = 131;
        const string Name = "Achird III";
        const string SectorName = "Borgus";
        const string BiomeName = "Canyon";
        const string EnvironmentNames = "Tremors";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class AcrabXI : IPlanet, IDataCache
    {
        const int Id = 132;
        const string Name = "Acrab XI";
        const string SectorName = "Ursa";
        const string BiomeName = "CrimsonMoor";
        const string EnvironmentNames = "IonStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class AcruxIX : IPlanet, IDataCache
    {
        const int Id = 133;
        const string Name = "Acrux IX";
        const string SectorName = "Ursa";
        const string BiomeName = "IceMoss";
        const string EnvironmentNames = "ExtremeCold";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class AcubensPrime : IPlanet, IDataCache
    {
        const int Id = 134;
        const string Name = "Acubens Prime";
        const string SectorName = "Gallux";
        const string BiomeName = "null";
        const string EnvironmentNames = "";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Adhara : IPlanet, IDataCache
    {
        const int Id = 135;
        const string Name = "Adhara";
        const string SectorName = "Gallux";
        const string BiomeName = "Desolate";
        const string EnvironmentNames = "IntenseHeat, FireTornadoes";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class AfoyayBay : IPlanet, IDataCache
    {
        const int Id = 136;
        const string Name = "Afoyay Bay";
        const string SectorName = "Gallux";
        const string BiomeName = "Highlands";
        const string EnvironmentNames = "ThickFog, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Ain5 : IPlanet, IDataCache
    {
        const int Id = 137;
        const string Name = "Ain-5";
        const string SectorName = "Hanzo";
        const string BiomeName = "Swamp";
        const string EnvironmentNames = "ThickFog";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class AlairtIII : IPlanet, IDataCache
    {
        const int Id = 138;
        const string Name = "Alairt III";
        const string SectorName = "Hanzo";
        const string BiomeName = "RainForest";
        const string EnvironmentNames = "IonStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class AlamakVII : IPlanet, IDataCache
    {
        const int Id = 139;
        const string Name = "Alamak VII";
        const string SectorName = "Hanzo";
        const string BiomeName = "null";
        const string EnvironmentNames = "";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Alaraph : IPlanet, IDataCache
    {
        const int Id = 140;
        const string Name = "Alaraph";
        const string SectorName = "Akira";
        const string BiomeName = "Swamp";
        const string EnvironmentNames = "ThickFog";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class AlathfarXI : IPlanet, IDataCache
    {
        const int Id = 141;
        const string Name = "Alathfar XI";
        const string SectorName = "Akira";
        const string BiomeName = "Winter";
        const string EnvironmentNames = "ExtremeCold, Blizzards";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Andar : IPlanet, IDataCache
    {
        const int Id = 142;
        const string Name = "Andar";
        const string SectorName = "Akira";
        const string BiomeName = "null";
        const string EnvironmentNames = "";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class AsperothPrime : IPlanet, IDataCache
    {
        const int Id = 143;
        const string Name = "Asperoth Prime";
        const string SectorName = "Akira";
        const string BiomeName = "Desolate";
        const string EnvironmentNames = "IntenseHeat, FireTornadoes";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Bellatrix : IPlanet, IDataCache
    {
        const int Id = 144;
        const string Name = "Bellatrix";
        const string SectorName = "Guang";
        const string BiomeName = "Highlands";
        const string EnvironmentNames = "ThickFog, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Botein : IPlanet, IDataCache
    {
        const int Id = 145;
        const string Name = "Botein";
        const string SectorName = "Guang";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat, AcidStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Osupsam : IPlanet, IDataCache
    {
        const int Id = 146;
        const string Name = "Osupsam";
        const string SectorName = "Tarragon";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat, Sandstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Brink2 : IPlanet, IDataCache
    {
        const int Id = 147;
        const string Name = "Brink-2";
        const string SectorName = "Tarragon";
        const string BiomeName = "RainForest";
        const string EnvironmentNames = "IonStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class BundaSecundus : IPlanet, IDataCache
    {
        const int Id = 148;
        const string Name = "Bunda Secundus";
        const string SectorName = "Tarragon";
        const string BiomeName = "null";
        const string EnvironmentNames = "";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Canopus : IPlanet, IDataCache
    {
        const int Id = 149;
        const string Name = "Canopus";
        const string SectorName = "Tarragon";
        const string BiomeName = "Desert";
        const string EnvironmentNames = "IntenseHeat, Tremors";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Caph : IPlanet, IDataCache
    {
        const int Id = 150;
        const string Name = "Caph";
        const string SectorName = "Theseus";
        const string BiomeName = "Jungle";
        const string EnvironmentNames = "VolcanicActivity, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Castor : IPlanet, IDataCache
    {
        const int Id = 151;
        const string Name = "Castor";
        const string SectorName = "Theseus";
        const string BiomeName = "Canyon";
        const string EnvironmentNames = "Tremors";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Durgen : IPlanet, IDataCache
    {
        const int Id = 152;
        const string Name = "Durgen";
        const string SectorName = "Severin";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat, Sandstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Draupnir : IPlanet, IDataCache
    {
        const int Id = 153;
        const string Name = "Draupnir";
        const string SectorName = "Xzar";
        const string BiomeName = "Highlands";
        const string EnvironmentNames = "ThickFog, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Mort : IPlanet, IDataCache
    {
        const int Id = 154;
        const string Name = "Mort";
        const string SectorName = "Xzar";
        const string BiomeName = "Swamp";
        const string EnvironmentNames = "ThickFog";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Ingmar : IPlanet, IDataCache
    {
        const int Id = 155;
        const string Name = "Ingmar";
        const string SectorName = "Xzar";
        const string BiomeName = "CrimsonMoor";
        const string EnvironmentNames = "IonStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class CharbalVII : IPlanet, IDataCache
    {
        const int Id = 156;
        const string Name = "Charbal-VII";
        const string SectorName = "Andromeda";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat, AcidStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class CharonPrime : IPlanet, IDataCache
    {
        const int Id = 157;
        const string Name = "Charon Prime";
        const string SectorName = "Andromeda";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class ChoepessaIV : IPlanet, IDataCache
    {
        const int Id = 158;
        const string Name = "Choepessa IV";
        const string SectorName = "Trigon";
        const string BiomeName = "IceMoss";
        const string EnvironmentNames = "ExtremeCold";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Choohe : IPlanet, IDataCache
    {
        const int Id = 159;
        const string Name = "Choohe";
        const string SectorName = "Lacaille";
        const string BiomeName = "Desert";
        const string EnvironmentNames = "IntenseHeat, Tremors";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class ChortBay : IPlanet, IDataCache
    {
        const int Id = 160;
        const string Name = "Chort Bay";
        const string SectorName = "Lacaille";
        const string BiomeName = "RainForest";
        const string EnvironmentNames = "IonStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Claorell : IPlanet, IDataCache
    {
        const int Id = 161;
        const string Name = "Claorell";
        const string SectorName = "Tanis";
        const string BiomeName = "null";
        const string EnvironmentNames = "ExtremeCold, MeteorStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Clasa : IPlanet, IDataCache
    {
        const int Id = 162;
        const string Name = "Clasa";
        const string SectorName = "Tanis";
        const string BiomeName = "Jungle";
        const string EnvironmentNames = "VolcanicActivity, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Demiurg : IPlanet, IDataCache
    {
        const int Id = 163;
        const string Name = "Demiurg";
        const string SectorName = "Tanis";
        const string BiomeName = "Tundra";
        const string EnvironmentNames = "";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class DenebSecundus : IPlanet, IDataCache
    {
        const int Id = 164;
        const string Name = "Deneb Secundus";
        const string SectorName = "Arturion";
        const string BiomeName = "IceMoss";
        const string EnvironmentNames = "ExtremeCold";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class ElectraBay : IPlanet, IDataCache
    {
        const int Id = 165;
        const string Name = "Electra Bay";
        const string SectorName = "Arturion";
        const string BiomeName = "Highlands";
        const string EnvironmentNames = "ThickFog, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Enuliale : IPlanet, IDataCache
    {
        const int Id = 166;
        const string Name = "Enuliale";
        const string SectorName = "Lestrade";
        const string BiomeName = "CrimsonMoor";
        const string EnvironmentNames = "IonStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class EpsilonPhoencisVI : IPlanet, IDataCache
    {
        const int Id = 167;
        const string Name = "Epsilon Phoencis VI";
        const string SectorName = "Lestrade";
        const string BiomeName = "Winter";
        const string EnvironmentNames = "ExtremeCold, Blizzards";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class ErataPrime : IPlanet, IDataCache
    {
        const int Id = 168;
        const string Name = "Erata Prime";
        const string SectorName = "Umlaut";
        const string BiomeName = "Desert";
        const string EnvironmentNames = "IntenseHeat, Tremors";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Estanu : IPlanet, IDataCache
    {
        const int Id = 169;
        const string Name = "Estanu";
        const string SectorName = "Draco";
        const string BiomeName = "IceMoss";
        const string EnvironmentNames = "ExtremeCold";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class ForiPrime : IPlanet, IDataCache
    {
        const int Id = 170;
        const string Name = "Fori Prime";
        const string SectorName = "Draco";
        const string BiomeName = "Canyon";
        const string EnvironmentNames = "Tremors";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Gacrux : IPlanet, IDataCache
    {
        const int Id = 171;
        const string Name = "Gacrux";
        const string SectorName = "JinXi";
        const string BiomeName = "null";
        const string EnvironmentNames = "";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class GarHaren : IPlanet, IDataCache
    {
        const int Id = 172;
        const string Name = "Gar Haren";
        const string SectorName = "JinXi";
        const string BiomeName = "Jungle";
        const string EnvironmentNames = "VolcanicActivity, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Gatria : IPlanet, IDataCache
    {
        const int Id = 173;
        const string Name = "Gatria";
        const string SectorName = "JinXi";
        const string BiomeName = "CrimsonMoor";
        const string EnvironmentNames = "IonStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Gemma : IPlanet, IDataCache
    {
        const int Id = 174;
        const string Name = "Gemma";
        const string SectorName = "Ursa";
        const string BiomeName = "RainForest";
        const string EnvironmentNames = "IonStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class GrandErrant : IPlanet, IDataCache
    {
        const int Id = 175;
        const string Name = "Grand Errant";
        const string SectorName = "Farsight";
        const string BiomeName = "Desolate";
        const string EnvironmentNames = "IntenseHeat, FireTornadoes";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Hadar : IPlanet, IDataCache
    {
        const int Id = 176;
        const string Name = "Hadar";
        const string SectorName = "Ferris";
        const string BiomeName = "Winter";
        const string EnvironmentNames = "ExtremeCold, Blizzards";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Haka : IPlanet, IDataCache
    {
        const int Id = 177;
        const string Name = "Haka";
        const string SectorName = "Leo";
        const string BiomeName = "Swamp";
        const string EnvironmentNames = "ThickFog";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Haldus : IPlanet, IDataCache
    {
        const int Id = 178;
        const string Name = "Haldus";
        const string SectorName = "Ferris";
        const string BiomeName = "null";
        const string EnvironmentNames = "ExtremeCold, MeteorStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class HaliesPort : IPlanet, IDataCache
    {
        const int Id = 179;
        const string Name = "Halies Port";
        const string SectorName = "Leo";
        const string BiomeName = "IceMoss";
        const string EnvironmentNames = "ExtremeCold";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class HerthonSecundus : IPlanet, IDataCache
    {
        const int Id = 180;
        const string Name = "Herthon Secundus";
        const string SectorName = "Ferris";
        const string BiomeName = "Desolate";
        const string EnvironmentNames = "IntenseHeat, FireTornadoes";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class HesoePrime : IPlanet, IDataCache
    {
        const int Id = 181;
        const string Name = "Hesoe Prime";
        const string SectorName = "Rigel";
        const string BiomeName = "Winter";
        const string EnvironmentNames = "ExtremeCold, Blizzards";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class HezeBay : IPlanet, IDataCache
    {
        const int Id = 182;
        const string Name = "Heze Bay";
        const string SectorName = "Hanzo";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat, Sandstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Hort : IPlanet, IDataCache
    {
        const int Id = 183;
        const string Name = "Hort";
        const string SectorName = "Rigel";
        const string BiomeName = "Highlands";
        const string EnvironmentNames = "ThickFog, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Hydrobius : IPlanet, IDataCache
    {
        const int Id = 184;
        const string Name = "Hydrobius";
        const string SectorName = "Omega";
        const string BiomeName = "Desert";
        const string EnvironmentNames = "IntenseHeat, Tremors";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Karlia : IPlanet, IDataCache
    {
        const int Id = 185;
        const string Name = "Karlia";
        const string SectorName = "Omega";
        const string BiomeName = "Desolate";
        const string EnvironmentNames = "IntenseHeat, FireTornadoes";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Keid : IPlanet, IDataCache
    {
        const int Id = 186;
        const string Name = "Keid";
        const string SectorName = "Akira";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat, Sandstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Khandark : IPlanet, IDataCache
    {
        const int Id = 187;
        const string Name = "Khandark";
        const string SectorName = "Guang";
        const string BiomeName = "Winter";
        const string EnvironmentNames = "ExtremeCold, Blizzards";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Klaka5 : IPlanet, IDataCache
    {
        const int Id = 188;
        const string Name = "Klaka 5";
        const string SectorName = "Alstrad";
        const string BiomeName = "Jungle";
        const string EnvironmentNames = "VolcanicActivity, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class KnethPort : IPlanet, IDataCache
    {
        const int Id = 189;
        const string Name = "Kneth Port";
        const string SectorName = "Alstrad";
        const string BiomeName = "Desolate";
        const string EnvironmentNames = "IntenseHeat, FireTornadoes";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Kraz : IPlanet, IDataCache
    {
        const int Id = 190;
        const string Name = "Kraz";
        const string SectorName = "Alstrad";
        const string BiomeName = "Canyon";
        const string EnvironmentNames = "Tremors";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Kuma : IPlanet, IDataCache
    {
        const int Id = 191;
        const string Name = "Kuma";
        const string SectorName = "Hawking";
        const string BiomeName = "Canyon";
        const string EnvironmentNames = "Tremors";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Lastofe : IPlanet, IDataCache
    {
        const int Id = 192;
        const string Name = "Lastofe";
        const string SectorName = "Theseus";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat, Sandstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class LengSecundus : IPlanet, IDataCache
    {
        const int Id = 193;
        const string Name = "Leng Secundus";
        const string SectorName = "Quintus";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat, AcidStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Lesath : IPlanet, IDataCache
    {
        const int Id = 194;
        const string Name = "Lesath";
        const string SectorName = "Lacaille";
        const string BiomeName = "IceMoss";
        const string EnvironmentNames = "ExtremeCold";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Maia : IPlanet, IDataCache
    {
        const int Id = 195;
        const string Name = "Maia";
        const string SectorName = "Severin";
        const string BiomeName = "null";
        const string EnvironmentNames = "ExtremeCold, MeteorStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class MalevelonCreek : IPlanet, IDataCache
    {
        const int Id = 196;
        const string Name = "Malevelon Creek";
        const string SectorName = "Severin";
        const string BiomeName = "RainForest";
        const string EnvironmentNames = "IonStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Mantes : IPlanet, IDataCache
    {
        const int Id = 197;
        const string Name = "Mantes";
        const string SectorName = "Xzar";
        const string BiomeName = "Jungle";
        const string EnvironmentNames = "VolcanicActivity, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Marfark : IPlanet, IDataCache
    {
        const int Id = 198;
        const string Name = "Marfark";
        const string SectorName = "Andromeda";
        const string BiomeName = "Winter";
        const string EnvironmentNames = "ExtremeCold, Blizzards";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Martale : IPlanet, IDataCache
    {
        const int Id = 199;
        const string Name = "Martale";
        const string SectorName = "Andromeda";
        const string BiomeName = "null";
        const string EnvironmentNames = "";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class MatarBay : IPlanet, IDataCache
    {
        const int Id = 200;
        const string Name = "Matar Bay";
        const string SectorName = "Andromeda";
        const string BiomeName = "Highlands";
        const string EnvironmentNames = "ThickFog, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Meissa : IPlanet, IDataCache
    {
        const int Id = 201;
        const string Name = "Meissa";
        const string SectorName = "Ymir";
        const string BiomeName = "Jungle";
        const string EnvironmentNames = "VolcanicActivity, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Mekbuda : IPlanet, IDataCache
    {
        const int Id = 202;
        const string Name = "Mekbuda";
        const string SectorName = "Valdis";
        const string BiomeName = "IceMoss";
        const string EnvironmentNames = "ExtremeCold";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Menkent : IPlanet, IDataCache
    {
        const int Id = 203;
        const string Name = "Menkent";
        const string SectorName = "Hydra";
        const string BiomeName = "Desolate";
        const string EnvironmentNames = "IntenseHeat, FireTornadoes";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Merak : IPlanet, IDataCache
    {
        const int Id = 204;
        const string Name = "Merak";
        const string SectorName = "Valdis";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat, AcidStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class MergaIV : IPlanet, IDataCache
    {
        const int Id = 205;
        const string Name = "Merga IV";
        const string SectorName = "Valdis";
        const string BiomeName = "Winter";
        const string EnvironmentNames = "ExtremeCold, Blizzards";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Minchir : IPlanet, IDataCache
    {
        const int Id = 206;
        const string Name = "Minchir";
        const string SectorName = "Gellert";
        const string BiomeName = "CrimsonMoor";
        const string EnvironmentNames = "IonStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Mintoria : IPlanet, IDataCache
    {
        const int Id = 207;
        const string Name = "Mintoria";
        const string SectorName = "Gellert";
        const string BiomeName = "Highlands";
        const string EnvironmentNames = "ThickFog, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Mordia9 : IPlanet, IDataCache
    {
        const int Id = 208;
        const string Name = "Mordia 9";
        const string SectorName = "Hawking";
        const string BiomeName = "Ethereal";
        const string EnvironmentNames = "";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class NabateaSecundus : IPlanet, IDataCache
    {
        const int Id = 209;
        const string Name = "Nabatea Secundus";
        const string SectorName = "Lestrade";
        const string BiomeName = "RainForest";
        const string EnvironmentNames = "IonStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class NaviVII : IPlanet, IDataCache
    {
        const int Id = 210;
        const string Name = "Navi VII";
        const string SectorName = "Lestrade";
        const string BiomeName = "Jungle";
        const string EnvironmentNames = "VolcanicActivity, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Nivel43 : IPlanet, IDataCache
    {
        const int Id = 211;
        const string Name = "Nivel 43";
        const string SectorName = "Mirin";
        const string BiomeName = "Swamp";
        const string EnvironmentNames = "ThickFog";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Oshaune : IPlanet, IDataCache
    {
        const int Id = 212;
        const string Name = "Oshaune";
        const string SectorName = "Mirin";
        const string BiomeName = "Highlands";
        const string EnvironmentNames = "ThickFog, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class OvergoePrime : IPlanet, IDataCache
    {
        const int Id = 213;
        const string Name = "Overgoe Prime";
        const string SectorName = "Sten";
        const string BiomeName = "CrimsonMoor";
        const string EnvironmentNames = "IonStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class PandionXXIV : IPlanet, IDataCache
    {
        const int Id = 214;
        const string Name = "Pandion-XXIV";
        const string SectorName = "JinXi";
        const string BiomeName = "Swamp";
        const string EnvironmentNames = "ThickFog";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Partion : IPlanet, IDataCache
    {
        const int Id = 215;
        const string Name = "Partion";
        const string SectorName = "Sten";
        const string BiomeName = "Desolate";
        const string EnvironmentNames = "IntenseHeat, FireTornadoes";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Peacock : IPlanet, IDataCache
    {
        const int Id = 216;
        const string Name = "Peacock";
        const string SectorName = "Sten";
        const string BiomeName = "RainForest";
        const string EnvironmentNames = "IonStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class PhactBay : IPlanet, IDataCache
    {
        const int Id = 217;
        const string Name = "Phact Bay";
        const string SectorName = "JinXi";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat, Sandstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class PherkadSecundus : IPlanet, IDataCache
    {
        const int Id = 218;
        const string Name = "Pherkad Secundus";
        const string SectorName = "Farsight";
        const string BiomeName = "Highlands";
        const string EnvironmentNames = "ThickFog, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class PolarisPrime : IPlanet, IDataCache
    {
        const int Id = 219;
        const string Name = "Polaris Prime";
        const string SectorName = "Farsight";
        const string BiomeName = "Desert";
        const string EnvironmentNames = "IntenseHeat, Tremors";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Pollux31 : IPlanet, IDataCache
    {
        const int Id = 220;
        const string Name = "Pollux 31";
        const string SectorName = "Farsight";
        const string BiomeName = "Jungle";
        const string EnvironmentNames = "VolcanicActivity, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Prasa : IPlanet, IDataCache
    {
        const int Id = 221;
        const string Name = "Prasa";
        const string SectorName = "Farsight";
        const string BiomeName = "Canyon";
        const string EnvironmentNames = "Tremors";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Propus : IPlanet, IDataCache
    {
        const int Id = 222;
        const string Name = "Propus";
        const string SectorName = "Leo";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat, Sandstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class RasAlgethi : IPlanet, IDataCache
    {
        const int Id = 223;
        const string Name = "Ras Algethi";
        const string SectorName = "Leo";
        const string BiomeName = "null";
        const string EnvironmentNames = "";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class RD4 : IPlanet, IDataCache
    {
        const int Id = 224;
        const string Name = "RD-4";
        const string SectorName = "Rigel";
        const string BiomeName = "Moon";
        const string EnvironmentNames = "ExtremeCold, MeteorStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Rogue5 : IPlanet, IDataCache
    {
        const int Id = 225;
        const string Name = "Rogue 5";
        const string SectorName = "Rigel";
        const string BiomeName = "Jungle";
        const string EnvironmentNames = "VolcanicActivity, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class RirgaBay : IPlanet, IDataCache
    {
        const int Id = 226;
        const string Name = "Rirga Bay";
        const string SectorName = "Rigel";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat, AcidStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Seasse : IPlanet, IDataCache
    {
        const int Id = 227;
        const string Name = "Seasse";
        const string SectorName = "Omega";
        const string BiomeName = "RainForest";
        const string EnvironmentNames = "IonStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Senge23 : IPlanet, IDataCache
    {
        const int Id = 228;
        const string Name = "Senge 23";
        const string SectorName = "Omega";
        const string BiomeName = "Canyon";
        const string EnvironmentNames = "Tremors";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Setia : IPlanet, IDataCache
    {
        const int Id = 229;
        const string Name = "Setia";
        const string SectorName = "Omega";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat, Sandstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Shete : IPlanet, IDataCache
    {
        const int Id = 230;
        const string Name = "Shete";
        const string SectorName = "XiTauri";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat, AcidStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Siemnot : IPlanet, IDataCache
    {
        const int Id = 231;
        const string Name = "Siemnot";
        const string SectorName = "XiTauri";
        const string BiomeName = "RainForest";
        const string EnvironmentNames = "IonStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Sirius : IPlanet, IDataCache
    {
        const int Id = 232;
        const string Name = "Sirius";
        const string SectorName = "XiTauri";
        const string BiomeName = "Moon";
        const string EnvironmentNames = "ExtremeCold, MeteorStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class SkatBay : IPlanet, IDataCache
    {
        const int Id = 233;
        const string Name = "Skat Bay";
        const string SectorName = "XiTauri";
        const string BiomeName = "Swamp";
        const string EnvironmentNames = "ThickFog";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Spherion : IPlanet, IDataCache
    {
        const int Id = 234;
        const string Name = "Spherion";
        const string SectorName = "Quintus";
        const string BiomeName = "Jungle";
        const string EnvironmentNames = "VolcanicActivity, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class StorThaPrime : IPlanet, IDataCache
    {
        const int Id = 235;
        const string Name = "Stor Tha Prime";
        const string SectorName = "Quintus";
        const string BiomeName = "IceMoss";
        const string EnvironmentNames = "ExtremeCold";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Stout : IPlanet, IDataCache
    {
        const int Id = 236;
        const string Name = "Stout";
        const string SectorName = "Quintus";
        const string BiomeName = "CrimsonMoor";
        const string EnvironmentNames = "IonStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Termadon : IPlanet, IDataCache
    {
        const int Id = 237;
        const string Name = "Termadon";
        const string SectorName = "Quintus";
        const string BiomeName = "Highlands";
        const string EnvironmentNames = "ThickFog, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Tibit : IPlanet, IDataCache
    {
        const int Id = 238;
        const string Name = "Tibit";
        const string SectorName = "Severin";
        const string BiomeName = "Ethereal";
        const string EnvironmentNames = "";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class TienKwan : IPlanet, IDataCache
    {
        const int Id = 239;
        const string Name = "Tien Kwan";
        const string SectorName = "Theseus";
        const string BiomeName = "IceMossSpecial";
        const string EnvironmentNames = "ExtremeCold, MeteorStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Troost : IPlanet, IDataCache
    {
        const int Id = 240;
        const string Name = "Troost";
        const string SectorName = "Trigon";
        const string BiomeName = "Swamp";
        const string EnvironmentNames = "ThickFog";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Ubanea : IPlanet, IDataCache
    {
        const int Id = 241;
        const string Name = "Ubanea";
        const string SectorName = "Severin";
        const string BiomeName = "CrimsonMoor";
        const string EnvironmentNames = "IonStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Ustotu : IPlanet, IDataCache
    {
        const int Id = 242;
        const string Name = "Ustotu";
        const string SectorName = "Trigon";
        const string BiomeName = "Desert";
        const string EnvironmentNames = "IntenseHeat, Tremors";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class VandalonIV : IPlanet, IDataCache
    {
        const int Id = 243;
        const string Name = "Vandalon IV";
        const string SectorName = "Trigon";
        const string BiomeName = "Moon";
        const string EnvironmentNames = "ExtremeCold, Blizzards";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Varylia5 : IPlanet, IDataCache
    {
        const int Id = 244;
        const string Name = "Varylia 5";
        const string SectorName = "Trigon";
        const string BiomeName = "Highlands";
        const string EnvironmentNames = "ThickFog, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Wasat : IPlanet, IDataCache
    {
        const int Id = 245;
        const string Name = "Wasat";
        const string SectorName = "Ymir";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat, AcidStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class VegaBay : IPlanet, IDataCache
    {
        const int Id = 246;
        const string Name = "Vega Bay";
        const string SectorName = "Ymir";
        const string BiomeName = "Winter";
        const string EnvironmentNames = "ExtremeCold, Blizzards";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Wezen : IPlanet, IDataCache
    {
        const int Id = 247;
        const string Name = "Wezen";
        const string SectorName = "Ymir";
        const string BiomeName = "Desolate";
        const string EnvironmentNames = "IntenseHeat, FireTornadoes";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class VindemitarixPrime : IPlanet, IDataCache
    {
        const int Id = 248;
        const string Name = "Vindemitarix Prime";
        const string SectorName = "Valdis";
        const string BiomeName = "Ethereal";
        const string EnvironmentNames = "";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class X45 : IPlanet, IDataCache
    {
        const int Id = 249;
        const string Name = "X-45";
        const string SectorName = "Ymir";
        const string BiomeName = "Swamp";
        const string EnvironmentNames = "ThickFog";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class YedPrior : IPlanet, IDataCache
    {
        const int Id = 250;
        const string Name = "Yed Prior";
        const string SectorName = "Tanis";
        const string BiomeName = "CrimsonMoor";
        const string EnvironmentNames = "IonStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Zefia : IPlanet, IDataCache
    {
        const int Id = 251;
        const string Name = "Zefia";
        const string SectorName = "Tanis";
        const string BiomeName = "Ethereal";
        const string EnvironmentNames = "";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Zosma : IPlanet, IDataCache
    {
        const int Id = 252;
        const string Name = "Zosma";
        const string SectorName = "Gellert";
        const string BiomeName = "Moon";
        const string EnvironmentNames = "ExtremeCold, MeteorStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class ZzaniahPrime : IPlanet, IDataCache
    {
        const int Id = 253;
        const string Name = "Zzaniah Prime";
        const string SectorName = "Gellert";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat, Sandstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Skitter : IPlanet, IDataCache
    {
        const int Id = 254;
        const string Name = "Skitter";
        const string SectorName = "Hawking";
        const string BiomeName = "Highlands";
        const string EnvironmentNames = "ThickFog, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class EuphoriaIII : IPlanet, IDataCache
    {
        const int Id = 255;
        const string Name = "Euphoria III";
        const string SectorName = "Hawking";
        const string BiomeName = "Moon";
        const string EnvironmentNames = "ExtremeCold, MeteorStorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class DiasporaX : IPlanet, IDataCache
    {
        const int Id = 256;
        const string Name = "Diaspora X";
        const string SectorName = "Lestrade";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat, Sandstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class GemstoneBluffs : IPlanet, IDataCache
    {
        const int Id = 257;
        const string Name = "Gemstone Bluffs";
        const string SectorName = "Lestrade";
        const string BiomeName = "Highlands";
        const string EnvironmentNames = "ThickFog, Rainstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class ZagonPrime : IPlanet, IDataCache
    {
        const int Id = 258;
        const string Name = "Zagon Prime";
        const string SectorName = "Mirin";
        const string BiomeName = "null";
        const string EnvironmentNames = "IntenseHeat, Sandstorms";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Omicron : IPlanet, IDataCache
    {
        const int Id = 259;
        const string Name = "Omicron";
        const string SectorName = "Lestrade";
        const string BiomeName = "Tundra";
        const string EnvironmentNames = "";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }
    public class Cyberstan : IPlanet, IDataCache
    {
        const int Id = 260;
        const string Name = "Cyberstan";
        const string SectorName = "Valdis";
        const string BiomeName = "Canyon";
        const string EnvironmentNames = "Tremors";

        int IPlanet.Id => Id;
        string IPlanet.Name => Name;
        string IPlanet.SectorName => SectorName;

        int IDataCache.Id => Id;
        string IDataCache.Name => Name;

        IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
        IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);
    }


}
