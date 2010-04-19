using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using rupban.loginmodule.Controller;
using rupban.loginmodule.Views;

namespace rupban.loginmodule.Presenters
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
