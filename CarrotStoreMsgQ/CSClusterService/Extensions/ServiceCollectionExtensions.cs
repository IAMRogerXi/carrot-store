namespace CSClusterService.Extensions
{
    // why i can't put the namespace at the top level?
    using CarrotStoreMsgQ.Server;
    using CarrotStoreMsgQ.Server.ClusterContract;
    using CSClusterService.WorkerProcessor;

    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddServerInstance(this IServiceCollection serviceCollection)
        {
            serviceCollection.AddSingleton<Cluster>();

            return serviceCollection;
        }

        public static IServiceCollection AddHostedServices(this IServiceCollection serviceCollection)
            => serviceCollection.AddHostedService<TimerJob>();
    }
}
