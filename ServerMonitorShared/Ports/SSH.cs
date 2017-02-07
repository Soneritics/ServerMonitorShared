using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerMonitorShared.Ports
{
    class SSH : Port
    {
        public override string Name { get; } = "SSH";
        public override int PortNumber { get; } = 22;
    }
}
