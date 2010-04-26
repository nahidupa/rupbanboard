using Rupban.ServiceAgent.RupbanBoardService;

namespace Rupban.ServiceAgent
{
    public class CallbackHandler : IRupbanBoardServiceCallback
    {
        public delegate void CallbackTicketMoved();

        public event CallbackTicketMoved TicketMovedCalBack;

        public void TicketMoved()
        {
            if(TicketMovedCalBack!=null)
            {
                TicketMovedCalBack();
            }

        }
    }
}