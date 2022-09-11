using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarrotStoreMsgQ.Server.ClusterContract
{
    public interface ICluster
    {
        INode[] Nodes { get; set; }

        public void Initialize();
    }
}
