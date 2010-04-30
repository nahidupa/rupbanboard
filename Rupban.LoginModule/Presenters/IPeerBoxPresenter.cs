using Rupban.Core;
using rupban.loginmodule.Views;

namespace Rupban.LoginModule.Presenters
{
    public interface IPeerBoxPresenter 
    {
        PeerBox PeerBox { get; set; }
        IPeerBoxView View { get; set; }
        void TicketDroped(Ticket ticket);
        void RemoveTicket(string ticketId);
    }
}