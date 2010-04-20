using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Rupban.LoginModule.Controller;
using Rupban.LoginModule.Views;

namespace Rupban.LoginModule.Presenters
{
    public class LoginPresenter : ILoginPresenter
    {
        private ILoginController _loginController;

        public LoginPresenter(ILoginView view,ILoginController loginController)
        {
            _loginController = loginController;
            View = view;
        }

        public ILoginView View
        {
            get ;
            set ; 
        }
    }
}
