using System;
using Microsoft.Practices.Composite.Regions;
using Microsoft.Practices.Unity;
using Rupban.Core;
using rupban.loginmodule.Presenters;
using Rupban.UI.Infrastructure;

namespace Rupban.LoginModule.Controller
{
    public class PanelColumnController : IPanelColumnController
    {
         private readonly IRegionManager _regionManager;
        private readonly IUnityContainer _container;

        public PanelColumnController(IRegionManager regionManager, IUnityContainer container)
        {
            _regionManager = regionManager;
            _container = container;
        }
        public void LoadBoardTicketView(TemplateRow row,IRegionManager localRegionManager)
        {

            var region = localRegionManager.Regions[RegionNames.TicketRegion];
              foreach (var ticket in row.GetAllTickets())
              {
                  var ticketPresenter = _container.Resolve<ITicketPresenter>();
                  region.Add(ticketPresenter.View, ticket.Title.ToString());
              }
        }
    }
}