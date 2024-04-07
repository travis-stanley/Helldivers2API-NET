using Helldivers2API.Data.Cache;
using Helldivers2API.Data.Models.Interfaces;

namespace Helldivers2API.Data.Models
{

    internal class Humans : IFaction
    {
        const int Id = 1;
        const string Name = "Humans";
        const string Description = "";

        int IFaction.Id => Id;
        string IFaction.Name => Name;
        string IFaction.Description => Description;

        string IDataCache.Name => Name;
        int IDataCache.Id => Id;

    }
    internal class Terminids : IFaction
    {
        const int Id = 2;
        const string Name = "Terminids";
        const string Description = "";

        int IFaction.Id => Id;
        string IFaction.Name => Name;
        string IFaction.Description => Description;

        string IDataCache.Name => Name;
        int IDataCache.Id => Id;
    }
    internal class Automaton : IFaction
    {
        const int Id = 3;
        const string Name = "Automaton";
        const string Description = "";

        int IFaction.Id => Id;
        string IFaction.Name => Name;
        string IFaction.Description => Description;

        string IDataCache.Name => Name;
        int IDataCache.Id => Id;
    }
    internal class Illuminate : IFaction
    {
        const int Id = 4;
        const string Name = "Illuminate";
        const string Description = "";

        int IFaction.Id => Id;
        string IFaction.Name => Name;
        string IFaction.Description => Description;

        string IDataCache.Name => Name;
        int IDataCache.Id => Id;
    }


    internal class UnknownFaction : IFaction
    {
        const int Id = -1;
        const string Name = "Unknown";
        const string Description = "";

        int IFaction.Id => Id;
        string IFaction.Name => Name;
        string IFaction.Description => Description;

        string IDataCache.Name => Name;
        int IDataCache.Id => Id;
    }
}
