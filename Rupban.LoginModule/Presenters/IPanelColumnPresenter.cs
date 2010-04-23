using Microsoft.Practices.Composite.Regions;
using Rupban.Core;
using Rupban.LoginModule.Views;

namespace Rupban.LoginModule.Presenters
{
    public interface IPanelColumnPresenter
    {
        IPanelColumnView View { get; set; }
        TemplateColumn TemplateColumn { get; set; }
        void LoadTicketView(IRegionManager dictionary);
    }
}