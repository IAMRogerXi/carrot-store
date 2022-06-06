namespace CSClusterService.Service.Contract
{
    public interface IHeartBeatService
    {
        void SendHeartBeat();

        void ReceiveHeartBeat();
    }
}
