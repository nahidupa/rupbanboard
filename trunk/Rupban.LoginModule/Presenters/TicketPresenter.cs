using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Input;
using Microsoft.Practices.Composite.Presentation.Commands;
using Rupban.Core;
using rupban.loginmodule.Commands;
using rupban.loginmodule.Controller;
using rupban.loginmodule.Views;

namespace rupban.loginmodule.Presenters
{
    public class TicketPresenter : DependencyObject,ITicketPresenter
    {
       
        public ICommand MoveTicketCommand { set; get; }
        public Ticket Ticket
        {
            get { return (Ticket)GetValue(TicketProperty); }
            set { SetValue(TicketProperty, value); }
        }

        public static readonly DependencyProperty TicketProperty = DependencyProperty.Register(
       "Ticket",
       typeof(Ticket),
       typeof(TicketPresenter), new FrameworkPropertyMetadata(new PropertyChangedCallback(OnPropertyChanged)));

        private static void OnPropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            
        }

        public TicketPresenter(ITicketView view, IMoveTicketCommand moveTicketCommand)
        {
            View = view;
            View.SetModel(this);
          

            MoveTicketCommand = moveTicketCommand;
        }

       

        public ITicketView View
        {
            get ;
            set ;
        }
    }
}
