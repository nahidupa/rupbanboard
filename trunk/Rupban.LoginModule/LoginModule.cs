using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Composite.Modularity;
using Microsoft.Practices.Composite.Regions;
using Microsoft.Practices.Unity;
using rupban.loginmodule.Controller;
using Rupban.LoginModule.Controller;
using rupban.loginmodule.Presenters;
using Rupban.LoginModule.Presenters;
using Rupban.LoginModule.Services;
using rupban.loginmodule.Views;
using Rupban.LoginModule.Views;
using Rupban.UI.Infrastructure;

namespace Rupban.LoginModule
{
    public class LoginModule:IModule
    {
        private readonly IUnityContainer _container;
        private readonly IRegionManager _regionManager;

        public LoginModule(IUnityContainer container, IRegionManager regionManager)
        {
            _container = container;
            _regionManager = regionManager;
        }
        public void Initialize()
        {
            RegisterViewsAndServices();
            
            ILoginPresenter presenter = _container.Resolve<ILoginPresenter>();

            IRegion mainRegion = _regionManager.Regions[RegionNames.MainRegion];
            mainRegion.Add(presenter.View);
        }

        private void RegisterViewsAndServices()
        {
          
            _container.RegisterType(typeof(IAdminPanelController), typeof(AdminPanelController), true);
            _container.RegisterType(typeof(IAdminPanelView), typeof(AdminPanelView), true);
            _container.RegisterType(typeof(IAdminPanelPresenter), typeof(AdminPanelPresenter), true);

            _container.RegisterType(typeof(IProjectsController), typeof(ProjectsController), true);
            _container.RegisterType(typeof(IProjectsView), typeof(ProjectsView), true);
            _container.RegisterType(typeof(IProjectsPresenter), typeof(ProjectsPresenter), true);


            _container.RegisterType(typeof(IRupbanBoardController), typeof(RupbanBoardController), true);
            _container.RegisterType(typeof(IRupbanBoardView), typeof(RupbanBoardView), true);
            _container.RegisterType(typeof(IRupbanBoardPresenter), typeof(RupbanBoardPresenter), true);

            _container.RegisterType(typeof(ILoginService), typeof(LoginService), true);
            _container.RegisterType(typeof(IProjectService), typeof(ProjectService), true);
            _container.RegisterType(typeof(IRupbanBoardService), typeof(RupbanBoardService), true);

         
            _container.RegisterType(typeof(IPanelColumnController), typeof(PanelColumnController), true);
            _container.RegisterType(typeof(IPanelColumnView), typeof(PanelColumnView), false);
            _container.RegisterType(typeof(IPanelColumnPresenter), typeof(PanelColumnPresenter), false);
            _container.RegisterType(typeof(IPanelColumnService), typeof(PanelColumnService), true);
            


            _container.RegisterType(typeof(ILoginController), typeof(LoginController), true);
            _container.RegisterType(typeof(ILoginView), typeof(LoginView), true);
            _container.RegisterType(typeof(ILoginPresenter), typeof(LoginPresenter), true);

            _container.RegisterType(typeof(ITicketPresenter), typeof(TicketPresenter), false);
            _container.RegisterType(typeof(ITicketView), typeof(TicketView), false);
            _container.RegisterType(typeof(ITicketController), typeof(TicketController), true);

            
   

            

            
        }
    }
}
