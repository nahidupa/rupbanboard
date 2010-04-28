using System;
using System.Collections.ObjectModel;
using Microsoft.Practices.Composite.Events;
using Microsoft.Practices.Composite.Regions;
using Rupban.Core;
using Rupban.LoginModule.Controller;
using Rupban.LoginModule.Services;
using Rupban.LoginModule.Views;
using Rupban.UI.Infrastructure.Event;

namespace Rupban.LoginModule.Presenters
{
    public class PanelColumnPresenter : IPanelColumnPresenter
    {
        private readonly IPanelColumnController _panelColumnController;
        private readonly IPanelColumnService _panelColumnService;
        private readonly IEventAggregator _eventAggregator;


        public IPanelColumnView View
        {
            get;
            set;
        }

        public TemplateColumn TemplateColumn
        {
            get ; 
            set ;
        }


        public void LoadTicketView(IRegionManager regionManager)
        {
            var rows = TemplateColumn.GetRows();
            foreach (var templateRow in rows)
            {
                _panelColumnController.LoadBoardTicketView(templateRow, regionManager);
            }
           
        }


        public PanelColumnPresenter(IPanelColumnView view, IPanelColumnController panelColumnController, IPanelColumnService panelColumnService, IEventAggregator eventAggregator)
        {
            _panelColumnController = panelColumnController;
            _panelColumnService = panelColumnService;
            _eventAggregator = eventAggregator;
            View = view;
            View.SetModel(this);
           
        }


        public void TicketDroped(Ticket ticket)
        {
            _eventAggregator.GetEvent<TicketDropedEvent>().Publish(new TickedMoveEventArgs() { Tiket = ticket});
        }
    }
}