namespace CSClusterService.WorkerProcessor
{
    using CarrotStoreMsgQ.Server;
    using CarrotStoreMsgQ.Server.ClusterContract;
    using CarrotStoreMsgQ.Server.NodeContract;

    public class TimerJob : BackgroundService
    {
        private ICluster Cluster { get; }

        private INode CurrentNode { get; }

        //private ILogger Logger { get; }

        public TimerJob(Cluster cluster)
        {
            Cluster = cluster;
            //Logger = logger;
            CurrentNode = Cluster.FindNode();
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            await CurrentNode.SendHeartbeatAsync(stoppingToken);
        }
    }
}
