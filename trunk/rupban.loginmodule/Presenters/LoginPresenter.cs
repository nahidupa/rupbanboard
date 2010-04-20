using Microsoft.Practices.Composite.Presentation.Commands;
using Rupban.LoginModule.Controller;
using Rupban.LoginModule.Views;

namespace Rupban.LoginModule.Presenters
{
    public class LoginPresenter : ILoginPresenter
    {
        private ILoginController _loginController;

        public DelegateCommand<object> Command { get; set; }


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
