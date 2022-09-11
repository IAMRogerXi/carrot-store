using CarrotStoreMsgQ.Payload.MessageContract;
using CarrotStoreMsgQ.Server.ClusterContract;
using SvcClient;

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
        public async Task SendHeartbeatAsync(ICluster cluster, CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                //foreach (var node in cluster.Nodes)
                {
                    // todo: prepare the http request.
                    //client.PostAsync();
                }

                // todo: can i use other method to make the thread sleep?
                await Task.Delay(10000);
            }
        }

        public async Task ReceiveHeartbeatAsync(IMessage controlMessage)
        {
            throw new NotImplementedException();
        }

        public async Task MonitorAsync(Action failureCallback, CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                if (CheckHeartbeatRequest())
                {
                    // todo: can i use other method to make the thread sleep?
                    await Task.Delay(10000);
                }
                else
                {
                    failureCallback();
                }
            }
        }

        private bool CheckHeartbeatRequest()
        {
            // todo: check heartbeat time spin

            return true;
        }
    }
}
