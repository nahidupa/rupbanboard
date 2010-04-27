using System;
using Microsoft.Practices.Unity;
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

        public void MoveTicket()
        {
            _serviceCallerAgent.MoveTicket();
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