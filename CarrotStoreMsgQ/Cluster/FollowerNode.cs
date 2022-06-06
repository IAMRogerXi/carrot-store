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
        public override bool IsLeader => false;

        public FollowerNode(ICluster cluster) : base(cluster)
        {
        }

        public override Task AppendDataAsync<T>(T data)
        {
            throw new NotImplementedException();
        }

        private Task ForwardRequest<T>(T data)
        {
            throw new NotImplementedException();
        }
    }
}
