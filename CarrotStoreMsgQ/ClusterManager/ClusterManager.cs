using System;
using System.Collections.Generic;
using System.Net;

namespace CarrotStore.ClusterManager
{
    class ClusterManager
    {
        private Dictionary<IPAddress, string> _nodeList = new Dictionary<IPAddress, string>();

        static void Main(string[] args)
        {
            
        }

        public void Initialize()
        {
            if (_nodeList.Count < 3)
                return;

            // call init API in each node
        }

        public void AddServer(IPAddress ip, string serverName)
        {
            _nodeList.Add(ip, serverName);
        }

        public void RemoveServer(IPAddress ip)
        {
            _nodeList.Remove(ip);
        }
    }
}
