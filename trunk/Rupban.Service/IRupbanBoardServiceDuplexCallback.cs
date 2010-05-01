using System.ServiceModel;
using Rupban.Core;

namespace Rupban.Service
{
    public interface IRupbanBoardServiceDuplexCallback
    {
        [OperationContract(IsOneWay = true)]
        void TicketMoved(Ticket ticket, string sourceId, string targetId);

    }
}