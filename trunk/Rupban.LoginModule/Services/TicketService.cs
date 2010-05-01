using System;
using Microsoft.Practices.Unity;
using Rupban.Core;
using Rupban.ServiceAgent;

namespace Rupban.LoginModule.Services
{
    public class TicketService : ITicketService
    {
        private readonly IServiceCallerAgent _serviceCallerAgent;

        public TicketService(IUnityContainer container)
        {
            try
            {
                _serviceCallerAgent = container.Resolve<IServiceCallerAgent>(); 
            }
            catch
            {
            }
            
        }

        public void MoveTicket(Ticket ticket, string sourceId, string targetId)
        {
            _serviceCallerAgent.MoveTicket(ticket, sourceId, targetId);
        }
       

        public void ViewTicketHistory()
        {
            _serviceCallerAgent.ViewTicketHistory();
        }

        public void PickTicket()
        {
            throw new NotImplementedException();
        }
    }
}