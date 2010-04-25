using System;
using rupban.loginmodule.Controller;
using Rupban.LoginModule.Services;

namespace rupban.loginmodule.Commands
{
    public class PickTicketCommand : IPickTicketCommand
    {
        private readonly ITicketService _ticketService;
        private readonly ITicketController _ticketController;


        public PickTicketCommand(ITicketService ticketService, ITicketController ticketController)
        {
            _ticketService = ticketService;
            _ticketController = ticketController;
        }

        public void Execute(object parameter)
        {
            _ticketService.PickTicket();

        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public event EventHandler CanExecuteChanged;
    }
}