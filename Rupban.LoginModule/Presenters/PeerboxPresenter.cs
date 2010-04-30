using System;
using System.Windows;
using Microsoft.Practices.Composite.Events;
using Rupban.Core;
using Rupban.LoginModule.Controller;
using Rupban.LoginModule.Presenters;
using rupban.loginmodule.Views;
using Rupban.UI.Infrastructure.Event;

namespace rupban.loginmodule.Presenters
{
    public class PeerBoxPresenter : DependencyObject, IPeerBoxPresenter
    {
        private readonly IRupbanBoardController _rupbanBoardController;
        private readonly IEventAggregator _eventAggregator;

        public static readonly DependencyProperty PeerboxProperty = DependencyProperty.Register(
            "Peerbox",
            typeof(PeerBox),
            typeof(PeerBoxPresenter), new FrameworkPropertyMetadata(new PropertyChangedCallback(OnPropertyChanged)));

        private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {

        }

        public PeerBoxPresenter(IPeerBoxView view,IRupbanBoardController rupbanBoardController,IEventAggregator eventAggregator)
        {
            _rupbanBoardController = rupbanBoardController;
            _eventAggregator = eventAggregator;
            View = view;
            View.SetModel(this);


           
        }



        

        public PeerBox PeerBox
        {
            get { return (PeerBox)GetValue(PeerboxProperty); }
            set { SetValue(PeerboxProperty, value); }
        }

        public IPeerBoxView View
        {
            get;
            set;
        }

        public void TicketDroped(Ticket ticket)
        {
            var tergetId = this.PeerBox.Id;
            var templateColumnId = _rupbanBoardController.GetTemplateColumnByTicketId(ticket.Id);
            if (templateColumnId != null)
                _eventAggregator.GetEvent<TicketDropedEvent>().Publish(new TickedMoveEventArgs() { Ticket = ticket, SourceId = templateColumnId, TargetId = tergetId, SourceType = ColumnType.TicketHolderColumn, TargetType = ColumnType.PeerBoxHolderColumn });
  
        }

        public TemplateCell TemplateCell
        {
            get; set;
        }
    }
}