using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helldivers2API.Data.Cache
{
    public interface IDataCache
    {
        public int Id { get; }
        public string Name { get; }
    }
}
