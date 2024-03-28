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
    /// Contains information about the current assignment (contains the Major Order).
    /// </summary>
    public class Assignment
    {
        public long Id { get; set; } = default!;

        /// <summary>
        /// Seconds remaining before order is over
        /// </summary>
        public long ExpiresIn { get; set; } = default!; 
        
        /// <summary>
        /// List of progress associated to each Task (have only observed 1 value)
        /// </summary>
        public int[] Progress { get; set; } = default!;

        /// <summary>
        /// Type of assignment.  
        /// 4 appears to be the Major Order.  Other values are unknown.
        /// </summary>
        /// <remarks>4 is MajorOrder</remarks>
        public int Type { get; set; } = default!;

        /// <summary>
        /// True if this assignment is a major order.
        /// </summary>
        public bool IsMajorOrder { get => Type == 4; }

        /// <summary>
        /// Assignment title
        /// </summary>
        public string Title { get; set; } = default!;

        /// <summary>
        /// Long description of the order
        /// </summary>
        public string Brief { get; set; } = default!;

        /// <summary>
        /// Short description of the order
        /// </summary>
        public string Description { get; set; } = default!;

        /// <summary>
        /// List of the tasks associated with this order
        /// </summary>
        public AssignmentTask[] Tasks { get; set; } = default!;

        /// <summary>
        /// Reward types - 1 is Medals, haven't observed others
        /// </summary>
        public int RewardType { get; set; } = default!;

        /// <summary>
        /// Amount to be awarded if successful
        /// </summary>
        public int RewardAmount { get; set; } = default!;

        /// <summary>
        /// Unknown
        /// </summary>
        public int Flags { get; set; } = default!;
    }


    /// <summary>
    /// Contains information about the current assignment tasks.
    /// </summary>
    public class AssignmentTask
    {
        /// <summary>
        /// TODO: Research needed
        /// </summary>
        public int Type { get; set; } = default!;

        /// <summary>
        /// Planet ids associated with this task.
        /// ALways appears to include 1.
        /// </summary>
        public int[] Values { get; set; } = default!;       

        /// <summary>
        /// TODO: Research needed
        /// </summary>
        public int[] ValueTypes { get; set; } = default!;
    }
}
