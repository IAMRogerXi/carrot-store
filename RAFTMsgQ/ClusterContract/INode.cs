using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ClusterContract
{
    public interface INode
    {
        string Identity { get; set; }

        IPAddress IP { get; set; }

        string FQDN { get; set; }

        ICluster Cluseter { get; set; }

        bool IsLeader { get; }

        public Task AppendDataAsync<T>(T data);

        public Task StartLeaderElectionAsync();

        public void Initialize();
    }
}
