using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using NodeRoleContract;

namespace ClusterContract
{
    public interface INode
    {
        string Identity { get; set; }

        IPAddress IP { get; set; }

        string FQDN { get; set; }

        ICluster Cluster { get; set; }

        bool IsLeader { get; }

        INodeRole CurrentRole { get; set; }
        
        public void Initialize();

        public Task StartHeartbeatAsync(CancellationToken token);
        
        public Task StartLeaderElectionAsync();
    }
}
