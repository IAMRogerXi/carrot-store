using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClusterContract;

namespace Cluster
{
    internal class LeaderNode : NodeBase
    {
        public LeaderNode(IHeartbeatService heartbeatService, ILeaderElectionService leaderElectionService) : base(heartbeatService, leaderElectionService)
        {
        }

        public override bool IsLeader => true;

        private Task ReplicateDataAsync()
        {
            throw new NotImplementedException();
        }
    }
}
