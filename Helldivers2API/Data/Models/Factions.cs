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

    public class Humans : IFaction
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
    public class Terminids : IFaction
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
    public class Automaton : IFaction
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

}
