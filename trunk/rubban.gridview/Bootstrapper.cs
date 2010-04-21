using System.Windows;
using Microsoft.Practices.Composite.Modularity;
using Microsoft.Practices.Composite.UnityExtensions;
using Rupban.LoginModule;

namespace Rubban.WPFWebView
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            Shell shell = this.Container.Resolve<Shell>();
            shell.Show();
            return shell;
        }

        protected override void InitializeModules()
        {
            IModule loginModule = this.Container.Resolve<LoginModule>();
            loginModule.Initialize();

           
        }
    }
}
