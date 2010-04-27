using System.Collections.Generic;
using Rupban.Core;

namespace Rupban.ServiceAgent
{
    public interface IServiceCallerAgent
    {
        void MoveTicket(Ticket ticket, string currentColumnName, string destinationColumnName);
        void ViewTicketHistory();
        List<Project> GetCurrentProjectList();
        List<TemplateColumn> GetTemplateCollumList();
    }
}