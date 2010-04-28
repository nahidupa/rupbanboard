using System;
using Microsoft.Practices.Composite.Events;
using Microsoft.Practices.Composite.Regions;
using Microsoft.Practices.Unity;
using Rupban.Core;
using rupban.loginmodule.Presenters;
using Rupban.UI.Infrastructure;
using Rupban.UI.Infrastructure.Event;

namespace Rupban.LoginModule.Controller
{
    public class PanelColumnController : IPanelColumnController
    {
        private readonly IRegionManager _regionManager;
        private readonly IUnityContainer _container;
        private IRegionManager _localRegionManager;
        private IRupbanBoardController _rupbanBoardController;
        private readonly IEventAggregator _eventAggregator;

        public PanelColumnController(IRegionManager regionManager, IUnityContainer container, IRupbanBoardController rupbanBoardController, IEventAggregator eventAggregator)
        {
            _rupbanBoardController = rupbanBoardController;
            _eventAggregator = eventAggregator;
            _regionManager = regionManager;
            _container = container;
            _eventAggregator.GetEvent<TicketDropedEvent>().Subscribe(TicketDroped);
        }
        public void LoadBoardTicketView(TemplateRow row, IRegionManager localRegionManager)
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

        


        public void TicketDroped(TickedMoveEventArgs tickedMoveEventArgs)
        {
            if (tickedMoveEventArgs.Tiket != null)
            {
                Ticket ticket = tickedMoveEventArgs.Tiket;
                var region = _localRegionManager.Regions[RegionNames.TicketRegion];
                var ticketPresenter = _container.Resolve<ITicketPresenter>();
                ticketPresenter.Ticket = ticket;
                region.Add(ticketPresenter.View, ticket.Title);
            }
        }
    }
}