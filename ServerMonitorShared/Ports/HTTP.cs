using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerMonitorShared.Ports
{
    class HTTP : Port
    {
        public override string Name { get; } = "HTTP";
        public override int PortNumber { get; } = 80;
    }
}
