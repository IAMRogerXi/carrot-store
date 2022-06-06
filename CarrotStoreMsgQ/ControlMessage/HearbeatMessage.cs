using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MessageContract;

namespace ControlMessage
{
    internal class HearbeatMessage : IMessage
    {
        public string MessageID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DateTime PingTimeStamp { get; }
    }
}
