using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;

namespace Rupban.Core
{
     [DataContract]
    public enum ColumnType
    {
         [EnumMember]
         TicketHolderColumn=0,
         [EnumMember]
         PeerBoxHolderColumn = 1,
    }
}
