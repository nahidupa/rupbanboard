using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Practices.Composite.Regions;
using Microsoft.Practices.Unity;
using Rupban.LoginModule.Presenters;
using Rupban.UI.Infrastructure;

namespace Rupban.LoginModule.Controller
{
    public class LoginController : ILoginController
    {
        private readonly IRegionManager _regionManager;
        private readonly IUnityContainer _container;
        private IAdminPanelPresenter _adminPanelPresenter;
        public LoginController(IRegionManager regionManager, IUnityContainer container)
        {
            _regionManager = regionManager;
            _container = container;
            _adminPanelPresenter = container.Resolve<IAdminPanelPresenter>();
        }

        public void LogedIn()
        {
            var shellRegion = _regionManager.Regions[RegionNames.MainRegion];
            shellRegion.Add(_adminPanelPresenter.View);
            shellRegion.Activate(_adminPanelPresenter.View);
        }
    }
}