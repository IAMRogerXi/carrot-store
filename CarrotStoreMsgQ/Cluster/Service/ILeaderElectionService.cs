using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClusterContract;

namespace Cluster.Service
{
    internal interface ILeaderElectionService
    {
        public void SendElectionNotification(ICluster cluster);

        public void Vote();

        public void ProcessVoteResult();

        public void CompleteElection();
    }
}
