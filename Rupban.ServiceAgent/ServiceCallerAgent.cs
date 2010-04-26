using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using Rupban.ServiceAgent.RupbanBoardService;

namespace Rupban.ServiceAgent
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class ServiceCallerAgent : IServiceAgent, IRupbanBoardServiceCallback
    {
        readonly RupbanBoardServiceClient _boardServiceClient ;
        public ServiceCallerAgent()
        {
            var instanceContext = new InstanceContext(this);
            _boardServiceClient = new RupbanBoardServiceClient(instanceContext);
           
        }
        public void MoveTicket()
        {
            _boardServiceClient.MoveTicket();
        }

        public void ViewTicketHistory()
        {
            throw new NotImplementedException();
        }

        public void TicketMoved()
        {
            throw new NotImplementedException();
        }
    }
}
