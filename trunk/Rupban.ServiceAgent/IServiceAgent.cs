namespace Rupban.ServiceAgent
{
    public interface IServiceAgent
    {
        void MoveTicket();
        void ViewTicketHistory();
        CallbackHandler GetCallbackHandler();
    }
}