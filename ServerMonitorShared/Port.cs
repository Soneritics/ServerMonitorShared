using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerMonitorShared
{
    public abstract class Port
    {
        public abstract String Name { get; }
        public abstract int PortNumber { get; }
    }
}
