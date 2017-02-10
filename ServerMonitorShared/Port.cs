using System;
using System.Runtime.Serialization;

namespace ServerMonitorShared
{
    [DataContract]
    public abstract class Port
    {
        public abstract String Name { get; }
        public abstract int PortNumber { get; }
    }
}
