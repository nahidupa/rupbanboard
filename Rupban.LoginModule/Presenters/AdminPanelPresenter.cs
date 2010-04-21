using System;
using System.Windows.Input;
using Microsoft.Practices.Composite.Presentation.Commands;
using Rupban.LoginModule.Controller;
using Rupban.LoginModule.Views;

namespace Rupban.LoginModule.Presenters
{
    public class AdminPanelPresenter : IAdminPanelPresenter
    {
        private IAdminPanelController _adminPanelController;
        public ICommand ViewProjectListCommand { get; set; }
        public ICommand ViewRupbanBoardCommand { get; set; }

        

        public AdminPanelPresenter(IAdminPanelView view, IAdminPanelController adminPanelController)
        {
            _adminPanelController = adminPanelController;
            View = view;
            View.SetModel(this);
            ViewProjectListCommand = new DelegateCommand<object>(GetProjectList);

            ViewRupbanBoardCommand = new DelegateCommand<object>(ViewRupbanBoard);
        }

        private void ViewRupbanBoard(object obj)
        {
            _adminPanelController.ViewRupbanBoard();
        }

        private void GetProjectList(object obj)
        {
            _adminPanelController.OnProjectList();
        }

        public IAdminPanelView View
        {
            get;
            set;
        }
    }
}