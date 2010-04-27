using System;
using rupban.loginmodule.Controller;
using Rupban.LoginModule.Services;

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
            _ticketService.MoveTicket(parameter.ToString(), "", "");
            
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
    }
}