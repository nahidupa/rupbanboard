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
        private IRegionManager _localRegionManager;

        public PanelColumnController(IRegionManager regionManager, IUnityContainer container)
        {
            _regionManager = regionManager;
            _container = container;
        }
        public void LoadBoardTicketView(TemplateRow row,IRegionManager localRegionManager)
        {
            _localRegionManager = localRegionManager;

            var region = localRegionManager.Regions[RegionNames.TicketRegion];
              foreach (var ticket in row.GetAllTickets())
              {
                  var ticketPresenter = _container.Resolve<ITicketPresenter>();
                  ticketPresenter.Ticket = ticket;
                  region.Add(ticketPresenter.View, ticket.Title);
              }
        }

        public void TicketDroped(Ticket ticket)
        {
            var region = _localRegionManager.Regions[RegionNames.TicketRegion];
            var ticketPresenter = _container.Resolve<ITicketPresenter>();
            ticketPresenter.Ticket = ticket;
            region.Add(ticketPresenter.View, ticket.Title);
        }
    }
}