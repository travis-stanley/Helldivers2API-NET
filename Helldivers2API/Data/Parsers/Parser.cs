using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using Helldivers2API.Data.Models.Interfaces;
using Helldivers2API.Data.Cache;

namespace Helldivers2API.Web.Data
{

    /// <summary>
    /// Builds concrete classes for data gathered outside the api
    /// </summary>
    internal class BiomeParser
    {
        private static string _dataSource = "biomes.txt";
        private static string _data = "";

        private static void Build()
        {
            var sourceFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!, $"Data\\Parsers\\{_dataSource}");
            //_data = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText(sourceFile));
            _data = File.ReadAllText( sourceFile );
        }

        public static void ParseMetadata()
        {
            var template = """
                    internal class #NAME# : IBiome
                    {
                        const string Name = "#PNAME#";
                        const string Description = "#DESC#";

                        string IBiome.Name => Name;
                        string IBiome.Description => Description;
                    }
                    """;

            Build();

            var regexSplit = new Regex(@",(?![^\{\}]*\})");
            foreach(var biome in regexSplit.Split(_data))
            {
                var parts = biome.Split(":", 2, StringSplitOptions.TrimEntries);
                var name = parts[0];
                var description = parts[1].Split(":", StringSplitOptions.TrimEntries).Last().Replace("}", "").Replace(";", "").Replace("\"", "").Replace("\n", "");

                var cls = template.Replace("#NAME#", name.Replace(" ", "")).Replace("#PNAME#", name).Replace("#DESC#", description);
                Debug.Print(cls);
            }


        }
    }

    /// <summary>
    /// Builds concrete classes for data gathered outside the api
    /// </summary>
    internal class PlanetParser
    {
        private static string _dataSource = "planets.txt";
        private static Dictionary<int, string>? _data;

        public static string Get(int id)
        {
            if (_data == null) Build();
            if (_data != null)
                if (_data.ContainsKey(id)) return _data[id];
            return $"Id Unknown ({id})";
        }

        private static void Build()
        {
            var sourceFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!, $"Data\\Parsers\\{_dataSource}");
            _data = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<int, string>>(File.ReadAllText(sourceFile));
        }

        public static void ParseMetadata()
        {
            var template = """
                internal class #NAME# : IPlanet, IDataCache
                {
                    const int Id = #ID#;
                    const string Name = "#PNAME#";
                    const string SectorName = "#SNAME#";
                    const string BiomeName = "#BNAME#";
                    const string EnvironmentNames = "#ENAMES#";

                    int IPlanet.Id => Id;
                    string IPlanet.Name => Name;
                    string IPlanet.SectorName => SectorName;

                    int IDataCache.Id => Id;
                    string IDataCache.Name => Name;

                    IBiome? IPlanet.Biome => DataCache<IBiome>.Get(BiomeName);
                    IEnvironment?[] IPlanet.Environments => DataCache<IEnvironment>.GetMany(EnvironmentNames);                    
                }
                """;

            var sourceFile = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)!, $"Data\\Parsers\\planets.txt");
            var data = File.ReadAllText(sourceFile).Replace("\n", "").Replace("\r", "").Trim();

            var regexPlanetGroups = new Regex(@"(\d+:\s)\{([^}]+)\}");
            var regexSplitExceptInBrackets = new Regex(@",(?![^\[\]]*\])");

            var planets = regexPlanetGroups.Matches(data);
            foreach (Match planet in planets)
            {
                var planetProperties = new Dictionary<string, string>();               
                var planetProps = regexSplitExceptInBrackets.Split(planet.Groups[2].Value.Trim());
                foreach (var property in planetProps)
                {
                    var parts = property.Split(":", 2, StringSplitOptions.TrimEntries);
                    planetProperties.Add(parts[0].Trim(), parts[1].Trim());
                }

                var id = planet.Groups[1].Value.Replace(":", "").Trim();
                var name = planetProperties["name"].Replace("\"", "");
                var sector = planetProperties["sector"];
                var biome = planetProperties["biome"];
                var envs = planetProperties["environmentals"].Replace("[", "").Replace("]", "");

                var cls = template.Replace("#NAME#", name.Replace(" ", "").Replace("'", "").Replace("-", "")).Replace("#PNAME#", name).Replace("#ID#", id).Replace("#SNAME#", sector).Replace("#BNAME#", biome).Replace("#ENAMES#", envs);
                Debug.Print(cls);

            }
        }
    }

    internal class SectorParser
    {

        public static void ParseFromPlanets()
        {
            var template = """
                internal class #NAME# : ISector, IDataCache
                {
                    const int Id = #ID#;
                    const string Name = "#PNAME#";
                    const string PlanetIds = "#PIDS#";

                    int ISector.Id => Id;
                    string ISector.Name => Name;    
                    string ISector.PlanetIds => PlanetIds;                

                    int IDataCache.Id => Id;
                    string IDataCache.Name => Name;
                }
                """;

            Dictionary<string, List<int>> discoveredSectors = new();
            foreach(var planet in DataCache<IPlanet>.GetAll())
            {
                var name = planet.SectorName;
                
                if (!discoveredSectors.ContainsKey(name))
                    discoveredSectors.Add(name, new List<int>());
                discoveredSectors[name].Add(planet.Id);
            }

            int count = 0;
            foreach(var sector in discoveredSectors)
            {
                var name = sector.Key;
                var planetIds = String.Join(", ", sector.Value);
                var id = count.ToString();

                var cls = template.Replace("#NAME#", name.Replace(" ", "").Replace("'", "").Replace("-", "")).Replace("#PNAME#", name).Replace("#ID#", id).Replace("#PIDS#", planetIds);
                Debug.Print(cls);

                count++;
            }

        }
    }
}
