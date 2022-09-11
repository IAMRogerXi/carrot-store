using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarrotStoreMsgQ.Server.ClusterContract;

namespace CarrotStoreMsgQ.Server
{
    public class Node : NodeBase
    {
        public Node(IHeartbeatService heartbeatService, ILeaderElectionService leaderElectionService)
            : base(heartbeatService, leaderElectionService)
        {
        }

        public override bool IsLeader => false;
    }
}
