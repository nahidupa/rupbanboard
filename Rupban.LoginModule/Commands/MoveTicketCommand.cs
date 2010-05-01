using System;
using rupban.loginmodule.Controller;
using Rupban.LoginModule.Services;
using Rupban.UI.Infrastructure.Event;

namespace rupban.loginmodule.Commands
{
    public class MoveTicketCommand : IMoveTicketCommand
    {
        private readonly ITicketService _ticketService;
     


        public MoveTicketCommand(ITicketService ticketService)
        {
            _ticketService = ticketService;
           
        }

        public void Execute(object parameter)
        {
           var tickedMoveEventArgs= (TickedMoveEventArgs) parameter;
           _ticketService.MoveTicket(tickedMoveEventArgs.Ticket,tickedMoveEventArgs.SourceId,tickedMoveEventArgs.TargetId);
            
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
    }
}