﻿using Helldivers2API.Data.Cache;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helldivers2API.Data.Models.Interfaces
{
    public interface IEnvironment : IDataCache
    {
        public new string Name { get; }
        public string Description { get; }
    }
}
