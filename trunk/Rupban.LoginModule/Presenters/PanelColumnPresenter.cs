using Rupban.LoginModule.Controller;
using Rupban.LoginModule.Services;
using Rupban.LoginModule.Views;

namespace Rupban.LoginModule.Presenters
{
    public class PanelColumnPresenter : IPanelColumnPresenter
    {
        public IPanelColumnView View
        {
            get;
            set;
        }
        public PanelColumnPresenter(IPanelColumnView view, IPanelColumnController loginController, IPanelColumnService loginService)
        {
            View = view;
            View.SetModel(this);
        }
    }
}