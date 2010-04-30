using Microsoft.Practices.Composite.Regions;
using Rupban.Core;
using Rupban.LoginModule.Views;

namespace Rupban.LoginModule.Presenters
{
    public interface IPanelColumnPresenter:IColumnPresenter
    {
        IPanelColumnView View { get; set; }
       
        void LoadTicketView(IRegionManager dictionary);
    }
}