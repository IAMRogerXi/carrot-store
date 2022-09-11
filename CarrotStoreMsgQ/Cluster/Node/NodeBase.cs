using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using CarrotStoreMsgQ.Server.NodeContract;
using CarrotStoreMsgQ.Server.ClusterContract;
using NodeRoleContract;

namespace CarrotStoreMsgQ.Server
{
    public abstract class NodeBase : INode
    {
        public string Identity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IPAddress IP { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string FQDN { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public INodeRole CurrentRole { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public ICluster Cluster { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public abstract bool IsLeader { get; }

        public int HeartbeatTimeout { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IHeartbeatService HeartbeatService { get; }

        public ILeaderElectionService LeaderElectionService { get; }

        public NodeBase(IHeartbeatService heartbeatService,
            ILeaderElectionService leaderElectionService)
        {
            LeaderElectionService = leaderElectionService;
            HeartbeatService = heartbeatService;
        }

        public void Initialize(ICluster cluster)
        {
            this.Cluster = cluster;
        }

        public async Task StartLeaderElectionAsync()
        {
            LeaderElectionService.SendElectionNotification(Cluster);
            LeaderElectionService.Vote();
        }

        public async Task ReceiveHeartbeatAsync()
        {
            // need a timespam here.
            if (HeartbeatTimeout > 0)
            {
                await StartLeaderElectionAsync();
            }
        }

        public async Task SendHeartbeatAsync(CancellationToken token)
        {
            if (IsLeader)
            {
                await HeartbeatService.SendHeartbeatAsync(Cluster, token);
            }
            else
            {
                // await HeartbeatService.MonitorAsync(this.StartLeaderElectionAsync, token);
                await HeartbeatService.MonitorAsync(LeaderElectionService.StartElection, token);
            }
        }
    }
}
