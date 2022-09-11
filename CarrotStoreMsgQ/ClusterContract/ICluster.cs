using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarrotStoreMsgQ.Server.NodeContract;

namespace CarrotStoreMsgQ.Server.ClusterContract
{
    public interface ICluster
    {
        INode[] Nodes { get; set; }

        public void Initialize();

        public INode FindNode();
    }
}
