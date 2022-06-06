using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cluster.Service
{
    internal interface ILeaderElectionService
    {
        public void SendElectionNotification();

        public void Vote();
    }
}
