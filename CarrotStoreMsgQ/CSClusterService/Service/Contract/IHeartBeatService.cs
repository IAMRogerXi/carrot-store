namespace CSClusterService.Service.Contract
{
    public interface IHeartbeatService
    {
        void SendHeartbeat();

        void ReceiveHeartbeat();
    }
}
