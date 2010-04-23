using Rupban.Core;
using Rupban.LoginModule.Views;

namespace Rupban.LoginModule.Presenters
{
    public interface IPanelColumnPresenter
    {
        IPanelColumnView View { get; set; }
        void LoadBoardTicket(TemplateRow row);
    }
}