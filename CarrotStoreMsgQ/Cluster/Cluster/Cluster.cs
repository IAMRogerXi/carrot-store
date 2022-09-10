﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarrotStoreMsgQ.ClusterContract;
using ClusterContract;

namespace Cluster.Cluster
{
    internal class Cluster : ICluster
    {
        public INode[] Nodes { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Initialize()
        {
            foreach (var node in Nodes)
            {
                node.Initialize();
            }
        }
    }
}
