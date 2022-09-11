using CarrotStoreMsgQ.Server.ClusterContract;

namespace CSClusterService.WorkerProcessor
{
    public class TimerJob : BackgroundService
    {
        private INode CurrentNode { get; }

        private ILogger Logger { get; }

        public TimerJob(INode node,
            ILogger logger)
        {
            CurrentNode = node;
            Logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await CurrentNode.StartHeartbeatAsync(stoppingToken);
        }
    }
}
