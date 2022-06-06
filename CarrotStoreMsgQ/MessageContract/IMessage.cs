using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MessageContract
{
    public interface IMessage
    {
        string MessageID { get; set; }
    }
}
