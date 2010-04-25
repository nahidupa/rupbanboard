using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rupban.LoginModule.Controller;
using Rupban.LoginModule.Presenters;
using Rupban.LoginModule.Services;

namespace rupban.loginmodule.Commands
{
    public class LoginCommand :  ILoginCommand
    {
        private readonly ILoginService _loginService;
        private readonly ILoginController _loginController;

        public LoginCommand(ILoginService loginService,ILoginController loginController)
        {
            _loginService = loginService;
            _loginController = loginController;
        }

        public void Execute(object parameter)
        {
            string username = "";
            var logedIn = _loginService.LogOn(username);
            if (logedIn)
            {
                _loginController.LogedIn();
            }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
    }
}
