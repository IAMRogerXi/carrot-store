using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageContract;

namespace CarrotStoreMsgQ.ClusterContract
{
    public interface IHeartbeatService
    {
        Task SendHeartbeatAsync(ICluster cluster, CancellationToken token);

        Task ReceiveHeartbeatAsync(IMessage controlMessage);

        Task MonitorAsync(Action failureCallback, CancellationToken token);
    }
}
