using System.ServiceModel;

namespace Rupban.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRupbanBoardService" in both code and config file together.
    [ServiceContract]
    public interface IRupbanBoardService
    {

        [OperationContract]
        void MoveTicket();

       
    }


   
}
