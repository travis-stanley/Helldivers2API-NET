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

    /// <summary>
    /// Contains information about the current assignment (e.g. Major Order).
    /// </summary>
    public class Assignment
    {
        public long Id { get; set; } = default!;
        public long ExpiresIn { get; set; } = default!;
        public int[] Progress { get; set; } = default!;     // TODO: define what this is

        public int Type { get; set; } = default!;           // TODO: define what this is
        public string Title { get; set; } = default!;
        public string Brief { get; set; } = default!;
        public string Description { get; set; } = default!;

        public AssignmentTask[] Tasks { get; set; } = default!;
        public int RewardType { get; set; } = default!;     // TODO: define what this is
        public int RewardAmount { get; set; } = default!;

        public int Flags { get; set; } = default!;
    }


    /// <summary>
    /// Contains information about the current assignment tasks.
    /// </summary>
    public class AssignmentTask
    {
        public int Type { get; set; } = default!;           // TODO: define what this is

        public int[] Values { get; set; } = default!;       // TODO: define what this is

        public int[] ValueTypes { get; set; } = default!;   // TODO: define what this is
    }
}
