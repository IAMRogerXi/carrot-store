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
        public override bool IsLeader => true;

        public LeaderNode(ICluster cluster) : base(cluster)
        {
        }

        public override Task AppendDataAsync<T>(T data)
        {
            throw new NotImplementedException();
        }

        private Task ReplicateDataAsync()
        {
            throw new NotImplementedException();
        }
    }
}
