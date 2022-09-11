using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarrotStoreMsgQ.Payload.MessageContract;

namespace ControlMessage
{
    internal class LeaderElectionMessage : IMessage
    {
        public string MessageID { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public DateTime VotingTimeStamp { get; }
    }
}
