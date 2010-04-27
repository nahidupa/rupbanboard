using Rupban.Core;

namespace Rupban.LoginModule.Services
{
    public interface ITicketService

    {
        void MoveTicket(string ticketId, string currentColumnName, string destinationColumnName);
        void ViewTicketHistory();
        void PickTicket();
    }
}