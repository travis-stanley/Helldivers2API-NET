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
    // TODO: define enums for types
    // TODO: define enums for value types
    // TODO: values are probably planet ids - e.g. defend planets

    /// <summary>
    /// Contains information about the current assignment tasks.
    /// </summary>
    public class AssignmentTask
    {
        public int Type { get; set; } = default!;

        public int[] Values { get; set; } = default!;

        public int[] ValueTypes { get; set; } = default!;
    }

}
