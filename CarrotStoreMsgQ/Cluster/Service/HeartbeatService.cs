using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cluster.ServiceContract;
using ClusterContract;

namespace Cluster.Service
{
    internal class HeartbeatService : IHeartbeatService
    {
        public void ReceiveHeartbeat()
        {
            throw new NotImplementedException();
        }

        public void SendHeartbeat(ICluster cluster)
        {
            throw new NotImplementedException();
        }
    }
}
