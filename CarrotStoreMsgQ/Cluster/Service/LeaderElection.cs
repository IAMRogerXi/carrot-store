using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cluster.Service
{
    internal class LeaderElection : ILeaderElectionService
    {
        /// <summary>
        /// Inform all available nodes about the coming election.
        /// </summary>
        public void SendElectionNotification()
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
    }
}
