using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClusterContract;

namespace Cluster.ServiceContract
{
    public interface IHeartbeatService
    {
        void SendHeartbeat(ICluster cluster);

        void ReceiveHeartbeat();
    }
}
