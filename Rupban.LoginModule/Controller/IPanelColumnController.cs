using Microsoft.Practices.Composite.Regions;
using Rupban.Core;

namespace Rupban.LoginModule.Controller
{
    public interface IPanelColumnController
    {
        void LoadBoardTicketView(TemplateRow row, IRegionManager localRegionManager);
        void TicketDroped(Ticket ticket);
    }
}