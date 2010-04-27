using System.Runtime.Serialization;
namespace Rupban.Core
{
    [DataContract]
    public enum TicketPriority
    {
        [EnumMember]
        Low = 0,
        [EnumMember]
        Hight = 5
    }
}