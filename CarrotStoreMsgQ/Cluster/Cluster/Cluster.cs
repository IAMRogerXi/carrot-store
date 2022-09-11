using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarrotStoreMsgQ.Server.ClusterContract;
using CarrotStoreMsgQ.Server.NodeContract;

namespace CarrotStoreMsgQ.Server
{
    public class Cluster : ICluster
    {
        public INode? Leader { get; set; }

        public INode[] Nodes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        /// <summary>
        /// Initialize the cluster basing on the ini file.
        /// ini file format:
        /// {
        ///     "leader":"ip or FQDN",
        ///     [
        ///         {
        ///             "server1":"ip or FQDN",
        ///         },
        ///         {
        ///             "server2":"ip or FQDN",
        ///         },
        ///         ...
        ///     ]
        /// }
        /// </summary>
        public void Initialize()
        {
            LoadDataFromMetaData();

            foreach (var node in Nodes)
            {
                node.Initialize(this);
            }

            if (!PingLeader())
            {
                // todo: load the cluster from metadata. however, the leader thinks this is not the correct data.
                ReloadMetaDataFromLeader();
                PersistsMetaData();
            }
        }

        public INode FindNode()
        {
            return null;
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
