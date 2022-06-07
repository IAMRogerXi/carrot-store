using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClusterContract;
using MessageContract;

namespace ClusterContract
{
    public interface IHeartbeatService
    {
        void SendHeartbeatAsync(ICluster cluster, CancellationToken token);

        void ReceiveHeartbeatAsync(IMessage controlMessage);

        Task MonitorAsync(Action failureCallback, CancellationToken token);
    }
}
