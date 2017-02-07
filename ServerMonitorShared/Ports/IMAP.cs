using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerMonitorShared.Ports
{
    class IMAP : Port
    {
        public override string Name { get; } = "IMAP";
        public override int PortNumber { get; } = 143;
    }
}
