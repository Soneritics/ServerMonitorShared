using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerMonitorShared.Ports
{
    class HTTPS : Port
    {
        public override string Name { get; } = "HTTPS";
        public override int PortNumber { get; } = 443;
    }
}
