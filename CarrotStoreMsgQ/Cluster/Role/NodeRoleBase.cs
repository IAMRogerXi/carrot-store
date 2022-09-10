﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarrotStoreMsgQ.ClusterContract;
using NodeRoleContract;

namespace Cluster.Role
{
    public abstract class NodeRoleBase : INodeRole
    {
        public NodeRoleBase(INode node)
        {

        }

        public void SwitchRole()
        {
            throw new NotImplementedException();
        }
    }
}
