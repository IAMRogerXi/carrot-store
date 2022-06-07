using ClusterContract;

namespace CSClusterService.WorkerProcessor
{
    public class TimerJob : BackgroundService
    {
        ICluster currentCluster;

        INode currentNode;

        IHeartbeatService heartbeatService;

        public TimerJob(ICluster cluster, INode node, IHeartbeatService heartbeatService)
        {
            this.currentCluster = cluster;
            this.currentNode = node;
            this.heartbeatService = heartbeatService;
        }

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            if (currentNode.IsLeader)
            {
                heartbeatService.SendHeartbeatAsync(currentCluster, stoppingToken);
            }
            else
            {
                heartbeatService.MonitorAsync(null, stoppingToken);
            }

            return null;
        }
    }
}
