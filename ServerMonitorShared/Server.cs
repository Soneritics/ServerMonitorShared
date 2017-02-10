using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace ServerMonitorShared
{
    [DataContract]
    public class Server
    {
        public String IP { get; set; }
        public String Name { get; set; }
        public List<Port> Ports { get; }  = new List<Port>();

        public Server(String IP, String Name)
        {
            this.IP = IP;
            this.Name = Name;
        }
    }
}
