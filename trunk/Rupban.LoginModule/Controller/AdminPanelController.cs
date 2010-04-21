using System;
using Microsoft.Practices.Composite.Regions;
using Microsoft.Practices.Unity;
using Rupban.LoginModule.Presenters;
using Rupban.UI.Infrastructure;


namespace Rupban.LoginModule.Controller
{
    public class AdminPanelController : IAdminPanelController
    {
        private readonly IRegionManager _regionManager;
        private readonly IUnityContainer _container;
        private readonly IProjectsPresenter _projectsPresenter;

        public AdminPanelController(IRegionManager regionManager, IUnityContainer container)
        {
            _regionManager = regionManager;
            _container = container;
             _projectsPresenter = container.Resolve<IProjectsPresenter>();
        }

      
        public void OnProjectList()
        {
            var shellRegion = _regionManager.Regions[RegionNames.MainRegion];
            shellRegion.Add(_projectsPresenter.View);
            shellRegion.Activate(_projectsPresenter.View);
        }
    }
}