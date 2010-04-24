using System;
using Microsoft.Practices.Composite.Regions;
using Microsoft.Practices.Unity;
using Rupban.LoginModule.Presenters;
using Rupban.UI.Infrastructure;

namespace Rupban.LoginModule.Controller
{
    public class ProjectsController : IProjectsController
    {
        private readonly IRegionManager _regionManager;
        private readonly IUnityContainer _container;
        private IRupbanBoardPresenter _rupbanBoardPresenter;
        public ProjectsController(IRegionManager regionManager, IUnityContainer container)
        {
            _regionManager = regionManager;
            _container = container;
            _rupbanBoardPresenter = container.Resolve<IRupbanBoardPresenter>();
        
        }

        public void ViewRupbanBoard()
        {
            var shellRegion = _regionManager.Regions[RegionNames.MainRegion];
            shellRegion.Add(_rupbanBoardPresenter.View);
            shellRegion.Activate(_rupbanBoardPresenter.View);
            _rupbanBoardPresenter.LoadBorad();

            
        }
    }
}