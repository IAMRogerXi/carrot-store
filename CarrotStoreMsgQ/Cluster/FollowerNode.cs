using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClusterContract;

namespace Cluster
{
    internal class FollowerNode : NodeBase
    {
        public FollowerNode(IHeartbeatService heartbeatService, ILeaderElectionService leaderElectionService) : base(heartbeatService, leaderElectionService)
        {
        }

        public override bool IsLeader => false;

        private Task ForwardRequest<T>(T data)
        {
            throw new NotImplementedException();
        }
    }
}
