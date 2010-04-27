using System.Collections.Generic;
using Rupban.Core;

namespace Rupban.ServiceAgent
{
    public interface IServiceCallerAgent
    {
        void MoveTicket(string ticketId, string currentColumnName, string destinationColumnName);
        void ViewTicketHistory();
        List<Project> GetCurrentProjectList();
        List<TemplateColumn> GetTemplateCollumList();
    }
}