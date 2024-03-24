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
    // TODO: confirm what progress is - probably progress for each item in tasks[]
    // TODO: define enums for types
    // TODO: define enums for reward types
    // TODO: define enums for flags

    /// <summary>
    /// Contains information about the current assignment (e.g. Major Order).
    /// </summary>
    public class Assignment
    {
        public long Id { get; set; } = default!;
        public long ExpiresIn { get; set; } = default!;
        public int[] Progress { get; set; } = default!;

        public int Type { get; set; } = default!;
        public string Title { get; set; } = default!;
        public string Brief { get; set; } = default!;
        public string Description { get; set; } = default!;

        public AssignmentTask[] Tasks { get; set; } = default!;
        public int RewardType { get; set; } = default!;
        public int RewardAmount { get; set; } = default!;

        public int Flags { get; set; } = default!;
    }

}
