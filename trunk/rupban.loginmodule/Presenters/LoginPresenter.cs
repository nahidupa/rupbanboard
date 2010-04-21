﻿using System;
using System.Windows.Input;
using Microsoft.Practices.Composite.Presentation.Commands;
using Rupban.LoginModule.Controller;
using Rupban.LoginModule.Services;
using Rupban.LoginModule.Views;

namespace Rupban.LoginModule.Presenters
{
    public class LoginPresenter : ILoginPresenter
    {
        private ILoginController _loginController;
        private ILoginModuleService _loginModuleService;

        public ICommand LoginCommand { get; set; }


        public LoginPresenter(ILoginView view,ILoginController loginController,ILoginModuleService loginModuleService)
        {
            _loginModuleService = loginModuleService;
            _loginController = loginController;
            View = view;
            View.SetModel(this);
            LoginCommand=new  DelegateCommand<object>(Login);
        }

        private  void Login(object obj)
        {
            string username="";
            var logedIn = _loginModuleService.LogOn(username);
            if (logedIn)
            {
                _loginController.LogedIn();
            }
        }

        public ILoginView View
        {
            get ;
            set ; 
        }
    }
}
