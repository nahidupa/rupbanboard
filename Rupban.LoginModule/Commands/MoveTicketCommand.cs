using System;
using rupban.loginmodule.Controller;
using Rupban.LoginModule.Services;

namespace rupban.loginmodule.Commands
{
    public class MoveTicketCommand : IMoveTicketCommand
    {
        private readonly ITicketService _ticketService;
        private readonly ITicketController _ticketController;


        public MoveTicketCommand(ITicketService ticketService, ITicketController ticketController)
        {
            _ticketService = ticketService;
            _ticketController = ticketController;
        }

        public void Execute(object parameter)
        {
            _ticketService.MoveTicket();
            
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
    }
}