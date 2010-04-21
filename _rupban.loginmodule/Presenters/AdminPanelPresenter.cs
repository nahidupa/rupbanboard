using Rupban.LoginModule.Controller;
using Rupban.LoginModule.Views;

namespace Rupban.LoginModule.Presenters
{
    public class AdminPanelPresenter : IAdminPanelPresenter
    {
        private IAdminPanelController _adminPanelController;

        public AdminPanelPresenter(IAdminPanelView view, IAdminPanelController adminPanelController)
        {
            _adminPanelController = adminPanelController;
            View = view;
        }

        public IAdminPanelView View
        {
            get;
            set;
        }
    }
}