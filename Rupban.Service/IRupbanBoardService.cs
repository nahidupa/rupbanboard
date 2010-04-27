using System.Collections.Generic;
using System.ServiceModel;
using Rupban.Core;

namespace Rupban.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IRupbanBoardService" in both code and config file together.

    [ServiceContract(Namespace = "http://Code.google.com/p/rupbanboard", 
                 CallbackContract = typeof(IRupbanBoardServiceDuplexCallback))]

    public interface IRupbanBoardService
    {

        [OperationContract]
        void MoveTicket();

        [OperationContract]
        bool Subscribe();

        [OperationContract]
        bool Unsubscribe();

        [OperationContract]
        void ViewTicketHistory();

        [OperationContract]
        List<Project> GetCurrentProjectList();
        
        [OperationContract]
        List<TemplateColumn> GetTemplateCollumList();

    }
}
