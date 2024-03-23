using Helldivers2API.Data.Models.Interfaces;
using Helldivers2API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helldivers2API.Web;

namespace Helldivers2API.Data.Cache
{

    /// <summary>
    /// Local data cache
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class DataCache<T> where T : IDataCache
    {
        private static T[] _cache = default!;

        public static T? Get(int id)
        {
            if (_cache == default) Build();
            return _cache!.Where(w => w.Id == id).FirstOrDefault();
        }

        public static T? Get(string name)
        {
            Ensure.ArgumentNotNull(name, nameof(name));

            if (_cache == default) Build();
            return _cache!.Where(w => w.Name == name).FirstOrDefault();
        }

        public static T?[] GetMany(string names)
        {
            Ensure.ArgumentNotNull(names, nameof(names));

            if (_cache == default) Build();
            // return _cache!.Where(w => names.Split(",", StringSplitOptions.TrimEntries).Contains(w.Name)).ToArray();

            // force unknown items to add a null entry so we know a provided name was not in the cache
            List<T?> items = new();
            foreach (string name in names.Split(",", StringSplitOptions.TrimEntries))
                items.Add(_cache!.Where(w => w.Name == name).FirstOrDefault());
            return items.ToArray();
        }

        public static T[] GetAll()
        {
            if (_cache == default) Build();
            return _cache!;
        }

        private static void Build()
        {
            var clsList = new List<T>();

            var types = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(x => x.GetTypes())
            .Where(x => typeof(T).IsAssignableFrom(x) && !x.IsInterface && !x.IsAbstract);

            foreach (var itype in types)
            {
                clsList.Add((T)Activator.CreateInstance(itype)!);
            }
            _cache = clsList.ToArray();
        }        
    }

}
