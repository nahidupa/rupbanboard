using System;
using Rupban.LoginModule.Controller;
using Rupban.LoginModule.Services;
using Rupban.LoginModule.Views;

namespace Rupban.LoginModule.Presenters
{
    public class RupbanBoardPresenter: IRupbanBoardPresenter
    {
        private readonly IRupbanBoardController _loginController;
        private readonly IRupbanBoardService _loginService;

        public RupbanBoardPresenter(IRupbanBoardView view, IRupbanBoardController loginController, IRupbanBoardService loginService)
        {
            _loginController = loginController;
            _loginService = loginService;
            View = view;
            View.SetModel(this);
        
        }

        public IRupbanBoardView View
        {
            get; set;
        }
    }
}