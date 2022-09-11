using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarrotStoreMsgQ.Server.ClusterContract;
using CarrotStoreMsgQ.Server.NodeContract;
using CarrotStoreMsgQ.SvcClient.SvcClientContract;

namespace CarrotStoreMsgQ.Server.Service
{
    internal class LeaderElectionService : ILeaderElectionService
    {
        IClient svcClient;
        List<INode> availableNodes = new List<INode>();

        public LeaderElectionService(IClient svcClient)
        {
            this.svcClient = svcClient;
        }

        public void StartElection()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Inform all available nodes about the coming election.
        /// </summary>
        public void SendElectionNotification(ICluster cluster)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Send vote information to all available nodes.
        /// </summary>
        public void Vote()
        {
            throw new NotImplementedException();
        }

        public void ProcessVoteResult()
        {
            throw new NotImplementedException();
        }

        public void CompleteElection()
        {
            throw new NotImplementedException();
        }
    }
}
