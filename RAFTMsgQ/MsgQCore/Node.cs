using System;
using System.Collections.Generic;
using System.Net;

namespace CarrotStore.MsgQCore
{
    public class Node
    {
        private Dictionary<IPAddress, string> _nodeList = null;

        public Guid Identity { get; private set; }
        
        public string Name { get; private set; }

        public IPAddress IP { get; private set; }

        public Guid Leader { get; private set; }

        public Node()
        {
            this._nodeList = new Dictionary<IPAddress, string>();
        }

        public void Initialize()
        {

        }

        public void RequestVote()
        {

        }

        public void AppendEntries()
        {

        }

        public object GetKeys()
        {
            return null;
        }

        public object GetItem(object key)
        {
            return null;
        }

        public void AddItem(object key, object value)
        {

        }

        public void SetItem(object key, object value)
        {

        }
    }
}
