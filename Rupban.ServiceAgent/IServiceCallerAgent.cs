using System.Collections.Generic;
using Rupban.Core;

namespace Rupban.ServiceAgent
{
    public interface IServiceCallerAgent
    {
        void MoveTicket(Ticket ticket, string sourceId, string targetId);
        void ViewTicketHistory();
        List<Project> GetCurrentProjectList();
        List<TemplateColumn> GetTemplateCollumList();
    }
}