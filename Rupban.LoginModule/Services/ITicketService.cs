using Rupban.Core;

namespace Rupban.LoginModule.Services
{
    public interface ITicketService

    {
        void MoveTicket(Ticket ticket, string currentColumnName, string destinationColumnName);
        void ViewTicketHistory();
        void PickTicket();
    }
}