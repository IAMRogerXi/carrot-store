using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarrotStoreMsgQ.ClusterContract;

namespace CarrotStoreMsgQ.Cluster
{
    internal class Cluster : ICluster
    {
        public INode[] Nodes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Initialize()
        {
            LoadDataFromMetaData();

            foreach (var node in Nodes)
            {
                node.Initialize();
            }

            if (!PingLeader())
            {
                // todo: load the cluster from metadata. however, the leader thinks this is not the correct data.
                ReloadMetaDataFromLeader();
                PersistsMetaData();
            }
        }

        private void LoadDataFromMetaData()
        {

        }

        private bool PingLeader()
        {
            return true;
        }

        private void ReloadMetaDataFromLeader()
        {

        }

        private void PersistsMetaData()
        {

        }
    }
}
