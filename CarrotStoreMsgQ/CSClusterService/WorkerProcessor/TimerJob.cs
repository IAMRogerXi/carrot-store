using ClusterContract;

namespace CSClusterService.WorkerProcessor
{
    public class TimerJob : BackgroundService
    {
        private ICluster CurrentCluster { get; }

        private INode CurrentNode { get; }

        private ILogger Logger { get; }

        public TimerJob(ICluster cluster,
            INode node,
            ILogger logger)
        {
            CurrentCluster = cluster;
            CurrentNode = node;
            Logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await CurrentNode.StartHeartbeatAsync(stoppingToken);
        }
    }
}
