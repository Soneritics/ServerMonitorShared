using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerMonitorShared.Ports
{
    class POP3 : Port
    {
        public override string Name { get; } = "POP3";
        public override int PortNumber { get; } = 110;
    }
}
