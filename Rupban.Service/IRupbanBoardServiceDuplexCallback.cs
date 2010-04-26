using System.ServiceModel;

namespace Rupban.Service
{
    public interface IRupbanBoardServiceDuplexCallback
    {
        [OperationContract(IsOneWay = true)]
        void TicketMoved();

    }
}