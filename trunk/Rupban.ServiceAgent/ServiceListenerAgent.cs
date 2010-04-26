using System.ServiceModel;
using Rupban.ServiceAgent.RupbanBoardService;

namespace Rupban.ServiceAgent
{
    [CallbackBehavior(ConcurrencyMode = ConcurrencyMode.Reentrant)]
    public class ServiceListenerAgent : IServiceLisnerAgent, IRupbanBoardServiceCallback
    {
        readonly RupbanBoardServiceClient _boardServiceClient;
        public delegate void CallbackTicketMoved();
        public event CallbackTicketMoved TicketMovedCalBack;

        public ServiceListenerAgent()
        {
            var instanceContext = new InstanceContext(this);
            _boardServiceClient = new RupbanBoardServiceClient(instanceContext);
            _boardServiceClient.Subscribe();

        }

        public void TicketMoved()
        {
            if (TicketMovedCalBack != null)
            {
                TicketMovedCalBack();
            }
        }
    }
}