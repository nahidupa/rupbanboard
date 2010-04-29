using System;
using System.Collections.ObjectModel;
using System.Windows;
using Microsoft.Practices.Composite.Events;
using Microsoft.Practices.Composite.Regions;
using Rupban.Core;
using Rupban.LoginModule.Controller;
using Rupban.LoginModule.Data;
using Rupban.LoginModule.Services;
using Rupban.LoginModule.Views;
using Rupban.UI.Infrastructure.Event;

namespace Rupban.LoginModule.Presenters
{
    public class PanelColumnPresenter : DependencyObject,IPanelColumnPresenter
    {
        private readonly IPanelColumnController _panelColumnController;
        private readonly IPanelColumnService _panelColumnService;
        private readonly IEventAggregator _eventAggregator;


        public IPanelColumnView View
        {
            get;
            set;
        }

        public static readonly DependencyProperty TemplateColumnProperty = DependencyProperty.Register(
        "TemplateColumn",
        typeof(TemplateColumn),
        typeof(PanelColumnPresenter), new FrameworkPropertyMetadata(new PropertyChangedCallback(OnPropertyChanged)));

        private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            
        }

        public TemplateColumn TemplateColumn
        {
             get { return (TemplateColumn)GetValue(TemplateColumnProperty); }
            set { SetValue(TemplateColumnProperty, value); }
            
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
            var tergetId= this.TemplateColumn.Id;
            var templateColumn = BoardData.GetTemplateColumnByTicketId(ticket.Id);
            if (templateColumn!=null)
                _eventAggregator.GetEvent<TicketDropedEvent>().Publish(new TickedMoveEventArgs() { Ticket = ticket, SourceColumnId = templateColumn.Id, TargetColumnId = tergetId });
        }
    }
}