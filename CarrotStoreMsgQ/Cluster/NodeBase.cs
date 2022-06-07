using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using ClusterContract;
using NodeRoleContract;

namespace Cluster
{
    internal abstract class NodeBase : INode
    {
        private ICluster cluster;

        public ICluster Cluseter { get => cluster; set => throw new NotImplementedException(); }

        public abstract bool IsLeader { get; }

        public ILeaderElectionService leaderElectionSvc { get; set; }

        public string Identity { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public IPAddress IP { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string FQDN { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public INodeRole CurrentRole { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        protected NodeBase(ICluster cluster)
        {
            this.cluster = cluster;
        }

        public NodeBase(ICluster cluster,
            ILeaderElectionService leaderElectionSvc)
        {
            this.cluster = cluster;
            this.leaderElectionSvc = leaderElectionSvc;
        }

        public void Initialize()
        {
            throw new NotImplementedException();
        }

        public abstract Task AppendDataAsync<T>(T data);

        public Task StartLeaderElectionAsync()
        {
            leaderElectionSvc.SendElectionNotification(this.Cluseter);
            leaderElectionSvc.Vote();

            return null;
        }
    }
}
