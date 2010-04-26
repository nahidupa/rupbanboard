using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Microsoft.Practices.Composite.Presentation.Commands;
using rupban.loginmodule.Commands;
using rupban.loginmodule.Controller;
using rupban.loginmodule.Views;

namespace rupban.loginmodule.Presenters
{
    public class TicketPresenter : ITicketPresenter
    {
       
        public ICommand MoveTicketCommand { set; get; }

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
