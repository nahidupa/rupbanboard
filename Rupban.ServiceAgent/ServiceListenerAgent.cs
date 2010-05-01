using System.ServiceModel;
using Rupban.Core;
using Rupban.ServiceAgent.RupbanBoardService;

namespace Rupban.ServiceAgent
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class ServiceListenerAgent : IServiceLisnerAgent, IRupbanBoardServiceCallback
    {
        readonly RupbanBoardServiceClient _boardServiceClient;
        public delegate void CallbackTicketMoved(Ticket ticket, string sourceId, string targetId);
        public event CallbackTicketMoved TicketMovedCalBack;

        public ServiceListenerAgent()
        {
            var instanceContext = new InstanceContext(this);
            _boardServiceClient = new RupbanBoardServiceClient(instanceContext);
            try
            {
                _boardServiceClient.Subscribe();
            }catch
            {
            }
        }

        public void TicketMoved(Ticket ticket, string sourceId, string targetId)
        {
            if (TicketMovedCalBack != null)
            {
                TicketMovedCalBack(ticket, sourceId, targetId);
            }
        }
    }
}