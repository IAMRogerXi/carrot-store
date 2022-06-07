using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClusterContract;
using SvcClient;
using MessageContract;

namespace Cluster.Service
{
    internal class HeartbeatService : IHeartbeatService
    {
        IClient client;

        public HeartbeatService(IClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// If this node is the leader, send the heartbeat to all followers.
        /// </summary>
        /// <param name="cluster"></param>
        public void SendHeartbeatAsync(ICluster cluster, CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                foreach (var node in cluster.Nodes)
                {
                    // todo: prepare the http request.
                    client.PostAsync();
                }

                // todo: can i use other method to make the thread sleep?
                Thread.Sleep(10000);
            }
        }

        public void ReceiveHeartbeatAsync(IMessage controlMessage)
        {
            throw new NotImplementedException();
        }

        public Task MonitorAsync(Action failureCallback, CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                if (CheckHeartbeatRequest())
                {
                    // todo: can i use other method to make the thread sleep?
                    Thread.Sleep(10000);
                }
                else
                {
                    failureCallback();
                }
            }

            return null;
        }

        private bool CheckHeartbeatRequest()
        {
            // todo: check heartbeat time spin

            return true;
        }
    }
}
