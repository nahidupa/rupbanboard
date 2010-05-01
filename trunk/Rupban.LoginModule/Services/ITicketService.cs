using Rupban.Core;

namespace Rupban.LoginModule.Services
{
    public interface ITicketService

    {
        void MoveTicket(Ticket ticket, string sourceId, string targetId);
        void ViewTicketHistory();
        void PickTicket();
    }
}