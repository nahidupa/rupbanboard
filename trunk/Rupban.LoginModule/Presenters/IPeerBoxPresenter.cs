using Rupban.Core;
using rupban.loginmodule.Views;

namespace Rupban.LoginModule.Presenters
{
    public interface IPeerBoxPresenter : ITemplateCelHolderPresenter
    {
        PeerBox PeerBox { get; set; }

          IPeerBoxView View { get; set; }
        void TicketDroped(Ticket ticket);
    }
}