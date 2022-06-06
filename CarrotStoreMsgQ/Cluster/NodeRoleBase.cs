using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClusterContract;
using NodeRoleContract;

namespace Cluster
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
