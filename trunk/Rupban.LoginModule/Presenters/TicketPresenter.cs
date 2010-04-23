using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Microsoft.Practices.Composite.Presentation.Commands;
using rupban.loginmodule.Controller;
using rupban.loginmodule.Views;

namespace rupban.loginmodule.Presenters
{
    public class TicketPresenter : ITicketPresenter
    {
        private ITicketController _ticketController;
        public ICommand MoveTicketCommand { set; get; }

        public TicketPresenter(ITicketView view, ITicketController ticketController)
        {
            View = view;
            View.SetModel(this);
            _ticketController = ticketController;
            
            MoveTicketCommand = new DelegateCommand<object>(MoveTicket);
        }

        private void MoveTicket(object obj)
        {
            _ticketController.MoveTicket();
        }

        public ITicketView View
        {
            get ;
            set ;
        }
    }
}
