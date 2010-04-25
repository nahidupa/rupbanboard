using System;
using System.Windows.Input;
using Microsoft.Practices.Composite.Presentation.Commands;
using rupban.loginmodule.Commands;
using Rupban.LoginModule.Controller;
using Rupban.LoginModule.Services;
using Rupban.LoginModule.Views;

namespace Rupban.LoginModule.Presenters
{
    public class LoginPresenter : ILoginPresenter
    {
        public ICommand LoginCommand { get; set; }


        public LoginPresenter(ILoginView view, ILoginCommand loginCommand)
        {
            View = view;
            View.SetModel(this);
            LoginCommand = loginCommand;
        }

        public ILoginView View
        {
            get ;
            set ; 
        }
    }
}
