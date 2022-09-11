using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using NodeRoleContract;
using CarrotStoreMsgQ.Server.ClusterContract;

namespace CarrotStoreMsgQ.Server.NodeContract
{
    public interface INode
    {
        string Identity { get; set; }

        IPAddress IP { get; set; }

        string FQDN { get; set; }

        ICluster Cluster { get; set; }

        bool IsLeader { get; }

        INodeRole CurrentRole { get; set; }

        int HeartbeatTimeout { get; set; }

        public void Initialize(ICluster cluster);

        public Task SendHeartbeatAsync(CancellationToken token);

        public Task ReceiveHeartbeatAsync();

        public Task StartLeaderElectionAsync();
    }
}
