using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClusterContract
{
    public interface ICluster
    {
        INode[] Nodes { get; set; }

        public void Initialize();
    }
}
