using System.Runtime.Serialization;
namespace Rupban.Core
{
    [DataContract]
    public enum TicketStatus
    {
         [EnumMember]
        InBackBlog,
         [EnumMember]
        InProgress,
         [EnumMember]
        Done,
    }
}